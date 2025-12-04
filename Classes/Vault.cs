using System;
using System.Collections.Generic;
using System.IO;                    
using System.Text.Json;


namespace Vaulty.Classes
{
    public class Vault
    {
        public string Name { get; set; }
        public string MasterPasswordHash { get; set; }


        //liste de toutes les catégories disponibles
        public List<string> Groups { get; set; } = new List<string>();

        //liste de toutes les entrées
        public List<Entry> Entries { get; set; } = new List<Entry>();

        //constructeur par défaut pr serialisation
        public Vault() { }
        public Vault(string name, string password)
        {
            Name = name;
            MasterPasswordHash = password;
            //groupes par defaut
            Groups.Add("Général");
            Groups.Add("Email");
        }
        public void Save(string filePath, string masterPassword)
        {
            // Convertit le vault en JSON
            string json = System.Text.Json.JsonSerializer.Serialize(this);

            // Chiffrement
            byte[] encrypted = Crypto.EncryptVault(json, masterPassword);

            // Écriture du fichier
            File.WriteAllBytes(filePath, encrypted);
        }
        public static Vault Load(string filePath, string masterPassword)
        {
            
            byte[] encryptedData = File.ReadAllBytes(filePath);

            try
            {
                
                string json = Crypto.DecryptVault(encryptedData, masterPassword);

                
                Vault vault = System.Text.Json.JsonSerializer.Deserialize<Vault>(json);

                return vault;
            }
            catch
            {
                return null;
            }
        }


    }
}