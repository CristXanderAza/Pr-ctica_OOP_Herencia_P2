using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Herencia_P2.Parte_1.Domain
{
    public class Group
    {   
        public string Id { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public Group(string id)
        {
            Id = id;
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public bool RemoveStudent(int id)
        {
            Student s = Students.Where(Student => Student.Id == id).FirstOrDefault();
            if(s != null)
            {
                Students.Remove(s);
                return true;
            }
            return false;
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public bool RemoveTeacher(int id)
        {
            Teacher t = Teachers.Where(t => t.Id == id).FirstOrDefault();
            if (t != null)
            {
                Teachers.Remove(t);
                return true;
            }
            return false;
        }
    }
}
