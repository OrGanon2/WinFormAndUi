using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLB.db
{
    public class MyDB
    {
        public static List<Student> StudentList { get; set; } = new List<Student>();
        public static List<Course> CourseList { get; set; } = new List<Course>() { new Course("HTML",5000), new Course(".netBasic",4000) , new Course("CSS",4500), new Course("core",6000), new Course("OOP",5200) };
       
    }
}
