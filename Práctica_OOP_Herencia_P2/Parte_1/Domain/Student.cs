using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Herencia_P2.Parte_1.Domain
{
    public class Student : Person
    {
        private static int _count;

        public Student(string firstName, string lastName) : base(_count, firstName, lastName)
        {
            _count++;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
