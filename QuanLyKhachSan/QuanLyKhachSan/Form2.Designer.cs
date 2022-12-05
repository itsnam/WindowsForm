namespace QuanLyKhachSan
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.txtdb = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết nối ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sever";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mật khẩu";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(94, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Chứng thực bằng Windows";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(110, 250);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(198, 66);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(224, 22);
            this.txtserver.TabIndex = 7;
            this.txtserver.TextChanged += new System.EventHandler(this.txtserver_TextChanged);
            // 
            // txtdb
            // 
            this.txtdb.Location = new System.Drawing.Point(198, 103);
            this.txtdb.Name = "txtdb";
            this.txtdb.Size = new System.Drawing.Size(224, 22);
            this.txtdb.TabIndex = 8;
            // 
            // txtuid
            // 
            this.txtuid.Location = new System.Drawing.Point(198, 145);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(224, 22);
            this.txtuid.TabIndex = 9;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(198, 178);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(224, 22);
            this.txtpwd.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Về đăng nhập";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 326);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.txtdb);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.TextBox txtdb;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button btnCancel;
    }
}