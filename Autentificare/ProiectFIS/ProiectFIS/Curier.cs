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
    public partial class Curier : Form
    {
        public Curier()
        {
            InitializeComponent();
        }

        private int contor = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Introduceti date valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto exitLabel;
            }

            string[] utilizatori = File.ReadAllLines("curier.txt");
            foreach (var line in utilizatori)
            {
                string[] inregistrare = line.Split(',');
                if ((textBox1.Text).Equals(inregistrare[0]))
                {
                    if ((textBox2.Text.Trim()).Equals(inregistrare[1].Trim()))
                    {
                        this.Hide();
                        Form f = new Pornire(); //se va lega forma pentru completare formular pentru clienti
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Parola incorecta!");
                    }
                    contor = 1;
                }
            }

            if (contor == 0)
                MessageBox.Show("Nu exista cont inregistrat cu acest user si parola", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            exitLabel:;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Pornire(); //in caz ca s-a ales optiunea gresita
            f.ShowDialog();
        }
    }
}
