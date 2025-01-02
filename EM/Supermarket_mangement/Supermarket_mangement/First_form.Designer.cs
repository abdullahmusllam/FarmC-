namespace Supermarket_mangement
{
    partial class First_form
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
            this.btn_add_qurey = new System.Windows.Forms.Button();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_qurey
            // 
            this.btn_add_qurey.BackColor = System.Drawing.Color.Green;
            this.btn_add_qurey.FlatAppearance.BorderSize = 0;
            this.btn_add_qurey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_qurey.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_qurey.ForeColor = System.Drawing.Color.White;
            this.btn_add_qurey.Location = new System.Drawing.Point(160, 58);
            this.btn_add_qurey.Name = "btn_add_qurey";
            this.btn_add_qurey.Size = new System.Drawing.Size(255, 46);
            this.btn_add_qurey.TabIndex = 0;
            this.btn_add_qurey.Text = "إضافة الاوامر";
            this.btn_add_qurey.UseVisualStyleBackColor = false;
            this.btn_add_qurey.Click += new System.EventHandler(this.btn_add_qurey_Click);
            // 
            // btn_add_user
            // 
            this.btn_add_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_add_user.FlatAppearance.BorderSize = 0;
            this.btn_add_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_user.ForeColor = System.Drawing.Color.White;
            this.btn_add_user.Location = new System.Drawing.Point(160, 156);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(255, 46);
            this.btn_add_user.TabIndex = 0;
            this.btn_add_user.Text = "إضافة مستخدمين";
            this.btn_add_user.UseVisualStyleBackColor = false;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(160, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "تسجيل الدخول";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // First_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_add_user);
            this.Controls.Add(this.btn_add_qurey);
            this.Name = "First_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_qurey;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.Button button2;
    }
}