using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



namespace StudentSustemRepository
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(int id, T entity);
        void Delete(int id);
        T Get(int id);
        IQueryable<T> All();
        IQueryable<T> Find(Expression<Func<T, int, bool>> predicate);
        //void AddMarkToStudent(int id, T entity);
    }
}
