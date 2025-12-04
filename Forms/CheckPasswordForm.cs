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
    public partial class CheckPasswordForm : Form
    {
        public string EnteredPassword { get; private set; }
        public CheckPasswordForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //mdp vide ?
            if (string.IsNullOrWhiteSpace(textBoxCheckPassword.Text))
            {
                MessageBox.Show("Le champ ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            EnteredPassword = textBoxCheckPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
