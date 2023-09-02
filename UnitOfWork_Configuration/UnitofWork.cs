using School_Api_Project.Repository.Interfaces;
using School_Api_Project.DbContextDirectory;
using School_Api_Project.UnitOfWork_Configuration.Interface;

namespace School_Api_Project.UnitOfWork_Configuration.UnitOfWorkImplementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MTSchool_DbContext _context;        

        public IStudentRepository Students { get; }
        public IStaffRepository Staff { get; }

        public UnitOfWork(MTSchool_DbContext mtSchool_DbContext, IStudentRepository studentsRepository, IStaffRepository staffRepository)
        {
            //DbContext Dependency
            this._context = mtSchool_DbContext;


            this.Students = studentsRepository;
            this.Staff = staffRepository;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}