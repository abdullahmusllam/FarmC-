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
    public partial class Emp_info : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL;User ID=fawzi; Password=aa778;");
        public Emp_info()
        {
            InitializeComponent();
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (text_search.Text != "")
            {
                OleDbCommand cmd = new OleDbCommand("select * from emp where emp_name like '" + text_search.Text + "%'", con);
                OleDbDataAdapter dataAd = new OleDbDataAdapter(cmd);
                DataTable dtabl = new DataTable();
                dataAd.Fill(dtabl);
                dgvemp.DataSource = dtabl;
            }
            
            con.Close();
        
        }
        private void fill_dgv1()
        {
            OleDbDataAdapter dataAd = new OleDbDataAdapter("select * from emp ", con);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
           dgvemp.DataSource = dtabl;
            dgvemp.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Emp_info_Load(object sender, EventArgs e)
        {
            fill_dgv1();
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void combo_type_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
