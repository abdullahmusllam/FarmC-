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
    public partial class ADD : Form
    {

        OleDbConnection con = new OleDbConnection(Connection.con);
        OleDbCommand cmd = new OleDbCommand();
        public ADD()
        {
            InitializeComponent();
            fill_dgv1();
        }
        private void fill_dgv1()
        {
            OleDbDataAdapter dataAd = new OleDbDataAdapter("select * from all_users", con);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            dataGridView1.DataSource = dtabl;
            dataGridView1.Refresh();

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand(@"create user "+user.Text+" identified by "+pas.Text+"", con);

            cmd.ExecuteNonQuery();
         

            con.Close();
            MessageBox.Show("تمت إضافة مستخدم "+user.Text);
            // cmd.CommandText = @"grant create session to '" + user.Text + "'";
            //cmd.Connection = con;
        }

        private void ADD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
