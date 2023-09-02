using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School_Api_Project.Repository.Interfaces;
using School_Api_Project.DbContextDirectory;
using School_Api_Project.Entity.Models;


namespace School_Api_Project.Repository
{
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        public StaffRepository(MTSchool_DbContext context) : base(context)
        {

        }
    }
}