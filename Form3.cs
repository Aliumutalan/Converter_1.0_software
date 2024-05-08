using Aspose.Words.Saving;
using Aspose.Words;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string direct()
        {
            OpenFileDialog pngd = new OpenFileDialog();
            pngd.ShowDialog();
            return pngd.FileName;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = direct();
        }
        public string directf()
        {
            FolderBrowserDialog pngf = new FolderBrowserDialog();
            pngf.ShowDialog();
            return pngf.SelectedPath;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = directf();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var doc = new Document();
                var builder = new DocumentBuilder(doc);

                builder.InsertImage(textBox1.Text);

                doc.Save(textBox2.Text + "\\" + textBox3.Text + ".pdf");
                label2.Text = "File Converted";
            }
            catch
            {
                label2.Left = 40;
                label2.Text = "you have to enter image file path";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
