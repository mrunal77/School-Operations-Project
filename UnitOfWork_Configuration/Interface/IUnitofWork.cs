using System.Collections.Generic;
using System.Threading.Tasks;
using School_Api_Project.Repository.Interfaces;

namespace School_Api_Project.UnitOfWork_Configuration.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        IStaffRepository Staff { get; }
        int Complete();
    }
}