using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            signin();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void txtpass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin();
            }
        }

        private void signin() {
            string a = File.ReadAllText("connectiondatabase.txt");
            SqlConnection conn = new SqlConnection(@a);
            try
            {
                conn.Open();
                string sql = "select * from Account where username='" + txtUser.Text + "' and password='" + txtPass.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    FormEmployee f = new FormEmployee();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
