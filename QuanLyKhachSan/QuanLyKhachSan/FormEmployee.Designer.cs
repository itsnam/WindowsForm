namespace QuanLyKhachSan
{
    partial class FormEmployee
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
            this.txtCV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtbd = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(161, 119);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(613, 22);
            this.txtCV.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Lương";
            // 
            // dtbd
            // 
            this.dtbd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbd.Location = new System.Drawing.Point(161, 82);
            this.dtbd.Name = "dtbd";
            this.dtbd.Size = new System.Drawing.Size(613, 22);
            this.dtbd.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(613, 22);
            this.txtName.TabIndex = 25;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(161, 8);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(613, 22);
            this.txtID.TabIndex = 24;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(658, 420);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(116, 23);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(232, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(30, 188);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(744, 209);
            this.dgv.TabIndex = 19;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(161, 153);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(613, 22);
            this.txtSalary.TabIndex = 30;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(524, 420);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 23);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Cài lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtbd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtbd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnReset;
    }
}