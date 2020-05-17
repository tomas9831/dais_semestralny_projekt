using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dais.Database;


namespace forms
{
    public partial class addUser : Form
    {
        private int idoddielu;
        private string praceschopnost;
        private bool check = false;
        public addUser()
        {
            InitializeComponent();
            generL.Text = generate();
            initCb();
            
        }

        private void okB_Click(object sender, EventArgs e)
        {
            string text;
            string pid = generL.Text ;
            string meno = menotextBox.Text;
            string priezvisko = priezviskotextBox.Text;
            if (meno.Length > 30)
            {
                text = "Meno zamestnanca príliš dlhé";
                MessageBox.Show(text);
            }
            else if (priezvisko.Length > 30)
            {
                text = "Priezvisko zamestnanca príliš dlhé";
                MessageBox.Show(text);
            }
            else if (meno.Length == 0)
            {
                text = "Meno zamestnanca nevyplnené";
                MessageBox.Show(text);
            }
            else if (priezvisko.Length == 0)
            {
                text = "Priezvisko zamestnanca nevyplnené";
                MessageBox.Show(text);
            }
            else
            {
                check = true;
            }

            if (check == true)
            {
                int result = dbProcessorr.CreateZamestnanec(pid, meno, priezvisko, idoddielu, praceschopnost);
                text = "Nový zamestnanec pridaný";
                MessageBox.Show(text);
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tmp = comboBox1.Text;
            string[] words = tmp.Split(',');
            idoddielu = int.Parse(words[0]);
        }


        private void initCb()
        {
            Collection<Pracovny_oddiel> p = dbProcessorr.GetAllOddieli();
            foreach (Pracovny_oddiel o in p)
            {
                comboBox1.Items.Add(o.id_oddielu + "," + o.nazov_oddielu);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            praceschopnost = comboBox2.Text;
        }

        private void generB_Click(object sender, EventArgs e)
        {
            generL.Text = generate();
        }

        public String generate()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

        private void generL_Click(object sender, EventArgs e)
        {

        }

        private void menotextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
