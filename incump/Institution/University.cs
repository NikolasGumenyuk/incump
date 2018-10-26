using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        public string name;
        public List<Student> students = new List<Student>();
        public double avarageKnowledgeLevel = 0;
        public University(string name)
        {
            this.name = name;
        }
        public void AddStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                this.students.Add(student);
                this.avarageKnowledgeLevel = (this.avarageKnowledgeLevel + student.knowledge.level) / 2;
            }
        }

        public List<Student> getSmartStudents() {
            return this.students.FindAll(student => student.knowledge.level > this.avarageKnowledgeLevel);
        }
    }
}
