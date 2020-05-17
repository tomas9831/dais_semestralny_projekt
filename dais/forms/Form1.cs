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
    public partial class Form1 : Form
    {
        private Collection<Personal> users;
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }
        public void InitializeListView()
        {
            listView1.Clear();
            listView1.TabIndex = 0;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.MultiSelect = true;
            listView1.GridLines = true;

            ColumnHeader pid = new ColumnHeader();
            pid.Text = "pid";
            pid.TextAlign = HorizontalAlignment.Center;
            pid.Width = 142;

            ColumnHeader meno = new ColumnHeader();
            meno.Text = "meno";
            meno.TextAlign = HorizontalAlignment.Center;
            meno.Width = 142;


            ColumnHeader priezvisko = new ColumnHeader();
            priezvisko.Text = "priezvisko";
            priezvisko.TextAlign = HorizontalAlignment.Center;
            priezvisko.Width = 142;

            ColumnHeader oddiel = new ColumnHeader();
            oddiel.Text = "id oddielu";
            oddiel.TextAlign = HorizontalAlignment.Center;
            oddiel.Width = 142;

            ColumnHeader aktivny = new ColumnHeader();
            aktivny.Text = "praceschopnost";
            aktivny.TextAlign = HorizontalAlignment.Center;
            aktivny.Width = 142;

            this.listView1.Columns.Add(pid);
            this.listView1.Columns.Add(meno);
            this.listView1.Columns.Add(priezvisko);
            this.listView1.Columns.Add(oddiel);
            this.listView1.Columns.Add(aktivny);

            users = dbProcessorr.GetAllResults();
            if (users == null) return;
            foreach (Personal user in users)
            {
                ListViewItem item = new ListViewItem(user.pid);
                item.SubItems.Add(user.meno);
                item.SubItems.Add(user.priezvisko);
                item.SubItems.Add(user.id_oddielu.ToString());
                item.SubItems.Add(user.praceschopnost);
                listView1.Items.Add(item);
            }

        }

        private void pridatB_Click(object sender, EventArgs e)
        {
            addUser adduser = new addUser();

            using (adduser)
            {
                adduser.ShowDialog();
            }
        }

        private void editB_Click(object sender, EventArgs e)
        {
            editUser x = new editUser();

            using (x)
            {
                x.ShowDialog();
            }

        }

        private void removeB_Click(object sender, EventArgs e)
        {
            removeUser x = new removeUser();

            using (x)
            {
                x.ShowDialog();
            }
        }

        private void detailB_Click(object sender, EventArgs e)
        {
            detailUser x = new detailUser();

            using (x)
            {
                x.ShowDialog();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void refreshB_Click(object sender, EventArgs e)
        {
            InitializeListView();
        }

        private void letB_Click(object sender, EventArgs e)
        {
            ZamestnanciLet x = new ZamestnanciLet();

            using (x)
            {
                x.ShowDialog();
            }
        }
    }
}
