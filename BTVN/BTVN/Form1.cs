using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem (txtlast.Text);
            newitem.SubItems.Add (txtfirst.Text);
            newitem.SubItems.Add (txtphone.Text);
            listView1 .Items.Add (newitem);
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0) { 
                txtlast.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtfirst.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtphone.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtlast.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtfirst.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtphone.Text;


            }
        }
    }
}
