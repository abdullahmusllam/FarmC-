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
    public partial class Rolr : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL;User ID=fawzi; Password=aa778;");
        public Rolr()
        {
            InitializeComponent();
            fill_dgv1();
            fill_dgv2();
            add_data_combo1();
        
    }
        private void fill_dgv1()
        {
            OleDbDataAdapter dataAd = new OleDbDataAdapter("select * from all_users", con);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            dataGridView1.DataSource = dtabl;
            dataGridView1.Refresh();

        }
        private void fill_dgv2()
        {
            OleDbDataAdapter dataAd = new OleDbDataAdapter("select * from  user_role_privs", con);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            dataGridView2.DataSource = dtabl;
            dataGridView2.Refresh();

        }
        private void add_data_combo1()
        {
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from user_role_privs ", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            comboBox1.DataSource = dtab;
            comboBox1.DisplayMember = "granted_role";


        }

    }
}
