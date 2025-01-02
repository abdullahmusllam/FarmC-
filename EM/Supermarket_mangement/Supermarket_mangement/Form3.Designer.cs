namespace Supermarket_mangement
{
    partial class catgory
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
            this.panel_cat = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dep = new System.Windows.Forms.DataGridView();
            this.add_jop = new System.Windows.Forms.Button();
            this.update_jop = new System.Windows.Forms.Button();
            this.Delete_jop = new System.Windows.Forms.Button();
            this.text_name_jop = new System.Windows.Forms.TextBox();
            this.text_id_jop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_cat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cat
            // 
            this.panel_cat.Controls.Add(this.groupBox1);
            this.panel_cat.Controls.Add(this.label1);
            this.panel_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cat.Location = new System.Drawing.Point(0, 0);
            this.panel_cat.Name = "panel_cat";
            this.panel_cat.Size = new System.Drawing.Size(998, 491);
            this.panel_cat.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dep);
            this.groupBox1.Controls.Add(this.add_jop);
            this.groupBox1.Controls.Add(this.update_jop);
            this.groupBox1.Controls.Add(this.Delete_jop);
            this.groupBox1.Controls.Add(this.text_name_jop);
            this.groupBox1.Controls.Add(this.text_id_jop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(18, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 401);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الوظائف";
            // 
            // dgv_dep
            // 
            this.dgv_dep.AllowUserToAddRows = false;
            this.dgv_dep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dep.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dep.Location = new System.Drawing.Point(6, 195);
            this.dgv_dep.Name = "dgv_dep";
            this.dgv_dep.Size = new System.Drawing.Size(915, 199);
            this.dgv_dep.TabIndex = 4;
            this.dgv_dep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dep_CellClick);
            // 
            // add_jop
            // 
            this.add_jop.BackColor = System.Drawing.Color.Teal;
            this.add_jop.FlatAppearance.BorderSize = 0;
            this.add_jop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_jop.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.add_jop.ForeColor = System.Drawing.Color.White;
            this.add_jop.Location = new System.Drawing.Point(613, 138);
            this.add_jop.Name = "add_jop";
            this.add_jop.Size = new System.Drawing.Size(140, 43);
            this.add_jop.TabIndex = 3;
            this.add_jop.Text = "إضافة";
            this.add_jop.UseVisualStyleBackColor = false;
            this.add_jop.Click += new System.EventHandler(this.add_jop_Click);
            // 
            // update_jop
            // 
            this.update_jop.BackColor = System.Drawing.Color.LightSeaGreen;
            this.update_jop.FlatAppearance.BorderSize = 0;
            this.update_jop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_jop.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.update_jop.ForeColor = System.Drawing.Color.White;
            this.update_jop.Location = new System.Drawing.Point(434, 138);
            this.update_jop.Name = "update_jop";
            this.update_jop.Size = new System.Drawing.Size(140, 43);
            this.update_jop.TabIndex = 3;
            this.update_jop.Text = "تعديل";
            this.update_jop.UseVisualStyleBackColor = false;
            this.update_jop.Click += new System.EventHandler(this.update_jop_Click);
            // 
            // Delete_jop
            // 
            this.Delete_jop.BackColor = System.Drawing.Color.Crimson;
            this.Delete_jop.FlatAppearance.BorderSize = 0;
            this.Delete_jop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_jop.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Delete_jop.ForeColor = System.Drawing.Color.White;
            this.Delete_jop.Location = new System.Drawing.Point(252, 138);
            this.Delete_jop.Name = "Delete_jop";
            this.Delete_jop.Size = new System.Drawing.Size(140, 43);
            this.Delete_jop.TabIndex = 3;
            this.Delete_jop.Text = "حذف";
            this.Delete_jop.UseVisualStyleBackColor = false;
            this.Delete_jop.Click += new System.EventHandler(this.Delete_jop_Click);
            // 
            // text_name_jop
            // 
            this.text_name_jop.Location = new System.Drawing.Point(252, 77);
            this.text_name_jop.Name = "text_name_jop";
            this.text_name_jop.Size = new System.Drawing.Size(155, 43);
            this.text_name_jop.TabIndex = 2;
            this.text_name_jop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_name_jop_KeyDown);
            this.text_name_jop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_name_jop_KeyPress);
            // 
            // text_id_jop
            // 
            this.text_id_jop.Location = new System.Drawing.Point(586, 77);
            this.text_id_jop.Name = "text_id_jop";
            this.text_id_jop.Size = new System.Drawing.Size(167, 43);
            this.text_id_jop.TabIndex = 2;
            this.text_id_jop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_id_jop_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(609, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "رقم التسلسل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(263, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الوظيفة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(444, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "إضافة الانواع";
            // 
            // catgory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 491);
            this.Controls.Add(this.panel_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "catgory";
            this.Text = "catgory";
            this.Load += new System.EventHandler(this.catgory_Load);
            this.panel_cat.ResumeLayout(false);
            this.panel_cat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel_cat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dep;
        private System.Windows.Forms.Button add_jop;
        private System.Windows.Forms.Button update_jop;
        private System.Windows.Forms.Button Delete_jop;
        private System.Windows.Forms.TextBox text_name_jop;
        private System.Windows.Forms.TextBox text_id_jop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}