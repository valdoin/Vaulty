using System;
using System.Security.Cryptography;
using System.Text;

namespace Vaulty.Classes
{
    public static class PasswordHasher
    {
        // Génère un salt aléatoire de 32 bytes (base64)
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[32];
            RandomNumberGenerator.Fill(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }

        // Hash = SHA256(password + salt)
        public static string HashPassword(string password, string salt)
        {
            var sha = SHA256.Create();
            string input = password + salt;
            byte[] hashBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hashBytes);
        }

        // Vérification du mot de passe
        public static bool Verify(string password, string salt, string hash)
        {
            string attemptHash = HashPassword(password, salt);
            return attemptHash == hash;
        }
    }
}
