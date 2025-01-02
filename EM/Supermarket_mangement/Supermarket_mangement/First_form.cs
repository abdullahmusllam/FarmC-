using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mangement
{
    public partial class First_form : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.con);
        OleDbCommand cmd = new OleDbCommand();
        public First_form()
        {
            InitializeComponent();
        }

        private void btn_add_qurey_Click(object sender, EventArgs e)
        {
            try {
               
                String file_path = @"D:\الجامعة\المستوى الثالث\واجبات\EM\text.sql";
                string filecontent = File.ReadAllText(file_path);
                con.Open();
                string[] command = filecontent.Split( new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string commandtext in command)
                {
                    using (OleDbCommand com = new OleDbCommand(commandtext, con))
                    {
                        com.CommandType = CommandType.Text;
                        com.ExecuteNonQuery();
                    }

                }
            }catch(Exception Ex)
            {
                con.Close();
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                MessageBox.Show("تم الاظافة بنجاح");
            }
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmd.CommandText = @"create user y1 identified by o ";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"create user y2 identified by o ";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"create user y3 identified by o ";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"grant create session to y1";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"grant create session to y2";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"grant create session to y3";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                MessageBox.Show("تمت بنجاح ");

               


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
