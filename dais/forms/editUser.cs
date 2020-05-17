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
    public partial class editUser : Form
    {
        private Collection<Personal> personal;
        private Personal chosenPersonal;
        private int idoddielu;
        private bool check = false;
        public editUser()
        {
            InitializeComponent();
            initCb();
            initCBoddiel();
        }
        private void initCb()
        {
            personal = dbProcessorr.GetAllResults();
            foreach (Personal e in personal)
            {
                String tmp = e.pid + "," + e.meno + "," + e.priezvisko + "," + e.id_oddielu + "," +
                             e.praceschopnost;
                comboBox1.Items.Add(tmp);
            }
            
        }
        private void initTb()
        {
            String tmp = comboBox1.Text;
            string[] words = tmp.Split(',');
            generL.Text = words[0];
            menotextBox.Text = words[1];
            priezviskotextBox.Text = words[2];
            oddielCB.Text = words[3];
            praceschopnostCB.Text = words[4];


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            initTb();

        }

        private void editB_Click(object sender, EventArgs e)
        {
            string text;
            chosenPersonal = new Personal();
            chosenPersonal.pid = generL.Text;
            chosenPersonal.meno = menotextBox.Text;
            chosenPersonal.priezvisko = priezviskotextBox.Text;
            chosenPersonal.id_oddielu = idoddielu;
            chosenPersonal.praceschopnost = praceschopnostCB.Text;
            if (menotextBox.Text.Length > 30)
            {
                text = "Meno zamestnanca príliš dlhé";
                MessageBox.Show(text);
            }
            else if (priezviskotextBox.Text.Length > 30)
            {
                text = "Priezvisko zamestnanca príliš dlhé";
                MessageBox.Show(text);
            }
            else if (menotextBox.Text.Length == 0)
            {
                text = "Meno zamestnanca nevyplnené";
                MessageBox.Show(text);
            }
            else if (priezviskotextBox.Text.Length == 0)
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
                dbProcessorr.EditEmployee(chosenPersonal);
                text = "Záznam editovaný";
                MessageBox.Show(text);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void initCBoddiel()
        {
            Collection<Pracovny_oddiel> p = dbProcessorr.GetAllOddieli();
            foreach (Pracovny_oddiel o in p)
            {
                oddielCB.Items.Add(o.id_oddielu + "," + o.nazov_oddielu);
            }
        }

        private void oddielCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tmp = oddielCB.Text;
            string[] words = tmp.Split(',');
            idoddielu = int.Parse(words[0]);

        }

        private void menotextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
