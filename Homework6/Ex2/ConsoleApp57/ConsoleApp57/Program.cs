using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2

{
    class Program
    {
        static void Main(string[] args)
        {
            Professor prof1 = new Professor();
            prof1.Name = "Dospinescu Ion";
            prof1.Faculty = "Al.I.Cuza";
            prof1.Specialization = "Economics Informatics";
            var prof_print = prof1.Print();
            Console.WriteLine(prof_print);

            Student stud1= new Student();
            stud1.Name = "Mihai Irimia";
            stud1.Faculty = "Al.I.Cuza";
            stud1.Year = 3;
            Console.WriteLine(stud1.Print());

            Student stud2 = new Student
            {
                Name = "Bogdan Popoi",
                Faculty = "Marketing",
                Year = 2
            };
            Console.WriteLine(stud2.Print());

            Student stud3 = new Student();
            stud3.Name = "Bucataraiu Mihai";
            stud3.Faculty = "Management";
            stud3.Year = 3;
            Console.WriteLine(stud3.Print());

            var listOfStudents = new List<Student>();
            listOfStudents.Add(stud1);
            listOfStudents.Add(stud2);
            listOfStudents.Add(stud3);

            Course cours1 = new Course();
            cours1.Name = "Database";
            cours1.Year = 2;
            
            Console.Write(cours1.Print());

            foreach (var elem in listOfStudents)
            {
                Console.Write(elem.Name +",");
            }
            
            Console.ReadKey();


        }
    }
}
