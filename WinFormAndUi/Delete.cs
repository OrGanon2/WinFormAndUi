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
    public partial class Delete : UserControl
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool studentID = false;
            foreach (var item in MyDB.StudentList)  
            {
                if (item.Id == textBox1.Text)
                {
                    propertyGrid1.SelectedObject = item;
                    studentID = true;
                    break;
                }
            }
            if (!studentID)
            {
                MessageBox.Show("student not found");
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (var item in MyDB.StudentList)
            {
                if (item.Id == textBox1.Text)
                {
                    MyDB.StudentList.Remove(item);
                    break;
                }
            }
            propertyGrid1.SelectedObject = null;
            MessageBox.Show("student Deleted");
        }
    }
}
