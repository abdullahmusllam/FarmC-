namespace Supermarket_mangement
{
    partial class Emp_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emp_container = new System.Windows.Forms.Panel();
            this.emp_grdview = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comb_type = new System.Windows.Forms.ComboBox();
            this.text_addres = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emp_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_grdview)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp_container
            // 
            this.emp_container.Controls.Add(this.emp_grdview);
            this.emp_container.Controls.Add(this.panel2);
            this.emp_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp_container.Location = new System.Drawing.Point(0, 0);
            this.emp_container.Name = "emp_container";
            this.emp_container.Size = new System.Drawing.Size(840, 471);
            this.emp_container.TabIndex = 0;
            // 
            // emp_grdview
            // 
            this.emp_grdview.AllowUserToAddRows = false;
            this.emp_grdview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.emp_grdview.BackgroundColor = System.Drawing.Color.White;
            this.emp_grdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_grdview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emp_grdview.Location = new System.Drawing.Point(0, 175);
            this.emp_grdview.Name = "emp_grdview";
            this.emp_grdview.Size = new System.Drawing.Size(840, 296);
            this.emp_grdview.TabIndex = 3;
            this.emp_grdview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_grdview_CellClick);
            this.emp_grdview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_grdview_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comb_type);
            this.panel2.Controls.Add(this.text_addres);
            this.panel2.Controls.Add(this.phone);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.code);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 175);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comb_type
            // 
            this.comb_type.FormattingEnabled = true;
            this.comb_type.Location = new System.Drawing.Point(572, 88);
            this.comb_type.Name = "comb_type";
            this.comb_type.Size = new System.Drawing.Size(189, 21);
            this.comb_type.TabIndex = 3;
            this.comb_type.SelectedIndexChanged += new System.EventHandler(this.comb_type_SelectedIndexChanged);
            this.comb_type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comb_type_KeyDown);
            // 
            // text_addres
            // 
            this.text_addres.Location = new System.Drawing.Point(76, 66);
            this.text_addres.Multiline = true;
            this.text_addres.Name = "text_addres";
            this.text_addres.Size = new System.Drawing.Size(194, 19);
            this.text_addres.TabIndex = 2;
            this.text_addres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phone_KeyDown);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(316, 88);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(210, 19);
            this.phone.TabIndex = 2;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            this.phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phone_KeyDown);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(316, 39);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(210, 19);
            this.name.TabIndex = 2;
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_KeyDown);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(572, 39);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(189, 19);
            this.code.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(568, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "حفظ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(379, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mudir MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(215, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "العنوان";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(191, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mudir MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(470, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "الجوال";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mudir MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(437, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم الموضف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mudir MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(688, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "نوع العمل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mudir MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(695, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الكود";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Emp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 471);
            this.Controls.Add(this.emp_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emp_Form";
            this.Text = "Emp_Form";
            this.Load += new System.EventHandler(this.Emp_Form_Load);
            this.emp_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emp_grdview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView emp_grdview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comb_type;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel emp_container;
        private System.Windows.Forms.TextBox text_addres;
        private System.Windows.Forms.Label label5;
    }
}