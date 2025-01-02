using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farm
{
    public partial class Form1 : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-J5G8TJR; Initial Catalog= Farmer; Integrated Security=true");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cn.Open();
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand("select * from Products", cn);
            dr = cmd.ExecuteReader();
            listBox1.Items.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString().Trim() +"\t" + dr[1].ToString().Trim() + "\t\t" + dr[2].ToString().Trim() + "\t\t" + dr[3].ToString().Trim() + "\t\t" + dr[4].ToString().Trim() + "\t\t" + dr[5].ToString().Trim());
            }
            cn.Close();
            dr.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("insert into Products (ID, name_product, type_product, price, Quantity) values ('" + txtID.Text + "','" + txtBTitle.Text+ "', '" +txtType.Text + "', '" + txtprice.Text + "', '" + txtQuantity.Text + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("One Record added successfully!", "Add New", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("delete from Products where name_product = '" + txtBTitle.Text + "'", cn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("One Record deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            cn.Open();

            SqlCommand cmd;
            SqlDataReader dr;

                using (SqlCommand commandRowCount
                    = new SqlCommand("SELECT COUNT(*) from Products where name_product= '" + txtSearch.Text + "'", cn))
                {
                    var countStart = (int)commandRowCount.ExecuteScalar();

                    if (countStart < 1)
                    {

                        DialogResult dgr = MessageBox.Show(" Products Not Found, Do you want to search again?", "Search", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dgr == DialogResult.Yes)
                        {
                            cn.Close();
                            return;
                        }
                        else { this.Close(); }


                    }
                    else
                    {
                        cmd = new SqlCommand("select * from Products where name_product = '" + txtSearch.Text + "'", cn);
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        txtID.Text = dr[0].ToString();
                        txtBTitle.Text = dr[1].ToString();
                        txtType.Text = dr[2].ToString();
                        txtprice.Text = dr[3].ToString();
                        txtQuantity.Text = dr[4].ToString();
                       
                        dr.Close();
                        cn.Close();
                    }
 
            }




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cn.Open();
            //cmd = new SqlCommand("Update Products Set ID='"+int.Parse(txtID.Text)+"', name_product='" + txtBTitle.Text + "', type_product='" +txtType+"', price='"+ double.Parse(txtprice.Text) + "' where name_product='" + txtSearch.Text + "'", cn);
            cmd = new SqlCommand("Update Products Set ID='" + int.Parse(txtID.Text) +"', name_product='" +txtBTitle.Text + "', type_product='" + txtType.Text + "', price='" + txtprice.Text + "', Quantity='" + txtQuantity.Text + "' where name_product='" + txtSearch.Text + "'", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("One Record Updated successfully!", "Update New", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            this.Hide();
            fm2.Show();

        }

        private void txtBTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

    

