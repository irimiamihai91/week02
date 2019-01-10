using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class StudentsAndWorkersHelper
    {
        
        public static void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                student.Print();
            }
        }

        public static void PrintWorkers(List<Worker> workers)
        {
            foreach (var worker in workers)
            {
                worker.Print();
            }
        }


        public static void SortSudents(List<Student> students)
        {
            Student aux;

            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[i] > students[j])
                    {
                        aux = students[i];
                        students[i] = students[j];
                        students[j] = aux;

                    }
                }
            }
        }
        public static void SortDescendingWorkers(List<Worker> workers)
        {
            Worker aux;

            for (int i = 0; i < workers.Count - 1; i++)
            {
                for (int j = i + 1; j < workers.Count; j++)
                {
                    if (workers[i] < workers[j])
                    {
                        aux = workers[i];
                        workers[i] = workers[j];
                        workers[j] = aux;

                    }
                }
            }
        }

        public static List<Human> MergeLists(List<Student> students, List<Worker> workers)
        {
            var humans = new List<Human>(students);
            humans.AddRange(workers);
            return humans;
        }

        public static void PrintHumans(List<Human> humans)
        {
            foreach (var human in humans)
            {
                Console.WriteLine($"First Name : {human.FirstName}, Last Name {human.LastName}");
            }
        }

        public static List<Human> SortHumanList(List<Human> humans)
        {
            return humans.OrderBy(human => human.FirstName).ToList();
        }

    }

}
    
