using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("Mihai", "Ionescu",6),
                new Student("Daniel", "Popescu",4),
                new Student("Danile", "Arimia", 5)
            };

            var workers = new List<Worker>()
            {
                new Worker("Dani", "Popescu",22000,7),
                new Worker("Bogdan", "Popescu",2000,5),
                new Worker("Alexandru", "Popescu",20000,8)
            };

            List<Human> humans = StudentsAndWorkersHelper.MergeLists(students, workers);
            StudentsAndWorkersHelper.PrintHumans(humans);
            Console.WriteLine(Environment.NewLine);
            List<Human> sortedHumanList = StudentsAndWorkersHelper.SortHumanList(humans);
            StudentsAndWorkersHelper.PrintHumans(sortedHumanList);


            //StudentsAndWorkersHelper.PrintStudents(students);
            //Console.WriteLine(Environment.NewLine);
            //StudentsAndWorkersHelper.SortSudents(students);
            //StudentsAndWorkersHelper.PrintStudents(students);



            Console.ReadLine();
        }

      



    }
    }

