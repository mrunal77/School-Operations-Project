using School_Api_Project.Repository.Interfaces;
using School_Api_Project.UnitOfWork_Configuration.Interface;
using School_Api_Project.UnitOfWork_Configuration.UnitOfWorkImplementation;

namespace School_Api_Project.Repository
{
    public static class SchoolDependencyResolution
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IStaffRepository, StaffRepository>();

            //Unit of Work Dependency
            services.AddTransient<IUnitOfWork, UnitOfWork>(); 
            return services;
        }
    }
}