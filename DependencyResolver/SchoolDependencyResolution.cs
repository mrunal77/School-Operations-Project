using School_Api_Project.ApplicationServices;
using School_Api_Project.ApplicationServices.Implementations;
using School_Api_Project.Repository.Interfaces;
using School_Api_Project.UnitOfWork_Configuration.Interface;
using School_Api_Project.UnitOfWork_Configuration.UnitOfWorkImplementation;

namespace School_Api_Project.Repository
{
    public static class SchoolDependencyResolution
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            #region Repository Mapping
            //
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IStaffRepository, StaffRepository>();
            services.AddTransient<IStudentClassRepository, StudentClassRepository>();
            #endregion

            #region ApplicationServices Mapping
            services.AddTransient<IStudentAdmissionProcess, StudentAdmissionProcess>();

            #endregion

            //Unit of Work Dependency
            services.AddTransient<IUnitOfWork, UnitOfWork>(); 
            return services;
        }
    }
}