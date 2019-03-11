using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            button1.Width = 250;
            button1.Text = "دکمه را فشار دهید";
            button1.Click += new EventHandler(button1_clk);

        }

        public void button1_clk(object sender, EventArgs args)
        {
            MessageBox.Show("سلام");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dblclk_handler(object sender, EventArgs e)
        {

        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
