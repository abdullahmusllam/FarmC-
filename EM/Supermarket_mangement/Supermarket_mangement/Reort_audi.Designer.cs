namespace Supermarket_mangement
{
    partial class Reort_audi
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
            this.panel_repoort = new System.Windows.Forms.Panel();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_detaile = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.research = new System.Windows.Forms.TextBox();
            this.dgv_repo = new System.Windows.Forms.DataGridView();
            this.panel_repoort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_repo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_repoort
            // 
            this.panel_repoort.Controls.Add(this.date_end);
            this.panel_repoort.Controls.Add(this.label3);
            this.panel_repoort.Controls.Add(this.date_start);
            this.panel_repoort.Controls.Add(this.label2);
            this.panel_repoort.Controls.Add(this.label1);
            this.panel_repoort.Controls.Add(this.btn_detaile);
            this.panel_repoort.Controls.Add(this.btn_search);
            this.panel_repoort.Controls.Add(this.research);
            this.panel_repoort.Controls.Add(this.dgv_repo);
            this.panel_repoort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_repoort.Location = new System.Drawing.Point(0, 0);
            this.panel_repoort.Name = "panel_repoort";
            this.panel_repoort.Size = new System.Drawing.Size(848, 496);
            this.panel_repoort.TabIndex = 0;
            // 
            // date_end
            // 
            this.date_end.Location = new System.Drawing.Point(474, 246);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(267, 20);
            this.date_end.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(764, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "إلي";
            // 
            // date_start
            // 
            this.date_start.Location = new System.Drawing.Point(474, 182);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(267, 20);
            this.date_start.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(764, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "من";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(764, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الموظف";
            // 
            // btn_detaile
            // 
            this.btn_detaile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_detaile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detaile.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detaile.ForeColor = System.Drawing.Color.White;
            this.btn_detaile.Location = new System.Drawing.Point(448, 333);
            this.btn_detaile.Name = "btn_detaile";
            this.btn_detaile.Size = new System.Drawing.Size(366, 38);
            this.btn_detaile.TabIndex = 2;
            this.btn_detaile.Text = "تفاصيل أكثر";
            this.btn_detaile.UseVisualStyleBackColor = false;
            this.btn_detaile.Click += new System.EventHandler(this.btn_detaile_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Green;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(403, 73);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(103, 38);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // research
            // 
            this.research.Location = new System.Drawing.Point(512, 73);
            this.research.Multiline = true;
            this.research.Name = "research";
            this.research.Size = new System.Drawing.Size(240, 38);
            this.research.TabIndex = 1;
            // 
            // dgv_repo
            // 
            this.dgv_repo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_repo.Location = new System.Drawing.Point(32, 37);
            this.dgv_repo.Name = "dgv_repo";
            this.dgv_repo.Size = new System.Drawing.Size(365, 433);
            this.dgv_repo.TabIndex = 0;
            // 
            // Reort_audi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 496);
            this.Controls.Add(this.panel_repoort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reort_audi";
            this.Text = "Reort_audi";
            this.panel_repoort.ResumeLayout(false);
            this.panel_repoort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_repo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_repo;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_detaile;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox research;
        public System.Windows.Forms.Panel panel_repoort;
    }
}