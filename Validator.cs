// Auth: Christian B
// Date: 4/9/24
// Desc: Validator Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxApp_v2
{
    internal class Validator
    {
        //A private static field to hold the title for error messages, initialized with "Entry Error"
        private static string title = "Entry Error";

        public static string Title
        {
            get => title; 
            set => title = value;
        }

        //Checks if the textbox has any text and displays an error message if not
        public static bool IsPresent(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        //Validates that the text in the TextBox can be converted to a decimal
        public static bool IsDecimal(TextBox textBox) 
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;

            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value", Title);
                textBox.Focus();
                return false;
            }
        }

        // Validates that the text in the TextBox can be converted to an integer
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            { 
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }
    }
}
