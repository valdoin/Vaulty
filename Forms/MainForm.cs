using Vaulty.Classes;
using Vaulty.Forms;

namespace Vaulty
{
    public partial class MainForm : Form
    {

        private List<PasswordEntry> database = new List<PasswordEntry>(); //on stocke les mdp en memoire avant de les stocker dans le fichier chiffré
        private string masterPasswordHash = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new MasterPasswordForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //user a defini un mdp valide
                    this.database.Clear(); //on vide l'interface
                    this.masterPasswordHash = form.EnteredPassword;
                    MessageBox.Show("Nouvelle base créée avec succès !");
                }
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}