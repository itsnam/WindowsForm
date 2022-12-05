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
    public partial class FormEmployee : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string s = File.ReadAllText("connectiondatabase.txt");
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Employee";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(s);
            connection.Open();
            loaddata();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Employee values('" + txtID.Text + "', N'" + txtName.Text + "', '" + dtbd.Text + "', N'" + txtCV.Text + "' , " + txtSalary.Text + ")";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            txtID.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtCV.Text = dgv.Rows[i].Cells[3].Value.ToString();
            dtbd.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtSalary.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Employee where ID = '" + txtID.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Employee set SName = N'" + txtName.Text + "', bd = '" + dtbd.Text + "', CV = N'" +txtCV.Text +"', Luong="+txtSalary.Text + "where ID = '" + txtID.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print f = new Print(txtID.Text, txtName.Text, dtbd.Text, txtCV.Text, txtSalary.Text);
            f.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtCV.Text = "";
            txtSalary.Text = "";
        }
    }
}
