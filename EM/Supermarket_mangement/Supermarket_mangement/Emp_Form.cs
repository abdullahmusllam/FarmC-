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
    public partial class Emp_Form : Form
        
    {
        String names, password;

        OleDbConnection con = new OleDbConnection(Connection.con);
      
        public Emp_Form()
        {
            InitializeComponent();
            add_data_combo();
            fill_dgv1();
        }
        
        public void datagridview_style()
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                /*   string getlast_id = "select max (emp_id) from emp_test";
                   OleDbCommand cmd1 = new OleDbCommand(getlast_id, con);
                   int last_id = Convert.ToInt32(cmd1.ExecuteScalar());
                   int new_id = last_id + 1;*/

                Login log = new Login();

                names = log.text_user.Text;
                password = log.text_pas.Text;
                OleDbCommand cmd = new OleDbCommand("insert into emp_test values(" + code.Text+ ",'" + name.Text + "','" + phone.Text + "','" + text_addres.Text+ "','" + comb_type.SelectedValue + "')", con);

                cmd.ExecuteNonQuery();


                con.Close();

                MessageBox.Show("تم الحف بنجاح", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fill_dgv1(); }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
        private void add_data_combo()
        {
            Login log = new Login();

            names = log.text_user.Text;
            password = log.text_pas.Text;
        //    con = Connection.getcon(names, password);
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from type_jop", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            comb_type.DataSource = dtab;
            comb_type.DisplayMember = "jop_name";
            comb_type.ValueMember = "jop_id";



        }
          private void fill_dgv1()
        {

            Login log = new Login();

            names = log.text_user.Text;
            password = log.text_pas.Text;
         //   con = Connection.getcon(names, password);

            OleDbDataAdapter dataAd = new OleDbDataAdapter("select * from emp_test ", con);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            emp_grdview.DataSource = dtabl;
          
        }

        private void add_data_combo1()
        {
            Login log = new Login();

            names = log.text_user.Text;
            password = log.text_pas.Text;
            //con1 = Connection.getcon(names, password);
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from type_jop ", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            comb_type.DataSource = dtab;
            comb_type.DisplayMember = "jop_name";
            comb_type.ValueMember = "jop_id";

        }
        private void comb_type_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void Emp_Form_Load(object sender, EventArgs e)
        {
            add_data_combo();
            fill_dgv1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            names = log.text_user.Text;
            password = log.text_pas.Text;
           // con = Connection.getcon(names, password);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("update emp_test set emp_name='" + name.Text + "', emp_phone='" + phone.Text + "' ,emp_addres='"+text_addres.Text+"',jop_id='"+comb_type.SelectedValue+"' where emp_id='" + Convert.ToInt32( code.Text) + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم التعديل بنجاح");
            fill_dgv1();
        }

        private void emp_grdview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           code.Text = emp_grdview.Rows[e.RowIndex].Cells[0].Value.ToString();
           name.Text = emp_grdview.Rows[e.RowIndex].Cells[1].Value.ToString();
            phone.Text = emp_grdview.Rows[e.RowIndex].Cells[2].Value.ToString();
          comb_type.DisplayMember = emp_grdview.Rows[e.RowIndex].Cells[3].Value.ToString();
            text_addres.Text = emp_grdview.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            names = log.text_user.Text;
            password = log.text_pas.Text;
            //con = Connection.getcon(names, password);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete  from emp_test where emp_id='" + Convert.ToInt32( code.Text) + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم الحذف  بنجاح");
            fill_dgv1();
        }

        private void emp_grdview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comb_type.Focus();
            }
        }

        private void comb_type_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                phone.Focus();
            }
        }

        private void phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button4.PerformClick();
                name.Focus();
                
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
