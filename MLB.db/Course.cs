using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLB.db
{
    public class Course
    {
        public Course(string courseName,int priceOfCourse)
        {
            CourseName = courseName;
            PriceOfCourse = priceOfCourse;
        }
        public int PriceOfCourse { get; set; }

        public int Id { get; set; }
        public string CourseName { get; set; }
        public DateTime Date { get; set; }
        public int MeetingSessions { get; set; }
        public override string ToString()
        {
            return CourseName;
        }
    }
}
