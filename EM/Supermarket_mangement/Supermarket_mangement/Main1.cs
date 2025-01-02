using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mangement
{
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
            Emp_Form pr = new Emp_Form();
            move_panl(btn_emp);
            add_panle(pr.emp_container);
            la_show.Text = btn_emp.Text;
        }

        private void label_btn_Click(object sender, EventArgs e)
        {

        }
        private void move_panl(Button btn)
        {
            panel_slide.Top = btn.Top;
            panel_slide.Height = btn.Height;
        }
        private void add_panle(Panel pn)
        {
            pn_conten.Controls.Clear();
            pn.Dock = DockStyle.Fill;
            pn_conten.Controls.Clear();
            pn_conten.Controls.Add(pn);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Emp_Form pr = new Emp_Form();
            move_panl(btn_emp);
            add_panle(pr.emp_container);
            la_show.Text = btn_emp.Text;
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            catgory ca = new catgory();
            move_panl(ptn_cat);
            add_panle(ca.panel_cat);
            la_show.Text = ptn_cat.Text;
        }

        private void ptn_cat_Click(object sender, EventArgs e)
        {
            Vaction vac = new Vaction();
            move_panl(ptn_cat);
            add_panle(vac.panel_vaction);
            la_show.Text = ptn_cat.Text;
            if (Connection.changed == "SUPERVISOR")
            {
                vac.button2.Visible = false;
                vac.button3.Visible = false;
                vac.button4.Visible = false;
            }
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            Vaction1 vac= new Vaction1();
            
            move_panl(btn_store);
            add_panle(vac.panel_vac);
            la_show.Text = btn_store.Text;
            if(Connection.changed== "SUPERVISOR")
            {
                vac.button2.Visible = false;
                vac.button3.Visible = false;
                vac.button4.Visible = false;
            }
        }

        private void btn_bii_Click(object sender, EventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pn_conten_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reort_audi test = new Reort_audi();
            move_panl(btn_addmistriton);
            add_panle(test.panel_repoort);
            la_show.Text = btn_addmistriton.Text;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            move_panl(btn_logout);
            Login log = new Login();
            this.Hide();
            log.Show();

        }
    }
}
