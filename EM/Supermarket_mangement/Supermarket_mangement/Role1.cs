using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mangement
{
    public partial class Role1 : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.con);
        public Role1()
        {
            InitializeComponent();
            fill_dgv1();
            add_data_combo1();
        }
        private void add_data_combo1()
        {
            
            
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from DBA_SYS_PRIVS ", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            comboBox1.DataSource = dtab;
            comboBox1.DisplayMember = "PRIVILEGE";
        }
        private void fill_dgv1()
        {

            OleDbDataAdapter dataAd = new OleDbDataAdapter("select * from DBA_SYS_PRIVS", con);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            dataGridView1.DataSource = dtabl;

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (textBox2.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand("select * from DBA_SYS_PRIVS where PRIVILEGE like '" + comboBox1.Text + "%'", con);
                OleDbDataAdapter dataAd = new OleDbDataAdapter(cmd);
                DataTable dtabl = new DataTable();
                dataAd.Fill(dtabl);
                textBox2.Text = dtabl.ToString();
            }

            con.Close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
