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
    public partial class Revoilk : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL;User ID=fawzi; Password=aa778;");
        public Revoilk()
        {
            InitializeComponent();
            fill_dgv2();
        }
        private void fill_dgv2()
        {
            OleDbDataAdapter dataAd = new OleDbDataAdapter("select * from  Dba_ROLE_PRIVS", con);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            dataGridView1.DataSource = dtabl;
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("REVOKE "+ role.Text+" from "+ user.Text +" ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" تم سحب صلاحية ");
            fill_dgv2();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            user.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            role.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_return_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("REVOKE " + role.Text + " from " + user.Text + " ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" تم سحب صلاحية ");
            fill_dgv2();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            user.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            role.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
