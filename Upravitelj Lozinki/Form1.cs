using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upravitelj_Lozinki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmail.Text == "user")
                {
                if (txtpass.Text == "1234")
                    {
                    new Form2().Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Neuspjela prijava");
                }

            }
        }
    }
}
