﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Workers
{
    class Master
    {
        public Master()
        {
            StudentsList = new List<Student>();
            WorkersList = new List<Workers>();
        }

        private List<Student> StudentsList { get; }
        private List<Workers> WorkersList { get; }

        public void AddStudent(Student student)
        {
            this.StudentsList.Add(student);
            
        }

        public void AddWorker(Workers worker)
        {
            this.WorkersList.Add(worker);
        }


        public void SortStudentsByGrade()
        {
            List<Student> sortedListStudentsByGrade =
       StudentsList.OrderBy(stud => stud.Grade).ToList();  // order list using Orderby();
            foreach (var student in sortedListStudentsByGrade)     
            {
                student.Print();
            }
        }


        public void SortStudentsByGradeDescending()
        {
            List<Student> descendingSortedListStudentsByGrade = StudentsList.OrderByDescending(stud => stud.Grade).ToList();
            foreach (var student in descendingSortedListStudentsByGrade)
            {
                student.Print();
            }
        }

        public void SortWorkerssByMoneyPerHour()
        {
            List<Workers> sortedListWorkers = WorkersList.OrderBy(worker => worker.MoneyPerHour()).ToList();

            foreach(var worker in sortedListWorkers)
            {
                worker.Print();
            }
        }

        public void SortWorkersByMoneyPerHourDescending()
        {
            List<Workers> descendingSortedListWorkersByMoneyPerHour = WorkersList.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            foreach (var worker in descendingSortedListWorkersByMoneyPerHour)
            {
                worker.Print();
            }
        }

        public void CreateStudent(Student st1)
        {

            Console.WriteLine("Please insert Student First Name:");
            string studentfirstName = Console.ReadLine();
            Console.WriteLine("Please insert Student Last Name:");   ///Second aproach : insert datas in the console
            string studentlastName = Console.ReadLine();
            Console.WriteLine("Please insert Student Grade:");
            int studentgrade = Convert.ToInt32(Console.ReadLine());
            st1.FirstName = studentfirstName;
            st1.LastName = studentlastName;
            st1.Grade = studentgrade;
            StudentsList.Add(st1);

            

        }

        public void PrintStudent()
        {
            foreach (var student in StudentsList)
            {
                student.Print();
            }
        }


        public void List()
        {
            var MasterList = new List<Human>(StudentsList.Count + WorkersList.Count);
            MasterList.AddRange(StudentsList);
            MasterList.AddRange(WorkersList);
            foreach (var human in MasterList)
            {
                Console.WriteLine($"First Name :{human.FirstName}, Last Name:{human.LastName}");
            }
            
        }
        
    }




}
    

