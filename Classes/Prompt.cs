using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaulty.Classes
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                Text = caption,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label lblText = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 350, PasswordChar = '*' };
            Button confirmation = new Button() { Text = "OK", Left = 280, Top = 80, Width = 90 };

            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(lblText);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);

            prompt.ShowDialog();

            return inputBox.Text;
        }
    }
}

