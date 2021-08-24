using Homework_9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        void Update(T entity, T newEntity);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
