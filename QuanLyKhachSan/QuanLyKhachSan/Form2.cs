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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtuid.Enabled = false;
                txtpwd.Enabled = false;
            }
            else
            {
                txtuid.Enabled = true;
                txtpwd.Enabled = true;
                txtserver.Focus();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionstring = "";
            if (checkBox1.Checked == true)
            {
                connectionstring = "server=" + txtserver.Text;
                connectionstring += ";database=" + txtdb.Text;
                connectionstring += ";integrated security=true";
            }
            else
            {
                connectionstring = "server=" + txtserver.Text;
                connectionstring += ";database=" + txtdb.Text;
                connectionstring += ";uid=" + txtuid.Text;
                connectionstring += ";pwd=" + txtpwd.Text;
            }
            File.WriteAllText("connectiondatabase.txt", connectionstring);
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void txtserver_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
