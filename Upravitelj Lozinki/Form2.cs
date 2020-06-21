using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upravitelj_Lozinki
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucitaj() 
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();


            string line;
            string line2;
            string line3;
            var file = new System.IO.StreamReader("Stranica.txt");
            while ((line = file.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }

            var file1 = new System.IO.StreamReader("user.txt");
            while ((line2 = file1.ReadLine()) != null)
            {
                listBox2.Items.Add(line2);
            }

            var file2 = new System.IO.StreamReader("pass.txt");
            while ((line3 = file2.ReadLine()) != null)
            {
                listBox3.Items.Add(line3);
            }

            file.Close();
            file1.Close();
            file2.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ucitaj();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            StreamWriter dat = new StreamWriter("Stranica.txt");
            dat.WriteLine("");

            StreamWriter dat1 = new StreamWriter("user.txt");
            dat1.WriteLine("");

            StreamWriter dat2 = new StreamWriter("pass.txt");
            dat2.WriteLine("");
            dat.Close();
            dat1.Close();
            dat2.Close();
        }
    }
}
