namespace Vaulty
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1File = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            nouveauToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            sauvegarderToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            treeViewGroups = new TreeView();
            listViewEntries = new ListView();
            Titre = new ColumnHeader();
            Login = new ColumnHeader();
            MotDePasse = new ColumnHeader();
            URL = new ColumnHeader();
            Notes = new ColumnHeader();
            contextMenuStripAddDeleteGroup = new ContextMenuStrip(components);
            ajouterUneCatégorieToolStripMenuItem = new ToolStripMenuItem();
            supprimerLaCatégorieToolStripMenuItem = new ToolStripMenuItem();
            toolStripUtils = new ToolStrip();
            buttonAddEntry = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            buttonCopyUsername = new ToolStripButton();
            buttonCopyPassword = new ToolStripButton();
            buttonCopyURL = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            buttonSearchEntry = new ToolStripButton();
            toolStripTextBoxSearchEntry = new ToolStripTextBox();
            contextMenuStripEntries = new ContextMenuStrip(components);
            ajouterUneEntréeToolStripMenuItem = new ToolStripMenuItem();
            supprimerLentréeToolStripMenuItem = new ToolStripMenuItem();
            modifierLentréeToolStripMenuItem = new ToolStripMenuItem();
            copierLeNomDutilisateurToolStripMenuItem = new ToolStripMenuItem();
            copierLeMotDePasseToolStripMenuItem = new ToolStripMenuItem();
            copierLURLToolStripMenuItem = new ToolStripMenuItem();
            CopyTimer = new System.Windows.Forms.Timer(components);
            statusStripCopy = new StatusStrip();
            toolStripStatusLabelCopy = new ToolStripStatusLabel();
            toolStripProgressBarCopy = new ToolStripProgressBar();
            menuStrip1File.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            contextMenuStripAddDeleteGroup.SuspendLayout();
            toolStripUtils.SuspendLayout();
            contextMenuStripEntries.SuspendLayout();
            statusStripCopy.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1File
            // 
            menuStrip1File.ImageScalingSize = new Size(20, 20);
            menuStrip1File.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem });
            menuStrip1File.Location = new Point(0, 0);
            menuStrip1File.Name = "menuStrip1File";
            menuStrip1File.Size = new Size(1378, 28);
            menuStrip1File.TabIndex = 0;
            menuStrip1File.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, ouvrirToolStripMenuItem, sauvegarderToolStripMenuItem, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(66, 24);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(175, 26);
            nouveauToolStripMenuItem.Text = "Nouveau";
            nouveauToolStripMenuItem.Click += nouveauToolStripMenuItem_Click;
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(175, 26);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // sauvegarderToolStripMenuItem
            // 
            sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            sauvegarderToolStripMenuItem.Size = new Size(175, 26);
            sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(175, 26);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeViewGroups);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listViewEntries);
            splitContainer1.Size = new Size(1378, 743);
            splitContainer1.SplitterDistance = 459;
            splitContainer1.TabIndex = 1;
            // 
            // treeViewGroups
            // 
            treeViewGroups.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeViewGroups.Location = new Point(0, 30);
            treeViewGroups.Name = "treeViewGroups";
            treeViewGroups.Size = new Size(459, 713);
            treeViewGroups.TabIndex = 0;
            treeViewGroups.AfterSelect += treeViewCategories_AfterSelect;
            treeViewGroups.MouseUp += treeViewGroups_MouseUp;
            // 
            // listViewEntries
            // 
            listViewEntries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listViewEntries.Columns.AddRange(new ColumnHeader[] { Titre, Login, MotDePasse, URL, Notes });
            listViewEntries.FullRowSelect = true;
            listViewEntries.GridLines = true;
            listViewEntries.Location = new Point(0, 30);
            listViewEntries.Name = "listViewEntries";
            listViewEntries.Size = new Size(802, 713);
            listViewEntries.TabIndex = 0;
            listViewEntries.UseCompatibleStateImageBehavior = false;
            listViewEntries.View = View.Details;
            listViewEntries.SelectedIndexChanged += listViewEntries_SelectedIndexChanged;
            listViewEntries.MouseUp += listViewEntries_MouseUp;
            // 
            // Titre
            // 
            Titre.Tag = "";
            Titre.Text = "Titre";
            Titre.Width = 160;
            // 
            // Login
            // 
            Login.Text = "Login";
            Login.Width = 160;
            // 
            // MotDePasse
            // 
            MotDePasse.Text = "Mot de passe";
            MotDePasse.Width = 160;
            // 
            // URL
            // 
            URL.Text = "URL";
            URL.Width = 160;
            // 
            // Notes
            // 
            Notes.Text = "Notes";
            Notes.Width = 160;
            // 
            // contextMenuStripAddDeleteGroup
            // 
            contextMenuStripAddDeleteGroup.ImageScalingSize = new Size(20, 20);
            contextMenuStripAddDeleteGroup.Items.AddRange(new ToolStripItem[] { ajouterUneCatégorieToolStripMenuItem, supprimerLaCatégorieToolStripMenuItem });
            contextMenuStripAddDeleteGroup.Name = "contextMenuStrip1";
            contextMenuStripAddDeleteGroup.Size = new Size(231, 52);
            // 
            // ajouterUneCatégorieToolStripMenuItem
            // 
            ajouterUneCatégorieToolStripMenuItem.Name = "ajouterUneCatégorieToolStripMenuItem";
            ajouterUneCatégorieToolStripMenuItem.Size = new Size(230, 24);
            ajouterUneCatégorieToolStripMenuItem.Text = "Ajouter une catégorie";
            ajouterUneCatégorieToolStripMenuItem.Click += ajouterUneCatégorieToolStripMenuItem_Click;
            // 
            // supprimerLaCatégorieToolStripMenuItem
            // 
            supprimerLaCatégorieToolStripMenuItem.Name = "supprimerLaCatégorieToolStripMenuItem";
            supprimerLaCatégorieToolStripMenuItem.Size = new Size(230, 24);
            supprimerLaCatégorieToolStripMenuItem.Text = "Supprimer la catégorie";
            supprimerLaCatégorieToolStripMenuItem.Click += supprimerLaCatégorieToolStripMenuItem_Click;
            // 
            // toolStripUtils
            // 
            toolStripUtils.ImageScalingSize = new Size(20, 20);
            toolStripUtils.Items.AddRange(new ToolStripItem[] { buttonAddEntry, toolStripSeparator1, buttonCopyUsername, buttonCopyPassword, buttonCopyURL, toolStripSeparator2, buttonSearchEntry, toolStripTextBoxSearchEntry });
            toolStripUtils.Location = new Point(0, 28);
            toolStripUtils.Name = "toolStripUtils";
            toolStripUtils.Size = new Size(1378, 27);
            toolStripUtils.TabIndex = 2;
            toolStripUtils.Text = "toolStrip1";
            // 
            // buttonAddEntry
            // 
            buttonAddEntry.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonAddEntry.Image = (Image)resources.GetObject("buttonAddEntry.Image");
            buttonAddEntry.ImageTransparentColor = Color.Magenta;
            buttonAddEntry.Name = "buttonAddEntry";
            buttonAddEntry.Size = new Size(29, 24);
            buttonAddEntry.Text = "Ajouter une entrée";
            buttonAddEntry.Click += buttonAddEntry_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // buttonCopyUsername
            // 
            buttonCopyUsername.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonCopyUsername.Image = (Image)resources.GetObject("buttonCopyUsername.Image");
            buttonCopyUsername.ImageTransparentColor = Color.Magenta;
            buttonCopyUsername.Name = "buttonCopyUsername";
            buttonCopyUsername.Size = new Size(29, 24);
            buttonCopyUsername.Text = "Copier le nom d'utilisateur";
            buttonCopyUsername.Click += copierLeNomDutilisateurToolStripMenuItem_Click;
            // 
            // buttonCopyPassword
            // 
            buttonCopyPassword.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonCopyPassword.Image = (Image)resources.GetObject("buttonCopyPassword.Image");
            buttonCopyPassword.ImageTransparentColor = Color.Magenta;
            buttonCopyPassword.Name = "buttonCopyPassword";
            buttonCopyPassword.Size = new Size(29, 24);
            buttonCopyPassword.Text = "Copier le mot de passe";
            buttonCopyPassword.Click += copierLeMotDePasseToolStripMenuItem_Click;
            // 
            // buttonCopyURL
            // 
            buttonCopyURL.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonCopyURL.Image = (Image)resources.GetObject("buttonCopyURL.Image");
            buttonCopyURL.ImageTransparentColor = Color.Magenta;
            buttonCopyURL.Name = "buttonCopyURL";
            buttonCopyURL.Size = new Size(29, 24);
            buttonCopyURL.Text = "Copier l'URL";
            buttonCopyURL.Click += copierLURLToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // buttonSearchEntry
            // 
            buttonSearchEntry.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonSearchEntry.Image = (Image)resources.GetObject("buttonSearchEntry.Image");
            buttonSearchEntry.ImageTransparentColor = Color.Magenta;
            buttonSearchEntry.Name = "buttonSearchEntry";
            buttonSearchEntry.Size = new Size(29, 24);
            buttonSearchEntry.Text = "Chercher une entrée";
            // 
            // toolStripTextBoxSearchEntry
            // 
            toolStripTextBoxSearchEntry.AutoToolTip = true;
            toolStripTextBoxSearchEntry.Name = "toolStripTextBoxSearchEntry";
            toolStripTextBoxSearchEntry.Size = new Size(160, 27);
            toolStripTextBoxSearchEntry.ToolTipText = "Chercher une entrée ";
            toolStripTextBoxSearchEntry.TextChanged += toolStripTextBoxSearchEntry_TextChanged;
            // 
            // contextMenuStripEntries
            // 
            contextMenuStripEntries.ImageScalingSize = new Size(20, 20);
            contextMenuStripEntries.Items.AddRange(new ToolStripItem[] { ajouterUneEntréeToolStripMenuItem, supprimerLentréeToolStripMenuItem, modifierLentréeToolStripMenuItem, copierLeNomDutilisateurToolStripMenuItem, copierLeMotDePasseToolStripMenuItem, copierLURLToolStripMenuItem });
            contextMenuStripEntries.Name = "contextMenuStripEntries";
            contextMenuStripEntries.Size = new Size(254, 148);
            // 
            // ajouterUneEntréeToolStripMenuItem
            // 
            ajouterUneEntréeToolStripMenuItem.Name = "ajouterUneEntréeToolStripMenuItem";
            ajouterUneEntréeToolStripMenuItem.Size = new Size(253, 24);
            ajouterUneEntréeToolStripMenuItem.Text = "Ajouter une entrée";
            ajouterUneEntréeToolStripMenuItem.Click += ajouterUneEntréeToolStripMenuItem_Click;
            // 
            // supprimerLentréeToolStripMenuItem
            // 
            supprimerLentréeToolStripMenuItem.Name = "supprimerLentréeToolStripMenuItem";
            supprimerLentréeToolStripMenuItem.Size = new Size(253, 24);
            supprimerLentréeToolStripMenuItem.Text = "Supprimer l'entrée";
            supprimerLentréeToolStripMenuItem.Click += supprimerLentréeToolStripMenuItem_Click;
            // 
            // modifierLentréeToolStripMenuItem
            // 
            modifierLentréeToolStripMenuItem.Name = "modifierLentréeToolStripMenuItem";
            modifierLentréeToolStripMenuItem.Size = new Size(253, 24);
            modifierLentréeToolStripMenuItem.Text = "Modifier l'entrée";
            modifierLentréeToolStripMenuItem.Click += modifierLentréeToolStripMenuItem_Click;
            // 
            // copierLeNomDutilisateurToolStripMenuItem
            // 
            copierLeNomDutilisateurToolStripMenuItem.Name = "copierLeNomDutilisateurToolStripMenuItem";
            copierLeNomDutilisateurToolStripMenuItem.Size = new Size(253, 24);
            copierLeNomDutilisateurToolStripMenuItem.Text = "Copier le nom d'utilisateur";
            copierLeNomDutilisateurToolStripMenuItem.Click += copierLeNomDutilisateurToolStripMenuItem_Click;
            // 
            // copierLeMotDePasseToolStripMenuItem
            // 
            copierLeMotDePasseToolStripMenuItem.Name = "copierLeMotDePasseToolStripMenuItem";
            copierLeMotDePasseToolStripMenuItem.Size = new Size(253, 24);
            copierLeMotDePasseToolStripMenuItem.Text = "Copier le mot de passe";
            copierLeMotDePasseToolStripMenuItem.Click += copierLeMotDePasseToolStripMenuItem_Click;
            // 
            // copierLURLToolStripMenuItem
            // 
            copierLURLToolStripMenuItem.Name = "copierLURLToolStripMenuItem";
            copierLURLToolStripMenuItem.Size = new Size(253, 24);
            copierLURLToolStripMenuItem.Text = "Copier l'URL";
            copierLURLToolStripMenuItem.Click += copierLURLToolStripMenuItem_Click;
            // 
            // CopyTimer
            // 
            CopyTimer.Interval = 1000;
            CopyTimer.Tick += CopyTimer_Tick;
            // 
            // statusStripCopy
            // 
            statusStripCopy.ImageScalingSize = new Size(20, 20);
            statusStripCopy.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCopy, toolStripProgressBarCopy });
            statusStripCopy.Location = new Point(0, 747);
            statusStripCopy.Name = "statusStripCopy";
            statusStripCopy.Size = new Size(1378, 24);
            statusStripCopy.TabIndex = 3;
            statusStripCopy.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCopy
            // 
            toolStripStatusLabelCopy.Name = "toolStripStatusLabelCopy";
            toolStripStatusLabelCopy.Size = new Size(0, 18);
            // 
            // toolStripProgressBarCopy
            // 
            toolStripProgressBarCopy.Name = "toolStripProgressBarCopy";
            toolStripProgressBarCopy.Size = new Size(100, 16);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 771);
            Controls.Add(toolStripUtils);
            Controls.Add(statusStripCopy);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1File);
            MainMenuStrip = menuStrip1File;
            Name = "MainForm";
            Text = "Vaulty";
            menuStrip1File.ResumeLayout(false);
            menuStrip1File.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            contextMenuStripAddDeleteGroup.ResumeLayout(false);
            toolStripUtils.ResumeLayout(false);
            toolStripUtils.PerformLayout();
            contextMenuStripEntries.ResumeLayout(false);
            statusStripCopy.ResumeLayout(false);
            statusStripCopy.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1File;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripMenuItem sauvegarderToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private SplitContainer splitContainer1;
        private TreeView treeViewGroups;
        private ListView listViewEntries;
        private ColumnHeader Titre;
        private ColumnHeader Login;
        private ColumnHeader MotDePasse;
        private ColumnHeader URL;
        private ColumnHeader Notes;
        private ToolStrip toolStripUtils;
        private ToolStripButton buttonAddEntry;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton buttonCopyUsername;
        private ToolStripButton buttonCopyPassword;
        private ToolStripButton buttonCopyURL;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton buttonSearchEntry;
        private ContextMenuStrip contextMenuStripAddDeleteGroup;
        private ToolStripMenuItem ajouterUneCatégorieToolStripMenuItem;
        private ToolStripMenuItem supprimerLaCatégorieToolStripMenuItem;
        private ContextMenuStrip contextMenuStripEntries;
        private ToolStripMenuItem ajouterUneEntréeToolStripMenuItem;
        private ToolStripMenuItem supprimerLentréeToolStripMenuItem;
        private ToolStripMenuItem modifierLentréeToolStripMenuItem;
        private ToolStripMenuItem copierLeNomDutilisateurToolStripMenuItem;
        private ToolStripMenuItem copierLeMotDePasseToolStripMenuItem;
        private ToolStripMenuItem copierLURLToolStripMenuItem;
        private System.Windows.Forms.Timer CopyTimer;
        private StatusStrip statusStripCopy;
        private ToolStripStatusLabel toolStripStatusLabelCopy;
        private ToolStripProgressBar toolStripProgressBarCopy;
        private ToolStripTextBox toolStripTextBoxSearchEntry;
    }
}