using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaulty.Forms
{
    public partial class MasterPasswordForm : Form
    {
        public string EnteredPassword { get; private set; }
        public MasterPasswordForm()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string pass = textBoxMasterPassword.Text;
            string confirm = textBoxConfirmPassword.Text;

            //textbox vide ?
            if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Le mot de passe ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //mdp identiques ?
            if (pass != confirm)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //on vide la textbox pour que l'user retape
                textBoxConfirmPassword.Clear();
                return;
            }

            //si ca passe les deux vérifications
            this.EnteredPassword = pass; //on sauvegarde le mdp en memoire pour le moment
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
