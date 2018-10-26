using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University("CH.U.I.");
            university.AddStudents(mockStudent());

            Internship internship = new Internship("Interlink");
            internship.setStudents(university.getSmartStudents());

            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }

        public static List<Student> mockStudent() {
            Knowledge level1 = new Knowledge(1);
            Knowledge level2 = new Knowledge(2);
            Knowledge level3 = new Knowledge(3);
            Knowledge level4 = new Knowledge(4);
            Knowledge level5 = new Knowledge(5);

            List<Student> students = new List<Student>();
    
            students.Add(new Student("Andrew Kostenko", level3));
            students.Add(new Student("Julia Veselkina", level4));
            students.Add(new Student("Maria Perechrest", level1));
            students.Add(new Student("Alex", level5));
            
            return students;
        }
    }
}
