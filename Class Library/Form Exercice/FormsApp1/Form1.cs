using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLibrary;


namespace FormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            ClassLibrary classLibrary = new ClassLibrary();

            label2.Text = classLibrary.Sum(Convert.ToInt32(numericUpDown1.Value)  ,Convert.ToInt32(numericUpDown2.Value)).ToString();  
        }
    }
}
