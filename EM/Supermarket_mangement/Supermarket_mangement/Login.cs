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
    public partial class Login : Form
    {
        OleDbConnection con = new OleDbConnection(Connection.con);


        public Login()
        {
            InitializeComponent();

        }

        private void text_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                text_pas.Focus();
            }
        }

        private void text_pas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //  btn_add.PerformClick();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(text_user.Text))
            {
                text_user.Focus();
                return;

            }
            if (String.IsNullOrEmpty(text_pas.Text))
            {
                text_pas.Focus();
                return;

            }
            try
            {
                con = new OleDbConnection(@"Provider=MSDAORA;Data Source=ORCL;User ID=" + text_user.Text + ";Password=" + text_pas.Text + ";");
                MessageBox.Show("login");
                premation pr = new premation();
                this.Hide();
                pr.Show();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_Click(object sender, EventArgs e)

        {
            Connection.username = text_user.Text;
            Connection.password = text_pas.Text;
            Connection.changed = comboBox1.Text;



            OleDbConnection con = new OleDbConnection(Connection.con);

            con.Open();
            try
            {
                if (con.State == ConnectionState.Open)
                {




                    OleDbCommand cmd = new OleDbCommand("select * from  DBA_ROLE_PRIVS  where GRANTEE ='" + text_user.Text + "'and GRANTED_ROLE  ='" + comboBox1.Text + "'", con);



                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {


                        if (reader["GRANTED_ROLE"].ToString() == "DBA")
                        {
                            MessageBox.Show("DBA");
                            Main1 main = new Main1();
                            Vaction1 vac1 = new Vaction1();
                            Vaction vac = new Vaction();
                            main.btn_addmistriton.Visible = true;


                            vac.button2.Visible = false;
                            vac.button3.Visible = false;
                            vac.button4.Visible = false;
                            this.Hide();
                            main.Show();



                        }
                        else if (reader["GRANTED_ROLE"].ToString() == "EMPLOYYE")
                        {
                            MessageBox.Show("Emp");
                            Emp_Form emp = new Emp_Form();
                            emp.FormBorderStyle = FormBorderStyle.Sizable;
                            this.Hide();
                            emp.Show();

                        }

                        else if (reader["GRANTED_ROLE"].ToString() == "SUPERVISOR")
                        {
                            MessageBox.Show("supervisor");
                            Main1 main = new Main1();

                            this.Hide();
                            main.Show();



                        }
                        else
                        {
                            MessageBox.Show("not found");
                        }
                        // reader.Close();
                    }


                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
           
        }
    }
    }

