using Homework_9.Entities;
using System;
using System.Collections.Generic;

namespace Homework_9
{
    class Program
    {
        class Developer : Employee 
        { }
        static void Main(string[] args)
        {
            Employee employee1 = new Developer();
            IEnumerable<Employee> list = new List<Developer>();
            /*CollectionOfElements<int?> collection = new CollectionOfElements<int?>();
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                collection[i] = random.Next();
            }
            collection[11] = 5;

            int? indexOfValue = collection.IndexOf(11);
            Console.WriteLine(indexOfValue);*/

            EfRepository<Entity> efRepository = new EfRepository<Entity>();
            Entity entity = new Entity();
            entity.Id = 1;
            entity.FirstName = "Alex";
            entity.LastName = "Osa";

            efRepository.Add(entity);
            efRepository.GetByIndex(0);
            foreach (var item in efRepository.GetAll())
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine(efRepository.GetByIndex(0).FirstName);
            Entity entity1 = new Entity();
            entity1.Id = 2;
            entity1.FirstName = "Vova";
            entity1.LastName = "Leada";
            efRepository.Update(entity, entity1);
            foreach (var item in efRepository.GetAll())
            {
                Console.WriteLine(item.FirstName);
            }

            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee employee = new Employee(); 
            employeeRepository.GetJobPosition(0);
        }
    }
}
