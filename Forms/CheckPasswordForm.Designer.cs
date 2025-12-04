namespace Vaulty.Forms
{
    partial class CheckPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckPasswordForm));
            label1 = new Label();
            textBoxCheckPassword = new TextBox();
            buttonCancel = new Button();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(317, 20);
            label1.TabIndex = 0;
            label1.Text = "Veuillez confirmer votre mot de passe maître : ";
            // 
            // textBoxCheckPassword
            // 
            textBoxCheckPassword.Location = new Point(335, 94);
            textBoxCheckPassword.Name = "textBoxCheckPassword";
            textBoxCheckPassword.Size = new Size(229, 27);
            textBoxCheckPassword.TabIndex = 1;
            textBoxCheckPassword.UseSystemPasswordChar = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(199, 163);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(335, 163);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // CheckPasswordForm
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(686, 247);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxCheckPassword);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CheckPasswordForm";
            Text = "CheckPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCheckPassword;
        private Button buttonCancel;
        private Button buttonOK;
    }
}