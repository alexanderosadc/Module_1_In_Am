using Homework_9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    public class EfRepository<T> : IRepository<T> where T: Entity
    {
        protected List<T> listOfEntities;

        public EfRepository()
        {
            listOfEntities = new List<T>();
        }
        public void Add(T entity)
        {
            listOfEntities.Add(entity);
        }

        public void Update(T entity, T newEntity)
        {
            foreach (var item in listOfEntities)
            {
                if(entity.Id == item.Id)
                {
                    item.Id = newEntity.Id;
                    item.FirstName = newEntity.FirstName;
                    item.LastName = newEntity.LastName;
                    break;
                }
            }
        }

        public void Delete(T entity)
        {
            listOfEntities.Remove(entity);
        }

        public List<T> GetAll()
        {
            return listOfEntities;
        }

        public T GetById(int id)
        {
            return listOfEntities.FirstOrDefault(e => e.Id == id);
        }

        
    }
}
