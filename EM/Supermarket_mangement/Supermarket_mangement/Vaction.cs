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
    public partial class Vaction : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.con);
        public Vaction()
        {
            InitializeComponent();
            add_data_combo();
            fill_dgv1();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fill_dgv1()
        {

            OleDbDataAdapter dataAd = new OleDbDataAdapter("select * from absicen ", con);
            DataTable dtabl = new DataTable();
            dataAd.Fill(dtabl);
            dgv_aduienc.DataSource = dtabl;

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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {

                OleDbCommand cmd1 = new OleDbCommand("insert into absicen values('" + code.Text + "','" + combo_emp.SelectedValue + "','" + date_aduic.Text + "','" + reasion.Text + "')", con);
                con.Open();

                cmd1.ExecuteNonQuery();
               
              
                fill_dgv1();
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
                con.Close();
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
                OleDbCommand cmd = new OleDbCommand("update absicen set id_absatt='" + code.Text + "', id_emp='" + combo_emp.SelectedValue + "', day_date='" + date_aduic.Text + "', where id_vac='" + Convert.ToInt32(code.Text) + "' ", con);
                cmd.ExecuteNonQuery();
                fill_dgv1(); }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
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
                OleDbCommand cmd = new OleDbCommand("delete  from absicen  where id_absatt='" + Convert.ToInt32(code.Text) + "' ", con);
                cmd.ExecuteNonQuery();
             
                fill_dgv1(); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                MessageBox.Show("تم الحذف  بنجاح");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void panel_vaction_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
