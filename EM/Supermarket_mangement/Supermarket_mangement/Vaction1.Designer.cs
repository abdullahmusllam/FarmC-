namespace Supermarket_mangement
{
    partial class Vaction1
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
            this.panel_vac = new System.Windows.Forms.Panel();
            this.text_id = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgv_vaction = new System.Windows.Forms.DataGridView();
            this.reasion = new System.Windows.Forms.TextBox();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.firt_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_emp = new System.Windows.Forms.ComboBox();
            this.panel_vac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vaction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_vac
            // 
            this.panel_vac.BackColor = System.Drawing.Color.White;
            this.panel_vac.Controls.Add(this.text_id);
            this.panel_vac.Controls.Add(this.button3);
            this.panel_vac.Controls.Add(this.button2);
            this.panel_vac.Controls.Add(this.button4);
            this.panel_vac.Controls.Add(this.dgv_vaction);
            this.panel_vac.Controls.Add(this.reasion);
            this.panel_vac.Controls.Add(this.end_date);
            this.panel_vac.Controls.Add(this.firt_date);
            this.panel_vac.Controls.Add(this.label4);
            this.panel_vac.Controls.Add(this.label3);
            this.panel_vac.Controls.Add(this.label5);
            this.panel_vac.Controls.Add(this.label2);
            this.panel_vac.Controls.Add(this.label1);
            this.panel_vac.Controls.Add(this.combo_emp);
            this.panel_vac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_vac.Location = new System.Drawing.Point(0, 0);
            this.panel_vac.Name = "panel_vac";
            this.panel_vac.Size = new System.Drawing.Size(862, 493);
            this.panel_vac.TabIndex = 0;
            this.panel_vac.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_vac_Paint);
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(553, 24);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(197, 20);
            this.text_id.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(388, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "تعديل";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(241, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(534, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "اضافة";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgv_vaction
            // 
            this.dgv_vaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vaction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_vaction.Location = new System.Drawing.Point(0, 245);
            this.dgv_vaction.Name = "dgv_vaction";
            this.dgv_vaction.Size = new System.Drawing.Size(862, 248);
            this.dgv_vaction.TabIndex = 4;
            // 
            // reasion
            // 
            this.reasion.Location = new System.Drawing.Point(101, 53);
            this.reasion.Multiline = true;
            this.reasion.Name = "reasion";
            this.reasion.Size = new System.Drawing.Size(272, 58);
            this.reasion.TabIndex = 3;
            // 
            // end_date
            // 
            this.end_date.CustomFormat = "dd/MM/yyyy";
            this.end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_date.Location = new System.Drawing.Point(112, 127);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(261, 20);
            this.end_date.TabIndex = 2;
            // 
            // firt_date
            // 
            this.firt_date.CustomFormat = "dd/MM/yyyy";
            this.firt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.firt_date.Location = new System.Drawing.Point(553, 130);
            this.firt_date.Name = "firt_date";
            this.firt_date.Size = new System.Drawing.Size(197, 20);
            this.firt_date.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "نهاية الاجازة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "اسم الموظف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(780, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "بداية الاجازة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "سبب العطلة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الموظف";
            // 
            // combo_emp
            // 
            this.combo_emp.FormattingEnabled = true;
            this.combo_emp.Location = new System.Drawing.Point(553, 59);
            this.combo_emp.Name = "combo_emp";
            this.combo_emp.Size = new System.Drawing.Size(197, 21);
            this.combo_emp.TabIndex = 0;
            this.combo_emp.TabStop = false;
            // 
            // Vaction1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 493);
            this.Controls.Add(this.panel_vac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vaction1";
            this.Text = "Vaction1";
            this.panel_vac.ResumeLayout(false);
            this.panel_vac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox combo_emp;
        private System.Windows.Forms.TextBox reasion;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.DateTimePicker firt_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_vaction;
        private System.Windows.Forms.TextBox text_id;
        public System.Windows.Forms.Panel panel_vac;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
    }
}