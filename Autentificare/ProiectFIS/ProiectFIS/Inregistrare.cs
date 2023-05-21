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

namespace ProiectFIS
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == ""|| textBox3.Text == ""|| textBox4.Text == "")
            {
                MessageBox.Show("Introduceti date valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (StreamWriter fout = File.AppendText("utilizatori.txt"))
            {
                if ((textBox3.Text).Equals(textBox4.Text))
                {
                    fout.WriteLine(textBox1.Text.Trim() + "," + textBox3.Text.Trim());
                    MessageBox.Show("Creare cont reusita!");
                    this.Hide();
                    Form f = new Client();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Parola nu corespunde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fout.Close();
            }
           
        }
    }
}
