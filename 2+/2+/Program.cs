using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Collections
{
    public class Department
    {
        public string name;
        public int number;
        public string director;
    }
    public class Worker
    {
        public string Name;
        public string surname;
        public string patronymic;
        public int age;
        public Department dep = new Department();
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker { Name = "Oleg", surname = "Olegov", patronymic = "Olegovich", age = 19, dep = { name = "HR", director = "Vladimir", number = 1 } });
            workers.Add(new Worker { Name = "petr", surname = "Petrov", patronymic = "Petrovich", age = 34, dep = { name = "Tasks", director = "Nikita", number = 2 } });

            var grouped = from Employee in workers
                                group Employee by Employee.dep.name;
            Dictionary<string, IGrouping<string, Worker>> dictionary =
            grouped.ToDictionary(d => d.Key);

        }
    }

}
