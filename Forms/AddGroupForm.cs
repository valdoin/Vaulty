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
    public partial class AddGroupForm : Form
    {
        public string EnteredName { get; private set; }
        public AddGroupForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //on refuse les noms vides
            if (string.IsNullOrWhiteSpace(textBoxGroupName.Text))
            {
                MessageBox.Show("Le nom de la catégorie ne peut pas être vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //on empeche fermeture de la fenetre a cause de dialogresult
                this.DialogResult = DialogResult.None;
                return;
            }

            EnteredName = textBoxGroupName.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
