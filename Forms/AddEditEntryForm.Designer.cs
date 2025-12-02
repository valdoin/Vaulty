namespace Vaulty.Forms
{
    partial class AddEditEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            labelURL = new Label();
            labelNotes = new Label();
            textBoxTitle = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxURL = new TextBox();
            textBoxNotes = new TextBox();
            buttonGeneratePassword = new Button();
            checkBoxShowPassword = new CheckBox();
            progressBarPassword = new ProgressBar();
            buttonCancel = new Button();
            buttonOK = new Button();
            labelGroup = new Label();
            comboBoxGroup = new ComboBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 79);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(46, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Titre :";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(12, 116);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(130, 20);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Nom d'utilisateur :";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(12, 153);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(105, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Mot de passe :";
            // 
            // labelURL
            // 
            labelURL.AutoSize = true;
            labelURL.Location = new Point(16, 235);
            labelURL.Name = "labelURL";
            labelURL.Size = new Size(42, 20);
            labelURL.TabIndex = 3;
            labelURL.Text = "URL :";
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(16, 276);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(55, 20);
            labelNotes.TabIndex = 4;
            labelNotes.Text = "Notes :";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(64, 76);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(192, 27);
            textBoxTitle.TabIndex = 5;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(148, 113);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(174, 27);
            textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(131, 150);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(203, 27);
            textBoxPassword.TabIndex = 7;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(64, 232);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(196, 27);
            textBoxURL.TabIndex = 8;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(77, 273);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(183, 27);
            textBoxNotes.TabIndex = 9;
            // 
            // buttonGeneratePassword
            // 
            buttonGeneratePassword.Location = new Point(340, 149);
            buttonGeneratePassword.Name = "buttonGeneratePassword";
            buttonGeneratePassword.Size = new Size(94, 29);
            buttonGeneratePassword.TabIndex = 10;
            buttonGeneratePassword.Text = "Génerer";
            buttonGeneratePassword.UseVisualStyleBackColor = true;
            buttonGeneratePassword.Click += buttonGeneratePassword_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(440, 153);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(83, 24);
            checkBoxShowPassword.TabIndex = 11;
            checkBoxShowPassword.Text = "Afficher";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.Click += checkBoxShowPassword_CheckedChanged;
            // 
            // progressBarPassword
            // 
            progressBarPassword.Location = new Point(131, 184);
            progressBarPassword.Name = "progressBarPassword";
            progressBarPassword.Size = new Size(203, 29);
            progressBarPassword.TabIndex = 12;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(228, 342);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(328, 342);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 14;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(12, 39);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(81, 20);
            labelGroup.TabIndex = 15;
            labelGroup.Text = "Catégorie :";
            // 
            // comboBoxGroup
            // 
            comboBoxGroup.FormattingEnabled = true;
            comboBoxGroup.Location = new Point(83, 36);
            comboBoxGroup.Name = "comboBoxGroup";
            comboBoxGroup.Size = new Size(151, 28);
            comboBoxGroup.TabIndex = 16;
            // 
            // AddEditEntryForm
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(596, 413);
            Controls.Add(comboBoxGroup);
            Controls.Add(labelGroup);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            Controls.Add(progressBarPassword);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(buttonGeneratePassword);
            Controls.Add(textBoxNotes);
            Controls.Add(textBoxURL);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxTitle);
            Controls.Add(labelNotes);
            Controls.Add(labelURL);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddEditEntryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajouter une entrée";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelURL;
        private Label labelNotes;
        private TextBox textBoxTitle;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxURL;
        private TextBox textBoxNotes;
        private Button buttonGeneratePassword;
        private CheckBox checkBoxShowPassword;
        private ProgressBar progressBarPassword;
        private Button buttonCancel;
        private Button buttonOK;
        private Label labelGroup;
        private ComboBox comboBoxGroup;
    }
}