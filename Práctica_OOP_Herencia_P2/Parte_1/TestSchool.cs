using Práctica_OOP_Herencia_P2.Parte_1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Herencia_P2.Parte_1
{
    public class TestSchool
    {
        public static void Execute()
        {
            Student student1 = new Student("Cristopher", "Aza");
            Student student2 = new Student("Maria", "Sanchez");

            Subject integral = new Subject("Calculo Integral", "MAT-102");
            Subject diferencial = new Subject("Calculo Diferencial", "MAT-101");
            Subject bigData = new Subject("Big Data", "TDS-212");
            Subject progamacion = new Subject("Programacion II", "TDS-006");

            Teacher francis = new Teacher("Francis", "Ramirez");
            Teacher saul = new Teacher("Saul", "Montero");

            francis.AddSubject(bigData);
            francis.AddSubject(progamacion);
            francis.IncrementExercisesInSubject("TDS-006", 4);
            francis.IncrementExercisesInSubject("TDS-212", 3);
           


            saul.AddSubject(integral);
            saul.AddSubject(diferencial);
            saul.IncrementClassCountInSubject("MAT-102");
            Group primeroBasica = new Group("1ro Basica");
            Group segundoMedia = new Group("2do Media");

            primeroBasica.AddTeacher(saul);
            segundoMedia.AddTeacher(francis);
            primeroBasica.AddStudent(student1);
            segundoMedia.AddStudent(student2);

            showGroupInfo(primeroBasica);
            showGroupInfo(segundoMedia);
        }


        private static void showGroupInfo(Group group)
        {
            Console.WriteLine("____________________________");
            Console.WriteLine($"Group: {group.Id}");
            showStudentsInfor(group.Students);
            showTeacherInfo(group.Teachers);
        }

        private static void showStudentsInfor(IEnumerable<Student> students)
        {
            Console.WriteLine(" Students");
            foreach (var student in students)
            {
                Console.WriteLine("     " + student.ToString());
            }
        }

        private static void showTeacherInfo(IEnumerable<Teacher> teachers)
        {
            Console.WriteLine(" Teachers:");
            foreach(var teacher in teachers)
            {
                Console.WriteLine(teacher.ToString());
            }
        }
    }
}
