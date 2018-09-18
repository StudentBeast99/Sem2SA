using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace _3._1
{
    public partial class ReversePolishForm : Form
    {
        public ReversePolishForm()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Input.Text))
                Output.Text = "";
            else
            {
                try
                {
                    ReversePolish polish = new ReversePolish(Input.Text);
                    Output.Text = polish.GetValue().ToString();
                }
                catch (Exception)
                {
                    Output.Text = "";
                }
            }
        }
    }
}
