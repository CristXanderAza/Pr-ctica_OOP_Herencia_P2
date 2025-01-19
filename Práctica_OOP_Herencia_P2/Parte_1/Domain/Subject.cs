using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Herencia_P2.Parte_1.Domain
{
    public class Subject
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int ClassesCount { get; set; }
        public int ExercisesCount { get; set; }

        public Subject(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public void IncrementExercises(int count)
        {
            ExercisesCount += count;
        }
        public void AddClassCount()
        {
            ClassesCount++;
        }

        public override string ToString()
        {
            return $"{Name} ({Code}), Clases Count: {ClassesCount}, ExercisesCount: {ExercisesCount}";
        }
    }
}
