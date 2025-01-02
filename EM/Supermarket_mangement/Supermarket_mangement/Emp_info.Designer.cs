namespace Supermarket_mangement
{
    partial class Emp_info
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
            this.dgvemp = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_type_search = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvemp
            // 
            this.dgvemp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvemp.Location = new System.Drawing.Point(0, 112);
            this.dgvemp.Name = "dgvemp";
            this.dgvemp.Size = new System.Drawing.Size(1014, 345);
            this.dgvemp.TabIndex = 0;
            this.dgvemp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.combo_type_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 106);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "بحث";
            // 
            // combo_type_search
            // 
            this.combo_type_search.FormattingEnabled = true;
            this.combo_type_search.Location = new System.Drawing.Point(516, 28);
            this.combo_type_search.Name = "combo_type_search";
            this.combo_type_search.Size = new System.Drawing.Size(315, 31);
            this.combo_type_search.TabIndex = 2;
            this.combo_type_search.SelectedIndexChanged += new System.EventHandler(this.combo_type_search_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "فرز البيانات";
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(38, 26);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(281, 30);
            this.text_search.TabIndex = 0;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
            // 
            // Emp_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvemp);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Emp_info";
            this.Text = "Emp_info";
            this.Load += new System.EventHandler(this.Emp_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvemp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_type_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_search;
    }
}