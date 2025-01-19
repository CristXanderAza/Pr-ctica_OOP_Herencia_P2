using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Herencia_P2.Parte_1.Domain
{
    public class Teacher : Person
    {
        private List<Subject> _subjects;
        private static int _count;

        public Teacher( string firstName, string lastName) : base(_count, firstName, lastName)
        {
            _count++;
            _subjects = new List<Subject>(); 
        }

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }

        public bool RemoveSubject(string codeSubject)
        {
            var s = _subjects.Where(s => s.Code.Equals(codeSubject)).FirstOrDefault();
            if (s != null)
            {
                _subjects.Remove(s);
                return true;
            }
            return false;
        }

        public bool IncrementExercisesInSubject(string codeSubject,  int increment)
        {
            var s = _subjects.Where(s => s.Code.Equals(codeSubject)).FirstOrDefault();
            if(s != null)
            {
                s.IncrementExercises(increment);
                return true;
            }
            return false;
            
        }
        public bool IncrementClassCountInSubject(string codeSubject)
        {
            var s = _subjects.Where(s => s.Code.Equals(codeSubject)).FirstOrDefault();
            if (s != null)
            {
                s.AddClassCount();
                return true;
            }
            return false;

        }

        public override string ToString()
        {
            string s = "";
            foreach (var subject in _subjects)
            {
                s += "          " + subject.ToString() + "\n";
            }

            return $"    Profesor: {FirstName} {LastName}" + "\n" + s;
        }


    }
}
