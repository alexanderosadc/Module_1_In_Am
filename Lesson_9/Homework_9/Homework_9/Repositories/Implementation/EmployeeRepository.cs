using Homework_9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    public class EmployeeRepository : EfRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository() : base() { }
        public string GetJobPosition(int id)
        {
            foreach (var item in listOfEntities)
            {
                if(item.Id == id)
                {
                    return item.JobPosition;
                }
            }
            return null;
        }

        public string GetJobPosition(string firstName)
        {
            foreach (var item in listOfEntities)
            {
                if(item.FirstName == firstName)
                {
                    return item.JobPosition;
                }
            }
            return null;
        }
    }
}
