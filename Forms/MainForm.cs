using System.Windows.Forms;
using Vaulty.Classes;
using Vaulty.Forms;

namespace Vaulty
{
    public partial class MainForm : Form
    {
        private string currentVaultName = "";
        private List<PasswordEntry> database = new List<PasswordEntry>(); //on stocke les mdp en memoire avant de les stocker dans le fichier chiffré
        private string masterPasswordHash = "";
        private List<string> groups = new List<string>();
        private string currentSearchTerm = "";
        public MainForm()

        {
            InitializeComponent();
            //categories par defaut, libre a l'utilisateur de les garder ou de les supprimer
            groups.Add("Général");
            groups.Add("Email");
            LockInterface();
        }

        //gestion du treeview
        private void InitializeTreeView()
        {
            treeViewGroups.Nodes.Clear();

            //creation de la racine
            TreeNode root = new TreeNode(this.currentVaultName);

            //ajout des catégories dynamiques
            foreach (string cat in groups)
            {
                root.Nodes.Add(cat);
            }

            treeViewGroups.Nodes.Add(root);
            treeViewGroups.ExpandAll();

            //on selectionne la racine par defaut
            if (root.Nodes.Count > 0) treeViewGroups.SelectedNode = root.Nodes[0];
        }

        //gestion de l'etat de l'interface
        private void LockInterface()
        {
            treeViewGroups.Enabled = false;
            listViewEntries.Enabled = false;
            treeViewGroups.Nodes.Clear();
            listViewEntries.Items.Clear();

            //on desactive le bouton d'ajout d'entrée
            if (Controls.Find("buttonAddEntry", true).Length > 0)
                Controls.Find("buttonAddEntry", true)[0].Enabled = false;
        }

        private void UnlockInterface()
        {
            treeViewGroups.Enabled = true;
            listViewEntries.Enabled = true;

            InitializeTreeView();

            //reactiver le bouton d'ajout d'entrée
            if (Controls.Find("buttonAddEntry", true).Length > 0)
                Controls.Find("buttonAddEntry", true)[0].Enabled = true;

            //par defaut rien n'est selectionnable donc on desactive tous les boutons de copie
            buttonCopyUsername.Enabled = false;
            buttonCopyPassword.Enabled = false;
            buttonCopyURL.Enabled = false;
        }
        //gestion de la listview contenant les mdp
        private void RefreshListView()
        {
            listViewEntries.Items.Clear();

            List<PasswordEntry> filteredList;

            //recherche en cours
            if (!string.IsNullOrWhiteSpace(currentSearchTerm))
            {
                string term = currentSearchTerm.ToLower(); //recherche insensible a la casse
                //on cherche dans toute la base, recherche sur le titre, l'username et les notes s'il y en a 
                filteredList = database.Where(entry =>
                    (entry.Title != null && entry.Title.ToLower().Contains(term)) ||
                    (entry.Username != null && entry.Username.ToLower().Contains(term)) ||
                    (entry.Notes != null && entry.Notes.ToLower().Contains(term))
                ).ToList();
            }
            else
            {
                //pas de recherche en cours
                if (treeViewGroups.SelectedNode == null) return;
                string selectedCategory = treeViewGroups.SelectedNode.Text;

                if (selectedCategory == this.currentVaultName)
                {
                    filteredList = database;
                }
                else
                {
                    filteredList = database.Where(entry => entry.Group == selectedCategory).ToList();
                }
            }
            //remplissage de la listview pour affichage
            foreach (var entry in filteredList)
            {
                var item = new ListViewItem(entry.Title);
                item.SubItems.Add(entry.Username);
                item.SubItems.Add("************"); //mdp masqué
                item.SubItems.Add(entry.Url);
                item.SubItems.Add(entry.Notes);
                item.Tag = entry;
                listViewEntries.Items.Add(item);
            }
        }

        private void treeViewCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //quand on change de catégorie de mdp, on refresh la liste de mdp associée
            RefreshListView();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new NewVaultForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //user a defini un mdp valide
                    this.database.Clear(); //on vide l'interface
                    this.currentVaultName = form.VaultName;
                    this.masterPasswordHash = form.EnteredPassword;
                    MessageBox.Show("Nouvelle base créée avec succès !");
                    UnlockInterface();
                }
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            //base de donnée ouverte ?
            if (string.IsNullOrEmpty(masterPasswordHash))
            {
                MessageBox.Show("Veuillez créer ou ouvrir une base de données (Fichier > Nouveau).");
                return;
            }

            //existe t'il au moins une categorie ?
            if (groups.Count == 0)
            {
                MessageBox.Show("Vous n'avez aucune catégorie !\n" +
                                "Faites un Clic Droit sur 'Mon Coffre fort' pour en créer une nouvelle.",
                                "Aucune catégorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string defaultGroup = null;

            //si un noeud est selectionné dans l'arbre
            if (treeViewGroups.SelectedNode != null)
            {
                string selectedName = treeViewGroups.SelectedNode.Text;

                //on verifie que ce n'est pas le noeud racine et que ce groupe existe bel et bien
                if (selectedName != this.currentVaultName && groups.Contains(selectedName))
                {
                    defaultGroup = selectedName;
                }
            }

            //ouverture du formulaire d'ajout avec la liste des categories
            using (var form = new AddEditEntryForm(this.groups, null, defaultGroup))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    PasswordEntry newEntry = form.FinalEntry;
                    database.Add(newEntry);
                    RefreshListView();
                }
            }
        }

        private void ajouterUneCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var form = new AddGroupForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string newGroupName = form.EnteredName;
                    //on vérifie si doublons
                    if (groups.Contains(newGroupName))
                    {
                        MessageBox.Show("Cette catégorie existe déjà !");
                        return;
                    }
                    groups.Add(newGroupName);
                    if (treeViewGroups.Nodes.Count > 0)
                    {
                        treeViewGroups.Nodes[0].Nodes.Add(newGroupName);
                        treeViewGroups.Nodes[0].Expand();
                    }
                }
            }
        }

        private void supprimerLaCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //on recupere le noeud selectionné
            TreeNode selectedNode = treeViewGroups.SelectedNode;

            if (selectedNode == null || selectedNode.Level == 0)
            {
                MessageBox.Show("Impossible de supprimer cet élément.");
                return;
            }

            string categoryName = selectedNode.Text;

            //la categorie selectionnée est elle vide ?
            bool hasPasswords = database.Any(entry => entry.Group == categoryName);

            if (hasPasswords)
            {
                MessageBox.Show($"La catégorie '{categoryName}' contient des mots de passe.\nSupprimez-les d'abord.",
                                "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Supprimer '{categoryName}' ?", "Confirmer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                groups.Remove(categoryName);
                selectedNode.Remove();
                RefreshListView();
            }
        }

        private void treeViewGroups_MouseUp(object sender, MouseEventArgs e)
        {
            //on ne reagit qu'au clic droit
            if (e.Button == MouseButtons.Right)
            {
                //qu'est ce qu'on a sous notre curseur ?
                //hitTest determine si on a cliqué sur un noeud ou dans le vide
                TreeViewHitTestInfo hitTest = treeViewGroups.HitTest(e.Location);

                if (hitTest.Node != null)
                {
                    //clic noeud
                    treeViewGroups.SelectedNode = hitTest.Node;

                    //est ce la racine ? 
                    if (hitTest.Node.Level == 0)
                    {
                        //on ne peut pas la supprimer (revient a supprimer la bd)
                        supprimerLaCatégorieToolStripMenuItem.Visible = false;
                    }
                    else
                    {
                        //catégorie normale => on peut la supprimer
                        supprimerLaCatégorieToolStripMenuItem.Visible = true;
                    }
                }
                else
                {
                    //clic dans le vide, on propose uniquement l'ajout
                    supprimerLaCatégorieToolStripMenuItem.Visible = false;
                    // treeViewGroups.SelectedNode = null; 
                }
                //on affiche le menu contextuel
                contextMenuStripAddDeleteGroup.Show(treeViewGroups, e.Location);
            }
        }

        private void listViewEntries_MouseUp(object sender, MouseEventArgs e)
        {
            //on ne reagit qu'au clic droit
            if (e.Button == MouseButtons.Right)
            {
                //on cherche ce qu'il y a sous le curseur
                ListViewHitTestInfo hitTest = listViewEntries.HitTest(e.Location);

                if (hitTest.Item != null)
                {
                    //clic sur une entrée existante
                    listViewEntries.SelectedItems.Clear();
                    hitTest.Item.Selected = true;
                    hitTest.Item.Focused = true;

                    //on affiche tout
                    ajouterUneEntréeToolStripMenuItem.Visible = true;
                    supprimerLentréeToolStripMenuItem.Visible = true;
                    modifierLentréeToolStripMenuItem.Visible = true;
                    copierLeNomDutilisateurToolStripMenuItem.Visible = true;
                    copierLeMotDePasseToolStripMenuItem.Visible = true;
                    copierLURLToolStripMenuItem.Visible = true;

                }
                else
                {
                    //clic dans le vide
                    listViewEntries.SelectedItems.Clear();

                    //on affiche ajouter on cache tout le reste
                    ajouterUneEntréeToolStripMenuItem.Visible = true;
                    supprimerLentréeToolStripMenuItem.Visible = false;
                    modifierLentréeToolStripMenuItem.Visible = false;
                    copierLeNomDutilisateurToolStripMenuItem.Visible = false;
                    copierLeMotDePasseToolStripMenuItem.Visible = false;
                    copierLURLToolStripMenuItem.Visible = false;
                }

                //on affiche le menu contextuel
                contextMenuStripEntries.Show(listViewEntries, e.Location);
            }
        }

        private void listViewEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on regarde si au moins un element de la liste est selectionné
            bool hasSelection = listViewEntries.SelectedItems.Count > 0;

            //on active ou desactive les boutons selon le resultat
            buttonCopyUsername.Enabled = hasSelection;
            buttonCopyPassword.Enabled = hasSelection;
            buttonCopyURL.Enabled = hasSelection;
        }

        private void ajouterUneEntréeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //on reutilise la logique du boutton AddEntry
            buttonAddEntry_Click(sender, e);
        }

        private void supprimerLentréeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewEntries.SelectedItems.Count == 0) return;

            //on recupere l'objet lié à la ligne
            ListViewItem selectedItem = listViewEntries.SelectedItems[0];
            PasswordEntry entryToDelete = (PasswordEntry)selectedItem.Tag;

            if (MessageBox.Show($"Voulez-vous supprimer l'entrée '{entryToDelete.Title}' ?",
                                "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                database.Remove(entryToDelete);
                listViewEntries.Items.Remove(selectedItem);
            }
        }

        private void modifierLentréeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewEntries.SelectedItems.Count == 0) return;

            //on recupere l'objet selectionné
            var selectedItem = listViewEntries.SelectedItems[0];
            var entryToEdit = (PasswordEntry)selectedItem.Tag;

            //ouvrir le formulaire en lui passant l'objet et la liste des groupes
            using (var form = new AddEditEntryForm(this.groups, entryToEdit))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //l'objet a été modifié directement par référence dans le form donc pas besoin d'add ou remove
                    RefreshListView();
                }
            }
        }
        private void CopyTimer_Tick(object sender, EventArgs e)
        {
            if (toolStripProgressBarCopy.Value > 0)
            {
                //s'il reste du temps on decremente la barre
                toolStripProgressBarCopy.Value -= 1;

                //on met a jour le texte avec le decompte precis
                toolStripStatusLabelCopy.Text = $"Copié ! Effacement dans {toolStripProgressBarCopy.Value}s...";
            }
            else
            {
                CopyTimer.Stop(); //on arrete le chrono
                Clipboard.Clear(); // on vide le presse papiers

                //on cache la barre et le texte
                toolStripStatusLabelCopy.Visible = false;
                toolStripStatusLabelCopy.Visible = false;
            }
        }

        private void CopyToClipboardTemporary(string text)
        {
            if (string.IsNullOrEmpty(text)) return;

            Clipboard.SetText(text);

            //on initialise la barre de progression
            toolStripProgressBarCopy.Visible = true;
            toolStripProgressBarCopy.Maximum = 15;
            toolStripProgressBarCopy.Value = 15;
            toolStripProgressBarCopy.Step = -1;

            //on affiche le texte
            toolStripStatusLabelCopy.Visible = true;
            toolStripStatusLabelCopy.Text = "Copié ! Effacement dans 15s...";

            CopyTimer.Stop();  //reset si déjà en cours
            CopyTimer.Start();
        }
        private void copierLeNomDutilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewEntries.SelectedItems.Count == 0) return;
            var entry = (PasswordEntry)listViewEntries.SelectedItems[0].Tag;
            CopyToClipboardTemporary(entry.Username);
        }

        private void copierLeMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewEntries.SelectedItems.Count == 0) return;
            var entry = (PasswordEntry)listViewEntries.SelectedItems[0].Tag;
            CopyToClipboardTemporary(entry.Password);
        }

        private void copierLURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewEntries.SelectedItems.Count == 0) return;
            var entry = (PasswordEntry)listViewEntries.SelectedItems[0].Tag;

            CopyToClipboardTemporary(entry.Url);
        }

        private void toolStripTextBoxSearchEntry_TextChanged(object sender, EventArgs e)
        {
            currentSearchTerm = toolStripTextBoxSearchEntry.Text;
            RefreshListView();
        }
    }
}