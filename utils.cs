// Auth: John O'Neal
// Date: 04/03/2024
// Desc: A utility class that contains helper methods for the tax application.

using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TaxApp_v2
{
    public static class Utils
    {
        // Declare current user id variable here so that it can be accessed from any form or user control
        public static int currentUserId { get; set; }


        // Hash the input string using SHA256. This is used to hash the password before storing it in the database
        public static string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return string.Concat(bytes.Select(b => b.ToString("x2")));
            }
        }

        // Show or hide the password in the password textbox
        public static void ShowPassword(TextBox passwordTextBox, CheckBox showPasswordCheckBox)
        {
            passwordTextBox.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }

        // Center a control within its parent control
        public static void CenterControl(Control control)
        {
            control.Location = new Point(
                control.Parent.ClientSize.Width / 2 - control.Size.Width / 2,
                control.Parent.ClientSize.Height / 2 - control.Size.Height / 2);
        }

        // Clear the text of the given TextBoxes and set focus to the first TextBox
        public static void ClearAndFocus(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
            textBoxes[0].Focus();
        }

        // Show an error message of a given title and message
        public static void ShowErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Set the behavior of the Enter key for a TextBox
        public static void SetEnterKeyBehavior(TextBox textBox, KeyEventHandler eventHandler)
        {
            textBox.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    eventHandler(sender, e);
                }
            };
        }
    }
}