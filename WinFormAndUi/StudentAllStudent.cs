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
    public partial class StudentAllStudent : UserControl
    {
        public StudentAllStudent()
        {
            InitializeComponent();
            dataGridView2.DataSource = MyDB.StudentList;
        }
    }
}
