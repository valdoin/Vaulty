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
    public partial class ChangePasswordForm : Form
    {
        private string actualCurrentPassword;
        public string NewPassword { get; private set; }
        public ChangePasswordForm(string currentPassword)
        {
            InitializeComponent();
            actualCurrentPassword = currentPassword;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string inputCurrent = textBoxCurrentPassword.Text;
            string inputNew = textBoxNewPassword.Text;
            string inputConfirm = textBoxNewPasswordConfirm.Text;

            //mdp actuel correct ?
            if (inputCurrent != actualCurrentPassword)
            {
                MessageBox.Show("Le mot de passe actuel est incorrect.", "Erreur de sécurité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCurrentPassword.Clear();
                textBoxCurrentPassword.Focus();
                return;
            }

            //nouveau mdp vide ?
            if (string.IsNullOrWhiteSpace(inputNew))
            {
                MessageBox.Show("Le nouveau mot de passe ne peut pas être vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //mdp de minimum 8 caracteres ?
            if (inputNew.Length < 8)
            {
                MessageBox.Show("Le nouveau mot de passe doit contenir au moins 8 caractères.", "Sécurité insuffisante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //mdp = mdp confirm ?
            if (inputNew != inputConfirm)
            {
                MessageBox.Show("La confirmation ne correspond pas au nouveau mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNewPasswordConfirm.Clear();
                return;
            }
            this.NewPassword = inputNew;
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
