using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_Class
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Person(string firstName, string lastName, int age, Gender gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"First Name:{FirstName}, Last Name:{LastName}, Age:{Age}, Gender:{Gender}");
        }
    }
}
