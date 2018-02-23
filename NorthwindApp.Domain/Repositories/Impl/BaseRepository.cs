using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;

namespace NorthwindApp.Domain.Repositories.Impl
{
    public abstract class BaseRepository<T> : 
        IBaseRepository<T> where T : EntityObject, IEntityWithId
    {

        public BaseRepository(NorthwindEntities context)
        {
            _context = context;
        }

        protected NorthwindEntities _context;

        protected abstract string TableName { get; }

        protected abstract string EntitySetName { get; }


        #region IBaseRepository<T> Members

        public virtual T GetById(int id)
        {
            var entity = (from e in _context.CreateQuery<T>(this.TableName)
                          where e.Identificador == id
                          select e).FirstOrDefault();
            return entity;                         
        }

        public virtual List<T> GetAll()
        {
            var entities = from e in _context.CreateQuery<T>(this.TableName)
                           select e;
            var listToReturn = entities.ToList();
            return listToReturn;                         
        }

        public virtual void Create(T entity)
        {
            _context.AddObject(this.EntitySetName, entity);
            _context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            _context.Update(this.EntitySetName, entity);
            _context.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var entity = this.GetById(id);
            _context.DeleteObject(entity);
            _context.SaveChanges();
        }

        #endregion
    }
}
