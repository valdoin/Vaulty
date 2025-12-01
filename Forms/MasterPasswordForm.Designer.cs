namespace Vaulty.Forms
{
    partial class MasterPasswordForm
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
            labelMasterPassword = new Label();
            textBoxMasterPassword = new TextBox();
            label1 = new Label();
            textBoxConfirmPassword = new TextBox();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // labelMasterPassword
            // 
            labelMasterPassword.AutoSize = true;
            labelMasterPassword.Location = new Point(12, 95);
            labelMasterPassword.Name = "labelMasterPassword";
            labelMasterPassword.Size = new Size(292, 20);
            labelMasterPassword.TabIndex = 0;
            labelMasterPassword.Text = "Veuillez définir votre mot de passe maître :";
            // 
            // textBoxMasterPassword
            // 
            textBoxMasterPassword.Location = new Point(310, 92);
            textBoxMasterPassword.Name = "textBoxMasterPassword";
            textBoxMasterPassword.Size = new Size(246, 27);
            textBoxMasterPassword.TabIndex = 1;
            textBoxMasterPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 137);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 2;
            label1.Text = "Confirmez le mot de passe maître :";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(258, 134);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(248, 27);
            textBoxConfirmPassword.TabIndex = 3;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(258, 206);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(412, 206);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(94, 29);
            buttonConfirm.TabIndex = 5;
            buttonConfirm.Text = "OK";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // MasterPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 306);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(label1);
            Controls.Add(textBoxMasterPassword);
            Controls.Add(labelMasterPassword);
            Name = "MasterPasswordForm";
            Text = "MasterPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMasterPassword;
        private TextBox textBoxMasterPassword;
        private Label label1;
        private TextBox textBoxConfirmPassword;
        private Button buttonCancel;
        private Button buttonConfirm;
    }
}