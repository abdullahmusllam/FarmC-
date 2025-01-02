namespace Supermarket_mangement
{
    partial class Vaction
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
            this.panel_vaction = new System.Windows.Forms.Panel();
            this.date_aduic = new System.Windows.Forms.DateTimePicker();
            this.combo_emp = new MetroFramework.Controls.MetroComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_aduienc = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reasion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_vaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aduienc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_vaction
            // 
            this.panel_vaction.BackColor = System.Drawing.Color.White;
            this.panel_vaction.Controls.Add(this.date_aduic);
            this.panel_vaction.Controls.Add(this.combo_emp);
            this.panel_vaction.Controls.Add(this.button4);
            this.panel_vaction.Controls.Add(this.button3);
            this.panel_vaction.Controls.Add(this.button2);
            this.panel_vaction.Controls.Add(this.dgv_aduienc);
            this.panel_vaction.Controls.Add(this.code);
            this.panel_vaction.Controls.Add(this.label4);
            this.panel_vaction.Controls.Add(this.label3);
            this.panel_vaction.Controls.Add(this.reasion);
            this.panel_vaction.Controls.Add(this.label5);
            this.panel_vaction.Controls.Add(this.label1);
            this.panel_vaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_vaction.Location = new System.Drawing.Point(0, 0);
            this.panel_vaction.Name = "panel_vaction";
            this.panel_vaction.Size = new System.Drawing.Size(988, 533);
            this.panel_vaction.TabIndex = 0;
            this.panel_vaction.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_vaction_Paint);
            // 
            // date_aduic
            // 
            this.date_aduic.CustomFormat = "dd/MM/yyyy";
            this.date_aduic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_aduic.Location = new System.Drawing.Point(203, 125);
            this.date_aduic.Name = "date_aduic";
            this.date_aduic.Size = new System.Drawing.Size(277, 20);
            this.date_aduic.TabIndex = 7;
            // 
            // combo_emp
            // 
            this.combo_emp.FormattingEnabled = true;
            this.combo_emp.ItemHeight = 23;
            this.combo_emp.Location = new System.Drawing.Point(224, 53);
            this.combo_emp.Name = "combo_emp";
            this.combo_emp.Size = new System.Drawing.Size(256, 29);
            this.combo_emp.TabIndex = 6;
            this.combo_emp.UseSelectable = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(617, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 38);
            this.button4.TabIndex = 3;
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
            this.button3.Location = new System.Drawing.Point(471, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 38);
            this.button3.TabIndex = 4;
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
            this.button2.Location = new System.Drawing.Point(324, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_aduienc
            // 
            this.dgv_aduienc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aduienc.Location = new System.Drawing.Point(55, 216);
            this.dgv_aduienc.Name = "dgv_aduienc";
            this.dgv_aduienc.Size = new System.Drawing.Size(908, 314);
            this.dgv_aduienc.TabIndex = 2;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(594, 57);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(257, 30);
            this.code.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(857, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "سبب الغياب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "يوم الغياب";
            // 
            // reasion
            // 
            this.reasion.Location = new System.Drawing.Point(593, 116);
            this.reasion.Multiline = true;
            this.reasion.Name = "reasion";
            this.reasion.Size = new System.Drawing.Size(258, 40);
            this.reasion.TabIndex = 1;
            this.reasion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(862, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "رقم الكود";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الموظف";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Vaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 533);
            this.Controls.Add(this.panel_vaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vaction";
            this.Text = "Vaction";
            this.panel_vaction.ResumeLayout(false);
            this.panel_vaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aduienc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_vaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_aduienc;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reasion;
        private MetroFramework.Controls.MetroComboBox combo_emp;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker date_aduic;
    }
}