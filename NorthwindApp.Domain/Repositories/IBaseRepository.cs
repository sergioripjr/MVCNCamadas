using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;

namespace NorthwindApp.Domain.Repositories
{
    public interface IBaseRepository<T> where T : EntityObject, IEntityWithId
    {
        T GetById(int id);
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
