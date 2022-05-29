using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fahrenheit_para_celsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_f.Text == "")
            {
                MessageBox.Show("PREENCHER O CAMPO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                //VARS
                decimal fahrenheit = Convert.ToDecimal(txt_f.Text);
                decimal celsius;

                //CONVERSÃO

                celsius = (fahrenheit - 32) * 5 / 9;

                txt_c.Text = celsius.ToString("n1");

            }




        }
    }
}
