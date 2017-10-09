using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Calculator
{
    public partial class Form_Calc : Form
    {

        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int left;
            public int right;
            public int top;
            public int bottom;
        }

        public Form_Calc()
        {
            InitializeComponent();
        }

        [DllImport("DwmApi.dll", PreserveSig = false)]
        public static extern bool DwmIsCompositionEnabled();

        [DllImport("DwmApi.dll", PreserveSig = false)]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarinset);

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.C))
            {
                Clipboard.SetText(lbl2.Text);
                return true;
            }
            else if (keyData == (Keys.Control | Keys.V))
            {
                try
                {
                    Evaluate(Clipboard.GetText());
                }
                catch
                {
                    return true;
                }

                lbl2.Text = Clipboard.GetText();
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && Controls["btn_" + e.KeyChar].Enabled)
                btn_num_Click(Controls["btn_" + e.KeyChar], e);
            else
                switch (e.KeyChar)
                {
                    case '+': if (btn_plus.Enabled) btn_Operators(btn_plus, e); break;
                    case '-': if (btn_minus.Enabled) btn_Operators(btn_minus, e); break;
                    case '*': if (btn_multiply.Enabled) btn_Operators(btn_multiply, e); break;
                    case '/': if (btn_devide.Enabled) btn_Operators(btn_devide, e); break;
                    case ',':
                    case '.': if (btn_point.Enabled) btn_num_Click(btn_point, e); break;
                    case '(': if (btn_brckt_open.Enabled) btn_Brckts(btn_brckt_open, e); break;
                    case ')': if (btn_brckt_close.Enabled) btn_Brckts(btn_brckt_close, e); break;
                    case '%': if (btn_perc.Enabled) btn_other_Click(btn_perc, e); break;
                    case (char)13: btn_Result(sender, e); break;
                    case (char)8: if (btn_del.Enabled) btn_clear_Click(btn_del, e); break;
                }
        }

        char lstBtnOprtr = ' ';

        private void btn_num_Click(object sender, EventArgs e)
        {
            if (lstBtnOprtr != ')')
            {
                if (lbl2.Text == "0" || lstBtnOprtr != ' ')
                {
                    if ((sender as Button) == btn_point)
                        lbl2.Text = "0";
                    else
                        lbl2.Text = "";
                }

                if (lbl2.Text.Length < 15)
                {
                    switch ((sender as Button).Name)
                    {
                        case "btn_0": lbl2.Text += '0'; break;
                        case "btn_1": lbl2.Text += '1'; break;
                        case "btn_2": lbl2.Text += '2'; break;
                        case "btn_3": lbl2.Text += '3'; break;
                        case "btn_4": lbl2.Text += '4'; break;
                        case "btn_5": lbl2.Text += '5'; break;
                        case "btn_6": lbl2.Text += '6'; break;
                        case "btn_7": lbl2.Text += '7'; break;
                        case "btn_8": lbl2.Text += '8'; break;
                        case "btn_9": lbl2.Text += '9'; break;
                        case "btn_point":
                            if (!lbl2.Text.Contains(",") && !lbl2.Text.Contains("."))
                                lbl2.Text += ','; break;
                        default: break;
                    }
                }

                lstBtnOprtr = ' '; result = " ";
                lbl2.Focus();
            }
        }
    

        private void btn_clear_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "btn_del":
                   if (lstBtnOprtr == ' ')
                    {
                        if (lbl2.Text.Length > 1)
                            lbl2.Text = lbl2.Text.Remove(lbl2.Text.Length - 1, 1);
                        else
                            lbl2.Text = "0";

                        if (lbl2.Text == "-0" || lbl2.Text == "-")
                            lbl2.Text = "0";
                    }
                    break;
                case "btn_CE":
                    lbl2.Text = "0" ;
                    lstBtnOprtr = ' '; result = " ";
                    break;
                case "btn_C":
                    lbl1.Text = "";
                    lbl2.Text = "0";
                    lstBtnOprtr = ' '; result = " ";
                    break;
                default: break;
            }

            lbl2.Focus();
        }

        private void btn_negative(object sender, EventArgs e)
        {
            if (Evaluate(lbl2.Text) != 0)
            {
                if (lbl2.Text.IndexOf('-') == -1)
                    lbl2.Text = '-' + lbl2.Text;
                else
                    lbl2.Text = lbl2.Text.Remove(0, 1);
                lstBtnOprtr = ' ';
                result = " ";
            }

            lbl2.Focus();
        }

        int brckts = 0;
        private void btn_Operators(object sender, EventArgs e)
        {
            if (Evaluate(lbl2.Text) == 0)
                lbl2.Text = "0";

            if (lstBtnOprtr != ' ' && lstBtnOprtr != '(' && lstBtnOprtr != ')' && lbl1.Text != "" && lstBtnOprtr != '%')
                lbl1.Text = lbl1.Text.Remove(lbl1.Text.Length - 2, 2);

            else if (lstBtnOprtr != ')')
            {
                if (lbl1.Text.Length > 0 && lbl1.Text[lbl1.Text.Length - 1] != '(')
                    lbl1.Text += " ";
                lbl1.Text += lbl2.Text;
            }

            switch ((sender as Button).Name)
            {
                case "btn_devide": lbl1.Text += " /"; lstBtnOprtr = '/'; break;
                case "btn_multiply": lbl1.Text += " *"; lstBtnOprtr = '*'; break;
                case "btn_minus": lbl1.Text += " -"; lstBtnOprtr = '-'; lbl2.Text = Convert.ToString(Evaluate(Last_Expr(lbl1.Text))); break;
                case "btn_plus": lbl1.Text += " +"; lstBtnOprtr = '+'; lbl2.Text = Convert.ToString(Evaluate(Last_Expr(lbl1.Text))); break;
            }
            
            
            result = " ";
            lbl2.Focus();
        }
        private void btn_Brckts(object sender, EventArgs e)
        {
            if ((sender as Button) == btn_brckt_open &&
                (lbl1.Text == "" ||
                lbl1.Text[lbl1.Text.Length - 1] == '+' ||
                lbl1.Text[lbl1.Text.Length - 1] == '-' ||
                lbl1.Text[lbl1.Text.Length - 1] == '*' ||
                lbl1.Text[lbl1.Text.Length - 1] == '/' ||
                lbl1.Text[lbl1.Text.Length - 1] == '('))
            {
                if (lbl1.Text.Length > 0 && lbl1.Text[lbl1.Text.Length - 1] != '(')
                    lbl1.Text += " ";
                lbl1.Text += '(';

                brckts++; result = " ";
                lstBtnOprtr = '(';
            }
            if ((sender as Button) == btn_brckt_close && brckts > 0)
            {
                if ((lbl1.Text == "" ||
                    lbl1.Text[lbl1.Text.Length - 1] == '+' ||
                    lbl1.Text[lbl1.Text.Length - 1] == '-' ||
                    lbl1.Text[lbl1.Text.Length - 1] == '*' ||
                    lbl1.Text[lbl1.Text.Length - 1] == '/' ||
                    lbl1.Text[lbl1.Text.Length - 1] == '('))
                {
                    if (lbl1.Text.Length > 0 && lbl1.Text[lbl1.Text.Length - 1] != '(')
                        lbl1.Text += " ";
                    lbl1.Text += lbl2.Text;
                }
                lbl1.Text += ')';
                brckts--;
                lstBtnOprtr = ')';
                result = " ";
            }

            lbl2.Focus();
        }

        string lbl_2 = "0";
        string result = " ";

        private void btn_Result(object sender, EventArgs e)
        {
            if (result != " ")
            {
                lbl2.Text = Convert.ToString(Evaluate(lbl2.Text + result));
            }
            else
            {
                if (lbl1.Text != "")
                {
                    if (lstBtnOprtr == '+' ||
                        lstBtnOprtr == '-' ||
                        lstBtnOprtr == '*' ||
                        lstBtnOprtr == '/'
                        )
                        lbl1.Text = lbl1.Text.Remove(lbl1.Text.Length - 2, 2);
                    else if (lbl1.Text[lbl1.Text.Length - 1] != ')')
                    {
                        result = lbl1.Text.Substring(lbl1.Text.Length - 2) + lbl2.Text;
                        lbl1.Text += " " + lbl2.Text;
                    }
                    while (brckts > 0)
                        btn_Brckts(btn_brckt_close, e);
                    lbl_2 = lbl2.Text;

                    lbl2.Text = Convert.ToString(Evaluate(lbl1.Text));
                }

                lbl1.Text = "";
                lstBtnOprtr = '=';
                lbl2.Focus();
            }
        }
        public static double Evaluate(string expression)
        {
            if (expression != "" && expression !="-")
            {
                expression = expression.Replace(',', '.');
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), expression);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                return double.Parse((string)row["expression"]);
            }
            else return 0;
        }

        string mem = "0";
        private void btn_other_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "btn_MS": textBox1.Text = mem = lbl2.Text; break;
                case "btn_MR": lbl2.Text = mem; break;
                case "btn_sqrt":
                    lbl2.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(lbl2.Text))); break;
                case "btn_1_x":
                    lbl2.Text = Convert.ToString(1.0 / Convert.ToDouble(lbl2.Text)); break;
                case "btn_perc":
                    if (lbl1.Text !="" && 
                        (lbl1.Text[lbl1.Text.Length - 1] == '+' ||
                        lbl1.Text[lbl1.Text.Length - 1] == '-' ||
                        lbl1.Text[lbl1.Text.Length - 1] == '*' ||
                        lbl1.Text[lbl1.Text.Length - 1] == '/')
                        )
                        lbl2.Text = Convert.ToString( Evaluate(Last_Expr(lbl1.Text)) * Convert.ToDouble(lbl2.Text)/100 );
                    break;
            }
            lbl2.Focus();
        }

        string Last_Expr(string str)
        {
            str = str.Remove(lbl1.Text.Length - 2, 2);

            if (str.IndexOf('(') == -1)
                return str;
            else if (str.Substring(str.LastIndexOf('(')).IndexOf(')') == -1)
                return str.Substring(str.LastIndexOf('(')) + ')';
            else
            {
                int b = str.Substring(str.LastIndexOf('(')).Split(')').Length - 1;
                int i = str.Split('(').Length - 1  - b;
                for (; i>=0; i--)
                {
                    str = str.Substring(str.IndexOf('('));
                    str = str.Remove(0, 1);
                }
                str = '(' + str;
                return str;
            }
        }
    }
}
