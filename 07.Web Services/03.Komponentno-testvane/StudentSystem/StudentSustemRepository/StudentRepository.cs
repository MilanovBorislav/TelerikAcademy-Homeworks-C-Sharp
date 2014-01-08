using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StudentSystemDomainClasses;




namespace StudentSustemRepository
{
    public class StudentRepository : IRepository<Student>
    {

        public DbContext _dbContext { get; private set; }
        public DbSet<Student> _entitySet;

        public StudentRepository(DbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentException("An instance of DbContext is required to use this repository.", "dbContext");
            }

            this._dbContext = dbContext;
            this._entitySet = this._dbContext.Set<Student>();
        }

        public Student Add(Student entity)
        {
            _dbContext.Set<Student>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public Student Update(int id, Student entity)
        {
            entity.StudentId = id;
            var item = _dbContext.Set<Student>().Find(id);
            _dbContext.Entry(item).CurrentValues.SetValues(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            Student student = _dbContext.Set<Student>().Find(id);
            _dbContext.Set<Student>().Remove(student);
            _dbContext.SaveChanges();
        }

        public Student Get(int id)
        {
            Student student = _dbContext.Set<Student>().Find(id);
            return student;
        }

        public IQueryable<Student> All()
        {
            return this._entitySet;
        }

        public IEnumerable<Student> GetStudentsWithMarkGreaterThan(string subject, int value)
        {
            var found =
                (from st in _entitySet
                    from m in st.Marks
                    where m.Value >= value
                    where m.Subject == subject
                    select st).ToList();

            return found;
        } 


        public IQueryable<Student> Find(Expression<Func<Student, int, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
