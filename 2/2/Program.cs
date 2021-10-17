using System;

using System.Collections.Generic;

using System.Linq;

namespace _2
{
    class Department
    {
        public string departmentname;
        public int number;
        public string leader;
    }
    
    class Worker
    {
        public string lastname;
        public string name;
        public string patronymic;
        public int age;
        public int number;
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>(2);
            departments.Add(new Department() { departmentname = "Первый отдел" , number = 1 , leader = "Иванов" });
            departments.Add(new Department() { departmentname = "Второй отдел", number = 2, leader = "Петров" });
             

            List<Worker> workers = new List<Worker>(4);
            workers.Add(new Worker() { name = "Ivan", lastname = "Ivanov", patronymic = "Ivanovich", number = 1});
            workers.Add(new Worker() { name = "David", lastname = "Davidov", patronymic = "Davidovich", number = 2 });
            workers.Add(new Worker() { name = "Olga", lastname = "Davidova", patronymic = "Davidovna", number = 1 });
            workers.Add(new Worker() { name = "Ben", lastname = "Piroshkov", patronymic = "Aleksandrovich", number = 2 });


            Dictionary<string, List<Worker>> dicti = new Dictionary<string, List<Worker>>();
            
            foreach (Department d in departments)
            {
                var selectedWorkers = from w in workers 
                                           where w.number == d.number 
                                           orderby w.name  
                                         select w;
                //  }
                //List<Worker> works = workers.Select(i => i.number.Equals(d.number)).ToList();

               /* foreach (var q in selectedWorkers)
                {
                    Console.WriteLine(q.name);
                }
                Console.WriteLine("---------");*/
                
                dicti.Add(d.departmentname, selectedWorkers.ToList());
  
            }

           /* foreach (var k in dicti)
            {
                Console.WriteLine(k.Key + ":");
                foreach (var v in dicti.Values)
                 {
                    for (int i = 0; i<v.Count; i++)  Console.WriteLine(v[i].name);
                 }
            }*/






        }
    }
}
