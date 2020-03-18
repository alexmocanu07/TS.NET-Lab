using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
namespace Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            equalButton.Focus();
            this.KeyPreview = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Form1_KeyPress);
            
        }

       private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.Focused)
            {
                equalButton.Focus();
                
            }
            addInput(clickedButton.Text[0]);
        }

        private void addInput(char input)
        {
            String operations = "+-*/";
            if (Char.IsDigit(input))
            {
                if(displayLabel.Text == "0") displayLabel.Text = "";
                if (displayLabel.Text.Length > 1 && displayLabel.Text[displayLabel.Text.Length - 1] == '0' && operations.Contains(displayLabel.Text[displayLabel.Text.Length - 2]))
                {
                    String aux = displayLabel.Text.Substring(0, displayLabel.Text.Length - 1);
                    displayLabel.Text = aux;
                }

            }

            if (checkInput(displayLabel.Text, input)) displayLabel.Text += input;
        }
        private Boolean checkInput(String currentText, char input)
        {
            String operations = "+-*/";
            if (input == '.')
            {
                if (operations.Contains(currentText[currentText.Length - 1])) return false;
                String[] separators = { "+", "-", "*", @"/" };
                String[] parts = currentText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                String currentString = parts[parts.Length - 1];
                if (currentString.Contains('.')) return false;
                return true;
            }
            
            if (operations.Contains(input) && operations.Contains(currentText[currentText.Length - 1])) return false;

            Regex regex = new Regex(@"[\-]?\d+(\.\d+)?[\+\-\*\/]?");
            String newText = currentText + input;
            if (regex.IsMatch(newText)) return true;
            return false;
        }

        private void clear()
        {
            displayLabel.Text = displayLabel.Text.Substring(0, displayLabel.Text.Length - 1);
            if (displayLabel.Text == "") displayLabel.Text = "0";
        }


        private void Compute(object sender, EventArgs e)
        {
            char[] chars = { '.', '+', '-', '*', '/' };
            displayLabel.Text = displayLabel.Text.TrimEnd(chars);
            DataTable dt = new DataTable();
            var v = dt.Compute(displayLabel.Text, "");
            char[] charsToTrim = { '0', '.' };
            displayLabel.Text = v.ToString().Replace(',', '.').TrimEnd(charsToTrim);
            if (displayLabel.Text == "") displayLabel.Text = "0";
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                if (displayLabel.Text == "0") displayLabel.Text = "";
                displayLabel.Text += e.KeyChar;
            }
            else switch(e.KeyChar){
                    case '-': addInput('-'); break;
                    case '+': addInput('+'); break;
                    case '*': addInput('*'); break;
                    case '/': addInput('/'); break;
                    case '.': addInput('.'); break;
                    case '=': Compute(sender, (EventArgs)e); break;
                    case (char)Keys.Back: this.clear(); break;
                }
                
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void clearEverythingButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
        }
    }
}
