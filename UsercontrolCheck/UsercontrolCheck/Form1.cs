using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsercontrolCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userControl11.Selectedvalue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userControl11.SlectedText);
        }
    }
}
