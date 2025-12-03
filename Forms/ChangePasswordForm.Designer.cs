namespace Vaulty.Forms
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            labelCurrentPassword = new Label();
            labelNewPassword = new Label();
            labelNewPasswordConfirm = new Label();
            textBoxCurrentPassword = new TextBox();
            textBoxNewPassword = new TextBox();
            textBoxNewPasswordConfirm = new TextBox();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // labelCurrentPassword
            // 
            labelCurrentPassword.AutoSize = true;
            labelCurrentPassword.Location = new Point(12, 65);
            labelCurrentPassword.Name = "labelCurrentPassword";
            labelCurrentPassword.Size = new Size(149, 20);
            labelCurrentPassword.TabIndex = 0;
            labelCurrentPassword.Text = "Mot de passe actuel :";
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Location = new Point(12, 107);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(168, 20);
            labelNewPassword.TabIndex = 1;
            labelNewPassword.Text = "Nouveau mot de passe :";
            // 
            // labelNewPasswordConfirm
            // 
            labelNewPasswordConfirm.AutoSize = true;
            labelNewPasswordConfirm.Location = new Point(12, 147);
            labelNewPasswordConfirm.Name = "labelNewPasswordConfirm";
            labelNewPasswordConfirm.Size = new Size(247, 20);
            labelNewPasswordConfirm.TabIndex = 2;
            labelNewPasswordConfirm.Text = "Confirmer le nouveau mot de passe:";
            // 
            // textBoxCurrentPassword
            // 
            textBoxCurrentPassword.Location = new Point(167, 62);
            textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            textBoxCurrentPassword.Size = new Size(228, 27);
            textBoxCurrentPassword.TabIndex = 3;
            textBoxCurrentPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(186, 107);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(228, 27);
            textBoxNewPassword.TabIndex = 4;
            textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewPasswordConfirm
            // 
            textBoxNewPasswordConfirm.Location = new Point(265, 147);
            textBoxNewPasswordConfirm.Name = "textBoxNewPasswordConfirm";
            textBoxNewPasswordConfirm.Size = new Size(228, 27);
            textBoxNewPasswordConfirm.TabIndex = 5;
            textBoxNewPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(186, 232);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(320, 232);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(94, 29);
            buttonConfirm.TabIndex = 7;
            buttonConfirm.Text = "OK";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // ChangePasswordForm
            // 
            AcceptButton = buttonConfirm;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(593, 300);
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxNewPasswordConfirm);
            Controls.Add(textBoxNewPassword);
            Controls.Add(textBoxCurrentPassword);
            Controls.Add(labelNewPasswordConfirm);
            Controls.Add(labelNewPassword);
            Controls.Add(labelCurrentPassword);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ChangePasswordForm";
            Text = "Changer le mot de passe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCurrentPassword;
        private Label labelNewPassword;
        private Label labelNewPasswordConfirm;
        private TextBox textBoxCurrentPassword;
        private TextBox textBoxNewPassword;
        private TextBox textBoxNewPasswordConfirm;
        private Button buttonCancel;
        private Button buttonConfirm;
    }
}