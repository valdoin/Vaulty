using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaulty.Classes;

namespace Vaulty.Forms
{
    public partial class AddEditEntryForm : Form
    {
        public Entry FinalEntry { get; private set; } //l'objet final qu'il soit nouveau ou modifié
        private Entry OriginalEntry; //pour savoir si on modifie ou on crée
        public AddEditEntryForm(List<string> availableGroups, Entry entryToEdit = null, string defaultGroup = null)
        {
            InitializeComponent();

            OriginalEntry = entryToEdit;
            comboBoxGroup.Items.Clear();
            foreach (string group in availableGroups)
            {
                comboBoxGroup.Items.Add(group);
            }

            if (OriginalEntry != null)
            {
                //mode modification donc on préremplit les champs
                this.Text = "Modifier l'entrée"; //on change le titre de la fenêtre
                comboBoxGroup.Text = OriginalEntry.Group;
                textBoxTitle.Text = OriginalEntry.Title;
                textBoxUsername.Text = OriginalEntry.Username;
                textBoxPassword.Text = OriginalEntry.Password;
                textBoxURL.Text = OriginalEntry.Url;
                textBoxNotes.Text = OriginalEntry.Notes;
            }
            else
            {
                //on reçoit un groupe valide (ex: "Email" ou "Général")
                if (!string.IsNullOrEmpty(defaultGroup) && comboBoxGroup.Items.Contains(defaultGroup))
                {
                    comboBoxGroup.Text = defaultGroup;
                }
                //par defaut on prend le premier pour eviter les erreurs
                else if (comboBoxGroup.Items.Count > 0)
                {

                    comboBoxGroup.SelectedIndex = 0;
                }
            }
        }

        //générateur de mot de passe
        private void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
            //liste etendue des caracteres min/maj/chiffres/symboles
            const string lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string specials = "!@#$%^&*()_-+=[{]};:<>|./?";

            string allChars = lowercase + uppercase + digits + specials;

            Random random = new Random();
            //selon l'ANSSI, mdp de plus de 15 caracteres avec min/maj/chiffres/symboles => tres fort
            char[] stringChars = new char[20];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = allChars[random.Next(allChars.Length)];
            }

            string finalPass = new String(stringChars);

            textBoxPassword.Text = finalPass;
            // checkBoxShowPassword.Checked = true; 
        }

        //calcul de la force du mot de passe
        private void UpdateStrengthMeter(string pass)
        {
            int score = 0;

            if (string.IsNullOrEmpty(pass))
            {
                progressBarPassword.Value = 0;
                return;
            }

            //criteres de score défini
            if (pass.Length >= 8) score += 20;  //longueur minimale
            if (pass.Length >= 12) score += 20; //longueur recommandée
            if (pass.Any(char.IsUpper)) score += 20; //contient majuscule
            if (pass.Any(char.IsDigit)) score += 20; //contient chiffre
            if (pass.Any(char.IsSymbol) || pass.Any(char.IsPunctuation)) score += 20; //contient symbole

            if (score > 100) score = 100;

            progressBarPassword.Value = score;
        }

        //si le mdp est saisi manuellement, la progress bar doit bouger en direct
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateStrengthMeter(textBoxPassword.Text);
        }

        //permet d'afficher/masquer le mdp
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //on verifie si l'un des champs obligatoires est vide (tout sauf URL et notes)
            if (string.IsNullOrWhiteSpace(comboBoxGroup.Text) ||
                string.IsNullOrWhiteSpace(textBoxTitle.Text) ||
                string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires :\n" +
                        "- Catégorie\n" +
                        "- Titre\n" +
                        "- Nom d'utilisateur\n" +
                        "- Mot de passe",
                        "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None; //empeche la fermeture
                return;
            }

            string group = comboBoxGroup.Text;
            string title = textBoxTitle.Text;
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;
            string url = textBoxURL.Text;
            string notes = textBoxNotes.Text;

            if (OriginalEntry == null)
            {
                //nouvelle entrée
                FinalEntry = new Entry(group, title, user, pass, url, notes);
            }
            else
            {
                //on modifie une entrée existante
                FinalEntry = OriginalEntry;
                FinalEntry.Group = comboBoxGroup.Text;
                FinalEntry.Title = textBoxTitle.Text;
                FinalEntry.Username = textBoxUsername.Text;
                FinalEntry.Password = textBoxPassword.Text;
                FinalEntry.Url = textBoxURL.Text;
                FinalEntry.Notes = textBoxNotes.Text;
                FinalEntry.ModifiedDate = DateTime.Now; 
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
