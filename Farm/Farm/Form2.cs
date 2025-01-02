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
    public partial class Form2 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-J5G8TJR;  Initial Catalog= Farmer; Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Form2()
        {
            InitializeComponent();

            da = new SqlDataAdapter("Select * from Products", cn);
            da.Fill(ds, "BooksInfo");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Hide();
            fm1.Show();
        }
    }
}
