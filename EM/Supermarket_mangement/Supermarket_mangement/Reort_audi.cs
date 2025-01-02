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
    public partial class Reort_audi : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=ORCL;User ID=fawzi; Password=aa778;");
        public Reort_audi()
        {
            InitializeComponent();
        }

        private void btn_detaile_Click(object sender, EventArgs e)
        {
            Reort_audi report = new Reort_audi();
            report.Show();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select * from absicen where day_date between '" + date_start.Value+ "' and '"+date_end.Value+"'", con);
            OleDbDataAdapter dataAd = new OleDbDataAdapter(cmd);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            dgv_repo.DataSource = dtabl;
        }
    }
}
