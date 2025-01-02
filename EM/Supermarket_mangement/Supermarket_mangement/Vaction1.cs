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
    public partial class Vaction1 : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.con);
        public Vaction1()
        {
            InitializeComponent();
            add_data_combo();
            fill_dgv1();
        }

        private void panel_vac_Paint(object sender, PaintEventArgs e)
        {

        }
        private void fill_dgv1()
        {
            
            OleDbDataAdapter dataAd = new OleDbDataAdapter("select * from vaction", con);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            dgv_vaction.DataSource = dtabl;

        }

        private void add_data_combo()
        {

           OleDbDataAdapter dataA = new OleDbDataAdapter("select * from emp_test", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            combo_emp.DataSource = dtab;
            combo_emp.DisplayMember = "EMP_NAME";
            combo_emp.ValueMember = "EMP_ID";



        }
        private void button4_Click(object sender, EventArgs e)
        {
            try {
                OleDbCommand cmd1 = new OleDbCommand("insert into vaction values('" + text_id.Text + "','" + combo_emp.SelectedValue + "','" + firt_date.Text + "','" + end_date.Text + "','" + reasion.Text + "')", con);
                con.Open();

                cmd1.ExecuteNonQuery();
                con.Close();
               

                fill_dgv1(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("تم الحفظ بنجاح");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("update emp_test set id_vac='" + text_id.Text + "', id_emp='" + combo_emp.SelectedValue + "' ,start_vac='" + firt_date.Text + "',end_vac='" + end_date.Text + "' where id_vac='" + Convert.ToInt32(text_id.Text) + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
               
                fill_dgv1(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("تم التعديل بنجاح");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("delete  from vaction where vac_id='" + Convert.ToInt32(text_id.Text) + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
               
                fill_dgv1(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("تم الحذف  بنجاح");
            }
        }
    }
}
