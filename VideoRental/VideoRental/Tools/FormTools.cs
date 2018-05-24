using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace VideoRental.Tools
{
    static class FormTools
    {
        public static void InstallHint(this TextBox textBox, string hint)
        {
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.Text = hint;
            textBox.ForeColor = Color.Gray;
        }

        public static void RemoveHint(this TextBox textBox)
        {
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.Text = "";
            textBox.ForeColor = Color.Black;
        }

        public static void InstallHintForPassword(this TextBox textBox, string hint)
        {
            textBox.UseSystemPasswordChar = false;
            textBox.InstallHint(hint);
        }

        public static void RemoveHintForPassword(this TextBox textBox)
        {
            textBox.RemoveHint();
            textBox.UseSystemPasswordChar = true;
        }

        public static bool IsEmpty(this TextBox textBox, string hint)
        {
            if (textBox.IsEmpty() || textBox.Text == hint)
                return true;
            return false;
        }

        public static bool IsEmpty(this TextBox textBox)
        {
            if (textBox.Text == "")
                return true;
            return false;
        }

        public static void InstallComboBoxValues(this ComboBox comboBox, IEnumerable<string> collection)
        {
            comboBox.Items.Clear();
            foreach (string value in collection)
                comboBox.Items.Add(value);
        }

        public static void InstallComboBoxValues(this ComboBox comboBox, IEnumerable<Tuple<int, string>> collection)
        {
            comboBox.Items.Clear();
            foreach (Tuple<int, string> value in collection)
                comboBox.Items.Add(value.Item2);
        }

        public static void ValidateName(this TextBox textBox, KeyPressEventArgs e)
        {
            string text = textBox.Text;
            Regex regex = new Regex("[а-яА-Я]");

            if (text.Length == 0)
                e.KeyChar = Char.ToUpper(e.KeyChar);

            if(((Keys)e.KeyChar == Keys.Space || e.KeyChar == '-') && (text.Length == 0 || text[text.Length - 1] == e.KeyChar))
                e.Handled = true;
            else if(!regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar) || e.KeyChar == '\u0016')
                e.Handled = true;
        }

        public static void ValidateTitle(this TextBox textBox, KeyPressEventArgs e)
        {
            string text = textBox.Text;
            Regex regex = new Regex("[а-яА-Я0-9a-zA-Z]");

            if (text.Length == 0)
                e.KeyChar = Char.ToUpper(e.KeyChar);

            if ((Keys)e.KeyChar == Keys.Space || e.KeyChar == '-' || e.KeyChar == ':' || e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (text.Length == 0 || text[text.Length - 1] == e.KeyChar)
                    e.Handled = true;
            }
            else if (!regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar) || e.KeyChar == '\u0016')
                e.Handled = true;
        }

        public static void ValidateYear(this TextBox textBox, KeyPressEventArgs e)
        {
            string text = textBox.Text;
            Regex regex = new Regex("[0-9]");

            if(textBox.Text.Length > 4 && !Char.IsControl(e.KeyChar) || (e.KeyChar == '0' && text.Length == 0) || (Keys)e.KeyChar == Keys.Space)
                e.Handled = true;
            else if (!regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar) || e.KeyChar == '\u0016')
                e.Handled = true;
        }

        public static void ValidateNumber(this TextBox textBox, KeyPressEventArgs e)
        {
            string text = textBox.Text;
            Regex regexN = new Regex("[0-9]");
            Regex regexC = new Regex("[-.,]");

            if (regexC.IsMatch(e.KeyChar.ToString()) && text.Length != 0 && text[text.Length - 1] == e.KeyChar)
                e.Handled = true;
            else if ((!regexN.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar)) || (Keys)e.KeyChar == Keys.Space || e.KeyChar == '\u0016')
                e.Handled = true;
        }

        public static void ValidatePhone(this TextBox textBox, KeyPressEventArgs e)
        {
            string text = textBox.Text;
            Regex regexN = new Regex("[0-9]");

            if (textBox.Text.Length > 9)
                e.Handled = true;
            else if ((!regexN.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar)) || (Keys)e.KeyChar == Keys.Space || e.KeyChar == '\u0016')
                e.Handled = true;
        }

        public static void ValidatePrice(this TextBox textBox, KeyPressEventArgs e)
        {
            Regex regex = new Regex("[0-9]");

            if (textBox.Text.Length > 6 && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            else if (!regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar) || (Keys)e.KeyChar == Keys.Space || e.KeyChar == '\u0016')
                e.Handled = true;
        }

        public static void ValidatePassport(this TextBox textBox, KeyPressEventArgs e)
        {
            Regex regexN = new Regex("[0-9]");
            Regex regexC = new Regex("[a-zA-Zа-яА-Я]");

            if (textBox.Text.Length < 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);

                if (!regexC.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            else if (textBox.Text.Length >= 8)
                e.Handled = true;
            else if (!regexN.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar) || (Keys)e.KeyChar == Keys.Space || e.KeyChar == '\u0016')
                e.Handled = true;
        }
    }
}
