using Checking_Date;
using Employeement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Form
{
    public partial class Form_Info : Form
    {
        public Form_Info()
        {
            InitializeComponent();
        }

        private void bt_SInfo_Click(object sender, EventArgs e)
        {
            double rate = double.Parse(txt_Rate.Text);
            Employee employee = null;

            // Lấy thông tin ngày sinh
            int day = int.Parse(txt_Day.Text);
            int month = int.Parse(txt_Month.Text);
            int year = int.Parse(txt_Year.Text);
            Date dob = new Date(day, month, year);

            // Tạo đối tượng Employee dựa trên rate
            if (rate == 1) employee = new Boss(1, txt_Name.Text, new Salary(dob, 1), dob);
            else if (rate == 0.8) employee = new HourlyWorker(2, txt_Name.Text, new Salary(dob, 0.8m), dob);
            else if (rate == 0.5) employee = new CommisionWorker(3, txt_Name.Text, new Salary(dob, 0.5m), dob);



            // Hiển thị thông tin của employee
            MessageBox.Show(employee.ToString()); // Sử dụng phương thức GetDetails để hiển thị thông tin đầy đủ
        }

        private void btn_GotoShop_Click(object sender, EventArgs e)
        {
            ShopForm form_Shop = new ShopForm();
            form_Shop.ShowDialog();

        }
    }
}
