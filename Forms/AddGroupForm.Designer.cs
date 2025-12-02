namespace Vaulty.Forms
{
    partial class AddGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroupForm));
            labelGroupName = new Label();
            textBoxGroupName = new TextBox();
            buttonCancel = new Button();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // labelGroupName
            // 
            labelGroupName.AutoSize = true;
            labelGroupName.Location = new Point(12, 79);
            labelGroupName.Name = "labelGroupName";
            labelGroupName.Size = new Size(153, 20);
            labelGroupName.TabIndex = 0;
            labelGroupName.Text = "Nom de la catégorie :";
            // 
            // textBoxGroupName
            // 
            textBoxGroupName.Location = new Point(171, 76);
            textBoxGroupName.Name = "textBoxGroupName";
            textBoxGroupName.Size = new Size(329, 27);
            textBoxGroupName.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(171, 156);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(283, 156);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // AddGroupForm
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(528, 211);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxGroupName);
            Controls.Add(labelGroupName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddGroupForm";
            Text = "Nouvelle catégorie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGroupName;
        private TextBox textBoxGroupName;
        private Button buttonCancel;
        private Button buttonOK;
    }
}