using System;
using System.Collections.Generic;

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
    }
}