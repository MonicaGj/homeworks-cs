using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_Class
{
    class Student:Person
    {
        public int Id { get; set; }
        public string Group { get; set; }
        public string Course { get; set; }

        public Student(string firstName, string lastName, int age, Gender gender, int id, string group, string course)
            :base( firstName,  lastName,  age, gender)
        {
            this.Id = id;
            this.Group = group;
            this.Course = course;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"First Name:{FirstName}, Last Name:{LastName}, Age:{Age}, Gender:{Gender}, ID:{Id}, Group:{Group}");
        }
    }
}
