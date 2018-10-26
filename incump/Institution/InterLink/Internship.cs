using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string name;
        public List<Student> students;
        public Internship(string name)
        {
            this.name = name; 
        }

        public void setStudents(List<Student> students) {
            this.students = students;
        }
        public string GetStudents()
        {
            string result = "";
            foreach (Student student in this.students)
            {
                result += student.name + "\n";
            }
            return result;
        }
    }
}
