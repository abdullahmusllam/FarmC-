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
    public partial class catgory : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.con);
        public catgory()

        {
            InitializeComponent();
            text_name_jop.Focus();
            text_name_jop.Select();
            text_name_jop.SelectAll();
            dgv_add();
        
        }

        private void catgory_Load(object sender, EventArgs e)
        {
                        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void text_id_jop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                text_name_jop.Focus();
            }
        }
        private void clear1()
        {

            text_id_jop.Text = "";
            text_name_jop.Text = "";
            

        }
      
        private void add_jop_Click(object sender, EventArgs e)
        {
            if (text_name_jop.Text == "") {
                MessageBox.Show("تأكد من ادخال اسم الوظيفة");
            }
            else {
                try
                {

                    con.Open();
                    string getlastId = "select max (jop_id) from type_jop";
                    OleDbCommand cmd2 = new OleDbCommand(getlastId, con);
                    int newId;
                    int lastId;
                    if (Convert.IsDBNull(cmd2.ExecuteScalar()))
                    {
                        newId = 0;
                    }
                    else
                    {
                        lastId = Convert.ToInt32(cmd2.ExecuteScalar());
                        newId = lastId + 1;
                    }
                    OleDbCommand cmd = new OleDbCommand("insert into type_jop values('" + newId + "','" + text_name_jop.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم الحفظ بنجاح");
                    clear1();
                    dgv_add();

                    text_id_jop.Focus();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                } }
        }

        private void update_jop_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(" update type_jop set jop_id ='" + Convert.ToInt32(text_id_jop.Text) + "',jop_name='" + (text_name_jop.Text) + "' where jop_id ='" + Convert.ToInt32(text_id_jop.Text) + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم التعديل بنجاح");
              dgv_add();
                clear1();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void Delete_jop_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete  from type_jop where jop_id='" + text_id_jop.Text + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم الحذف  بنجاح");
            dgv_add();
            clear1();
        }

        private void dgv_dep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            text_id_jop.Text = dgv_dep.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_name_jop.Text = dgv_dep.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void dgv_add()
        {
            OleDbDataAdapter dataA = new OleDbDataAdapter("select * from type_jop", con);
            DataTable dtab = new DataTable();
            dataA.Fill(dtab);
            dgv_dep.DataSource = dtab;
        }
       

        private void text_id_cat_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void add_pro_Click(object sender, EventArgs e)
        {
             
        }

        private void dgv_catgory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void delete_Click(object sender, EventArgs e)
        {
          
           
        }

        private void update_cat_Click(object sender, EventArgs e)
        {
            
        }

        private void text_name_jop_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                add_jop.PerformClick();
                text_name_jop.Focus();
            }
        }

        private void text_name_cat_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void text_name_jop_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
