using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            var HumanList = new Master();
            var listStudents = new Master();

            
            listStudents.AddStudent(new Student("Mihai", "Irimia", 9));
            listStudents.AddStudent(new Student("Bogdan", "Popoi", 8));
            listStudents.AddStudent(new Student("Alexandru", "Ioan", 10));
            listStudents.AddStudent(new Student("Andrada", "Popescu", 9));
            listStudents.AddStudent(new Student("Mihaela", "Ionescu", 6));
            listStudents.AddStudent(new Student("Loredana", "Spiridon", 5));
            listStudents.AddStudent(new Student("Daniela", "Guzga", 7));
            listStudents.AddStudent(new Student("George", "Bucatariu", 8));
            listStudents.AddStudent(new Student("Dorian", "Pricop", 9));
            listStudents.AddStudent(new Student("Paul", "Ionesti", 10));

            //listStudents.SortStudentsByGradeDescending();
            //listStudents.SortStudentsByGradeDescending();
            
            var listWorkers = new  Master();
            listWorkers.AddWorker(new Workers("Mihai", "Irimia", 1000, 8));
            listWorkers.AddWorker(new Workers("Bogdan", "Popoi", 1100, 6));
            listWorkers.AddWorker(new Workers("Alexandru", "Ioan", 1200, 5));
            listWorkers.AddWorker(new Workers("Andrada", "Popescu", 1300, 7));
            listWorkers.AddWorker(new Workers("Mihaela", "Ionescu", 1400, 8));
            listWorkers.AddWorker(new Workers("Loredana", "Spiridon", 1500, 9));
            listWorkers.AddWorker(new Workers("Daniela", "Guzga", 1600, 8));
            listWorkers.AddWorker(new Workers("George", "Bucatariu", 1700, 8));
            listWorkers.AddWorker(new Workers("Dorian", "Pricop", 1800, 7));
            listWorkers.AddWorker(new Workers("Paul", "Ionesti", 1900, 6));

            //listWorkers.SortWorkerssByMoneyPerHour();
            //listWorkers.SortWorkersByMoneyPerHourDescending();


            

            Console.ReadKey();














            //Student st1 = new Student();
            ////st1.firstName = "Mihai";
            ////st1.lastName = "Irimia";     ///First Aproact : insert datas manualy
            ////st1.Grade = 4;
            ////st1.Print();
            ////CreateStudent(st1);


            //Workers w1 = new Workers();
            //CreateWorker(w1);


            //st1.Print();
            //w1.Print();
            //Console.ReadKey();

        }

        //private static void CreateStudent(Student st1)
        //{
        //    Console.WriteLine("Please insert Student First Name:");
        //    string studentfirstName = Console.ReadLine();
        //    Console.WriteLine("Please insert Student Last Name:");   ///Second aproach : insert datas in the console
        //    string studentlastName = Console.ReadLine();
        //    Console.WriteLine("Please insert Student Grade:");
        //    int studentgrade = Convert.ToInt32(Console.ReadLine());
        //    st1.FirstName = studentfirstName;
        //    st1.LastName = studentlastName;
        //    st1.Grade = studentgrade;
        //}

        //    private static void CreateWorker(Workers w1)
        //    {
        //        Console.WriteLine("Please insert Worker First Name:");
        //        string workerfirstName = Console.ReadLine();
        //        Console.WriteLine("Please insert Worker Last Name:");   ///Second aproach : insert datas in the console
        //        string workerlastName = Console.ReadLine();
        //        Console.WriteLine("Please insert Worker Week Salary:");
        //        double workerWeekSalary = Convert.ToDouble(Console.ReadLine());
        //        Console.WriteLine("Please insert Worker Work Hours Per Day:");
        //        double workerWorkHoursPerDay = Convert.ToDouble(Console.ReadLine());
        //        w1.FirstName = workerfirstName;
        //        w1.LastName = workerlastName;
        //        w1.WeekSalary = workerWeekSalary;
        //        w1.WorkHoursPerDay = workerWorkHoursPerDay;
        //    }
        //}
    }
}
