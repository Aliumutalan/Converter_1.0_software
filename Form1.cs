using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 png = new Form2();
            this.Hide();
            png.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 pdf = new Form3();
            this.Hide();
            pdf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 jpg = new Form4();
            this.Hide(); 
            jpg.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 html = new Form5();
            this.Hide();
            html.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 doc = new Form6();
            this.Hide();
            doc.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
