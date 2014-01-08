using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using StudentSystemDomainClasses;

namespace StudentSustemRepository
{
    public class SchoolRepository : IRepository<School>
    {

        public DbContext _dbContext { get; private set; }
        public DbSet<School> _entitySet;

        public SchoolRepository(DbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentException("An instance of DbContext is required to use this repository.", "dbContext");
            }

            this._dbContext = dbContext;
            this._entitySet = this._dbContext.Set<School>();
        }


        public School Add(School entity)
        {
            _dbContext.Set<School>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public School Update(int id, School entity)
        {
            entity.SchoolId = id;
            var item = _dbContext.Set<School>().Find(id);
            _dbContext.Entry(item).CurrentValues.SetValues(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            School school = _dbContext.Set<School>().Find(id);

            _dbContext.Set<School>().Remove(school);
            _dbContext.SaveChanges(); 
        }

        public School Get(int id)
        {
            School school = _dbContext.Set<School>().Find(id);
            return school;
        }

        public IQueryable<School> All()
        {
            return _entitySet;
        }

        public IQueryable<School> Find(Expression<Func<School, int, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}