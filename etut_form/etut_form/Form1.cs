using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etut_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen geçerli bir seçim yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox1.SelectedItem.ToString()=="Banka 1")
            {
                Banka b1 = new Banka1();
                b1.para = 575;
                b1.ode();

            }
            else if(comboBox1.SelectedItem.ToString()=="Banka 2")
            {
                Banka b2 = new Banka2();
                b2.para = 689; 
                b2.ode();
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
