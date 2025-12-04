using System;
using System.Windows.Forms;
using Vaulty.Classes;

namespace Vaulty
{
    internal static class Program
    {
        public static MainForm MainFormInstance;
        public static LocalServer Server;

        /// <summary>
        ///  Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Crée la fenêtre principale
            MainFormInstance = new MainForm();

            // Démarre le serveur local UNE SEULE FOIS pour toute l'appli
            Server = new LocalServer();
            Server.Start(50000); // port qu'on a vérifié libre

            // Lance l'UI
            Application.Run(MainFormInstance);
        }
    }
}
