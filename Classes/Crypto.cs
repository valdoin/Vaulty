using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Vaulty.Classes
{
    public static class Crypto
    {
        // 1) Dérivation de la clé depuis le mot de passe
        public static byte[] DeriveKey(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(32); // AES-256
            }
        }

        // 2) Chiffrement JSON -> bytes chiffrés
        public static byte[] EncryptVault(string json, string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] iv = RandomNumberGenerator.GetBytes(16);
            byte[] key = DeriveKey(password, salt);

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;

                using (var ms = new MemoryStream())
                {
                    // On stocke salt + iv au début du fichier
                    ms.Write(salt);
                    ms.Write(iv);

                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs))
                    {
                        sw.Write(json);
                    }

                    return ms.ToArray();
                }
            }
        }

        // 3) Déchiffrement bytes -> JSON
        public static string DecryptVault(byte[] data, string password)
        {
            byte[] salt = data.Take(16).ToArray();
            byte[] iv = data.Skip(16).Take(16).ToArray();
            byte[] ciphertext = data.Skip(32).ToArray();
            byte[] key = DeriveKey(password, salt);

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;

                using (var ms = new MemoryStream(ciphertext))
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}
