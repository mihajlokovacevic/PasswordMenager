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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string text = File.ReadAllText("Stranica.txt");
            string text1 = File.ReadAllText("user.txt");
            string text2 = File.ReadAllText("pass.txt");


            StreamWriter dat = new StreamWriter("Stranica.txt");
            dat.WriteLine(text + textBox1.Text);

            StreamWriter dat1 = new StreamWriter("user.txt");
            dat1.WriteLine(text1 + textBox2.Text);
            
            StreamWriter dat2 = new StreamWriter("pass.txt");
            dat2.WriteLine(text2 + textBox3.Text);
            dat.Close();
            dat1.Close();
            dat2.Close();
            this.Close();

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
