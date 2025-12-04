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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditEntryForm));
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
            labelPasswordComplexity = new Label();
            numericLength = new NumericUpDown();
            longueur_label = new Label();
            checkUpper = new CheckBox();
            checkLower = new CheckBox();
            checkDigits = new CheckBox();
            checkSymbols = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericLength).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(10, 59);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(37, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Titre :";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(10, 87);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(105, 15);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Nom d'utilisateur :";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(10, 115);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(83, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Mot de passe :";
            // 
            // labelURL
            // 
            labelURL.AutoSize = true;
            labelURL.Location = new Point(14, 221);
            labelURL.Name = "labelURL";
            labelURL.Size = new Size(34, 15);
            labelURL.TabIndex = 3;
            labelURL.Text = "URL :";
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(14, 252);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(44, 15);
            labelNotes.TabIndex = 4;
            labelNotes.Text = "Notes :";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(56, 57);
            textBoxTitle.Margin = new Padding(3, 2, 3, 2);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(168, 23);
            textBoxTitle.TabIndex = 5;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(130, 85);
            textBoxUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(153, 23);
            textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(115, 112);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(178, 23);
            textBoxPassword.TabIndex = 7;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(56, 219);
            textBoxURL.Margin = new Padding(3, 2, 3, 2);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(172, 23);
            textBoxURL.TabIndex = 8;
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(67, 250);
            textBoxNotes.Margin = new Padding(3, 2, 3, 2);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(161, 23);
            textBoxNotes.TabIndex = 9;
            // 
            // buttonGeneratePassword
            // 
            buttonGeneratePassword.Location = new Point(298, 112);
            buttonGeneratePassword.Margin = new Padding(3, 2, 3, 2);
            buttonGeneratePassword.Name = "buttonGeneratePassword";
            buttonGeneratePassword.Size = new Size(82, 22);
            buttonGeneratePassword.TabIndex = 10;
            buttonGeneratePassword.Text = "Génerer";
            buttonGeneratePassword.UseVisualStyleBackColor = true;
            buttonGeneratePassword.Click += buttonGeneratePassword_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(385, 115);
            checkBoxShowPassword.Margin = new Padding(3, 2, 3, 2);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(68, 19);
            checkBoxShowPassword.TabIndex = 11;
            checkBoxShowPassword.Text = "Afficher";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.Click += checkBoxShowPassword_CheckedChanged;
            // 
            // progressBarPassword
            // 
            progressBarPassword.Location = new Point(115, 138);
            progressBarPassword.Margin = new Padding(3, 2, 3, 2);
            progressBarPassword.Name = "progressBarPassword";
            progressBarPassword.Size = new Size(178, 22);
            progressBarPassword.TabIndex = 12;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(200, 283);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(82, 22);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(287, 283);
            buttonOK.Margin = new Padding(3, 2, 3, 2);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(82, 22);
            buttonOK.TabIndex = 14;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Location = new Point(10, 29);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(64, 15);
            labelGroup.TabIndex = 15;
            labelGroup.Text = "Catégorie :";
            // 
            // comboBoxGroup
            // 
            comboBoxGroup.FormattingEnabled = true;
            comboBoxGroup.Location = new Point(73, 27);
            comboBoxGroup.Margin = new Padding(3, 2, 3, 2);
            comboBoxGroup.Name = "comboBoxGroup";
            comboBoxGroup.Size = new Size(133, 23);
            comboBoxGroup.TabIndex = 16;
            // 
            // labelPasswordComplexity
            // 
            labelPasswordComplexity.AutoSize = true;
            labelPasswordComplexity.Location = new Point(10, 138);
            labelPasswordComplexity.Name = "labelPasswordComplexity";
            labelPasswordComplexity.Size = new Size(73, 15);
            labelPasswordComplexity.TabIndex = 17;
            labelPasswordComplexity.Text = "Complexité :";
            // 
            // numericLength
            // 
            numericLength.Location = new Point(115, 191);
            numericLength.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            numericLength.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            numericLength.Name = "numericLength";
            numericLength.Size = new Size(120, 23);
            numericLength.TabIndex = 18;
            numericLength.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // longueur_label
            // 
            longueur_label.AutoSize = true;
            longueur_label.Location = new Point(10, 193);
            longueur_label.Name = "longueur_label";
            longueur_label.Size = new Size(64, 15);
            longueur_label.TabIndex = 19;
            longueur_label.Text = "Longueur :";
            // 
            // checkUpper
            // 
            checkUpper.AutoSize = true;
            checkUpper.Checked = true;
            checkUpper.CheckState = CheckState.Checked;
            checkUpper.Location = new Point(20, 165);
            checkUpper.Name = "checkUpper";
            checkUpper.Size = new Size(116, 19);
            checkUpper.TabIndex = 20;
            checkUpper.Text = "Majuscules (A-Z)";
            checkUpper.UseVisualStyleBackColor = true;
            // 
            // checkLower
            // 
            checkLower.AutoSize = true;
            checkLower.Checked = true;
            checkLower.CheckState = CheckState.Checked;
            checkLower.Location = new Point(142, 166);
            checkLower.Name = "checkLower";
            checkLower.Size = new Size(113, 19);
            checkLower.TabIndex = 21;
            checkLower.Text = "Minuscules (a-z)";
            checkLower.UseVisualStyleBackColor = true;
            // 
            // checkDigits
            // 
            checkDigits.AutoSize = true;
            checkDigits.Checked = true;
            checkDigits.CheckState = CheckState.Checked;
            checkDigits.Location = new Point(267, 165);
            checkDigits.Name = "checkDigits";
            checkDigits.Size = new Size(95, 19);
            checkDigits.TabIndex = 22;
            checkDigits.Text = "Chiffres (0-9)";
            checkDigits.UseVisualStyleBackColor = true;
            // 
            // checkSymbols
            // 
            checkSymbols.AutoSize = true;
            checkSymbols.Checked = true;
            checkSymbols.CheckState = CheckState.Checked;
            checkSymbols.Location = new Point(371, 165);
            checkSymbols.Name = "checkSymbols";
            checkSymbols.Size = new Size(77, 19);
            checkSymbols.TabIndex = 23;
            checkSymbols.Text = "Symboles";
            checkSymbols.UseVisualStyleBackColor = true;
            // 
            // AddEditEntryForm
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(522, 367);
            Controls.Add(checkSymbols);
            Controls.Add(checkDigits);
            Controls.Add(checkLower);
            Controls.Add(checkUpper);
            Controls.Add(longueur_label);
            Controls.Add(numericLength);
            Controls.Add(labelPasswordComplexity);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AddEditEntryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ajouter une entrée";
            ((System.ComponentModel.ISupportInitialize)numericLength).EndInit();
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
        private Label labelPasswordComplexity;
        private NumericUpDown numericLength;
        private Label longueur_label;
        private CheckBox checkUpper;
        private CheckBox checkLower;
        private CheckBox checkDigits;
        private CheckBox checkSymbols;
    }
}