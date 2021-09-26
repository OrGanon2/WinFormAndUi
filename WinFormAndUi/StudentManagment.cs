using MLB.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAndUi
{
    public partial class StudentManagment : UserControl
    {
        public StudentManagment()
        {
            InitializeComponent();
            foreach (var item in MyDB.CourseList)
            {
                CourseManagment.Items.Add(item.CourseName);
            }
        }


        private void StudentManagment_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            MyDB.StudentList.Add(new Student(IDtext.Text, firstnametextbox.Text, LastNameBox.Text, DateOFbirthPicker.Value.Date, PhoneNumberBox.Text, EmailBox.Text, CityCombo.Text, Convert.ToInt32(PaymentCostBox.Text), Convert.ToInt32(PaymentPaidBox.Text)));
            foreach (var item in CourseManagment.CheckedItems)
            {
                foreach (var CourseCheck in MyDB.CourseList)
                {
                    if (item.ToString() == CourseCheck.CourseName)
                    {
                        MyDB.StudentList[MyDB.StudentList.Count - 1].CourseAttendent.Add(CourseCheck);
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CityCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CourseManagment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = 0;
            foreach (var Prices in CourseManagment.CheckedItems)
            {
                foreach (var item in MyDB.CourseList)
                {
                    if (Prices.ToString() ==item.CourseName)
                    {
                        price += Convert.ToInt32(item.PriceOfCourse);
                    }
                }
            }
            PaymentCostBox.Text = price.ToString();
        }

        private void PaymentCostBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
