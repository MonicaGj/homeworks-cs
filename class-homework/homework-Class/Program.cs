using System;
using System.Collections.Generic;
using System.Linq;

namespace homework_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Monika", "Gjorgjieska", 24, Gender.Female, 1, "G1", "SEDC");
            Student student2 = new Student("Marko", "Markovski", 25, Gender.Male, 2, "G6", "SEDC");
            Student student3 = new Student("Jovan", "Ivanovski", 30, Gender.Male, 3, "G1", "SEDC");
            Student student4 = new Student("Ivan", "Jakimov", 24, Gender.Male, 4, "G3", "SEDC");
            Student student5 = new Student("Aleksandar", "Toshev", 21, Gender.Male, 5, "G1", "SEDC");
            Student student6 = new Student("Jovan", "Jovanov", 24, Gender.Male, 6, "G1", "SEDC");
            Student student7 = new Student("Meriem", "Mustakovska", 29, Gender.Female, 7, "G4", "SEDC");
            Student student8 = new Student("Sinisha", "Stojanov", 22, Gender.Male, 8, "G1", "SEDC");
            Student student9 = new Student("Monika", "Avramovska", 34, Gender.Female, 9, "G1", "SEDC");
            Student student10 = new Student("Kiril", "Shtrievic", 24, Gender.Male, 10, "G3", "SEDC");
            Student student11 = new Student("Aleks", "Zenov", 29, Gender.Male, 11, "G1", "SEDC");
            Student student12 = new Student("Antonija", "Trajanova", 26, Gender.Female, 12, "G1", "SEDC");
            Student student13 = new Student("Viktorija", "Demirova", 21, Gender.Female, 13, "G1", "SEDC");
            Student student14 = new Student("Hristina", "Ivanoska", 24, Gender.Female, 14, "G1", "SEDC");
            Student student15 = new Student("Stiven", "Dokovski", 27, Gender.Male, 15, "G4", "SEDC");
            Student student16 = new Student("Kiril", "Serafimov", 33, Gender.Male, 16, "G1", "SEDC");
            Student student17 = new Student("Joakim", "Jo", 20, Gender.Male, 17, "G1", "SEDC");
            Student student18 = new Student("Mihail", "Gjorgjieski", 23, Gender.Male, 18, "G5", "SEDC");
            Student student19 = new Student("Ivana", "Todorova", 25, Gender.Female, 19, "G1", "SEDC");
            Student student20 = new Student("Marija", "Milenkovska", 27, Gender.Female, 20, "G6", "SEDC");

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);
            students.Add(student7);
            students.Add(student8);
            students.Add(student9);
            students.Add(student10);
            students.Add(student11);
            students.Add(student12);
            students.Add(student13);
            students.Add(student14);
            students.Add(student15);
            students.Add(student16);
            students.Add(student17);
            students.Add(student18);
            students.Add(student19);
            students.Add(student20);

            var females = students.Where(x => x.Gender.ToString() == "Female");
            Console.WriteLine("Females:");
            foreach (var item in females)
            {               
                item.GetInfo();
            }

            var males = students.Where(x => x.Gender.ToString() == "Male");
            Console.WriteLine("Males:");
            foreach (var item in males)
            {               
                item.GetInfo();
            }


            Console.WriteLine("Students filtered by name");
            Console.WriteLine("Insert letter");
            string letter = Console.ReadLine().ToUpper();
            var filterByFirstLetter = students.Where(x => x.FirstName.ToString().StartsWith(letter));
            foreach (var item in filterByFirstLetter)
            {
                item.GetInfo();
            }


            Console.WriteLine("Students filtered by group");
            Console.WriteLine("Choose G1,G2,G3,G4,G5 or G6");
            string group = Console.ReadLine().ToUpper();
            var filterByGroup = students.Where(x => x.Group.ToString() == group);
            foreach (var item in filterByGroup)
            {
                item.GetInfo();
            }


            Console.WriteLine("Students fitered by id");
            Console.WriteLine("Insert number between 1 and 20");
            string id = Console.ReadLine();
            int idToNum = int.Parse(id);
            var filteredById = students.Where(x => x.Id == idToNum);
            foreach (var item in filteredById)
            {
                item.GetInfo();
            }

        }
    }
}
