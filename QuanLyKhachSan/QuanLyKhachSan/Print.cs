using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Print : Form
    {
        private string ID, Name, Birth, CV, Salary;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string s = "Mã nhân viên: " + ID + "\nTên nhân viên: " + Name + "\nNgày sinh: " + Birth + "\nChức vụ: " + CV + "\nLương: " + Salary;
            File.WriteAllText("in.txt", s);
            MessageBox.Show("Thành Công");
        }

        public Print()
        {
            InitializeComponent();
        }

        public Print(string ID, string Name, string Birth, string CV, string Salary)
        {
            InitializeComponent();
            this.ID = ID;
            this.Name = Name;
            this.Birth = Birth;
            this.CV = CV;
            this.Salary = Salary;
        }

        private void Print_Load(object sender, EventArgs e)
        {
            label6.Text = ID;
            label7.Text = Name;
            label8.Text = Birth;
            label9.Text = CV;
            label10.Text = Salary;
        }
    }
}
