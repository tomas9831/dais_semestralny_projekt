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
    public partial class detailUser : Form
    {
        private Collection<Personal> personal;
        private Collection<Pracovne_smeny> smeny;
        private String currentPid;

        public detailUser()
        {
            InitializeComponent();
            initCb();
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

        private void initLabel()
        {
            String tmp = comboBox1.Text;
            string[] words = tmp.Split(',');
            pidData.Text = words[0];
            menoData.Text = words[1];
            priezviskoData.Text = words[2];
            id_oddieluData.Text = words[3];
            praceschopnostData.Text = words[4];

            currentPid = pidData.Text;

            initListBox();
        }

        private void initListBox()
        {
            listView1.Clear();
            listView1.TabIndex = 0;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.MultiSelect = true;
            listView1.GridLines = true;

            ColumnHeader id_smeny = new ColumnHeader();
            id_smeny.Text = "id smeny";
            id_smeny.TextAlign = HorizontalAlignment.Center;
            id_smeny.Width = 142;

            ColumnHeader id_typ_ukolu = new ColumnHeader();
            id_typ_ukolu.Text = "typ ukolu";
            id_typ_ukolu.TextAlign = HorizontalAlignment.Center;
            id_typ_ukolu.Width = 142;


            ColumnHeader id_letu = new ColumnHeader();
            id_letu.Text = "id_letu";
            id_letu.TextAlign = HorizontalAlignment.Center;
            id_letu.Width = 142;

            ColumnHeader pid = new ColumnHeader();
            pid.Text = "pid";
            pid.TextAlign = HorizontalAlignment.Center;
            pid.Width = 142;

            ColumnHeader datum = new ColumnHeader();
            datum.Text = "datum";
            datum.TextAlign = HorizontalAlignment.Center;
            datum.Width = 142;

            ColumnHeader smena = new ColumnHeader();
            smena.Text = "smena";
            smena.TextAlign = HorizontalAlignment.Center;
            smena.Width = 142;

            this.listView1.Columns.Add(id_smeny);
            this.listView1.Columns.Add(id_typ_ukolu);
            this.listView1.Columns.Add(id_letu);
            this.listView1.Columns.Add(pid);
            this.listView1.Columns.Add(datum);
            this.listView1.Columns.Add(smena);

            smeny = dbProcessorr.getSmenyPreZamestnanca(currentPid);
            if (smeny == null) return;
            foreach (Pracovne_smeny s in smeny)
            {
                ListViewItem item = new ListViewItem(s.id_smeny.ToString());
                item.SubItems.Add(s.id_typ_ukolu.ToString());
                item.SubItems.Add(s.id_letu.ToString());
                item.SubItems.Add(s.pid);
                item.SubItems.Add(s.datum.ToString());
                item.SubItems.Add(s.smena.ToString());
                listView1.Items.Add(item);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            initLabel();
        }
    }
}