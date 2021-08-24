using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    public interface IEmployeeRepository
    {
        public string GetJobPosition(int id);
        public string GetJobPosition(string firstName);
    }
}
