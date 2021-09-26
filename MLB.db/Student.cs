using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLB.db
{
    public class Student 
    {
        public Student(string id, string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, string email, string city, int paymentCost, int paymentPaid)
        {
            //CourseAttendent = courseAttendent;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            City = city;
            PaymentCost = paymentCost;
            PaymentPaid = paymentPaid;

            
        }

        public List<Course> CourseAttendent { get; set; } = new List<Course>();

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public  string City { get; set; }
        public int PaymentCost { get; set; }
        public int PaymentPaid { get; set; }

    }
}
