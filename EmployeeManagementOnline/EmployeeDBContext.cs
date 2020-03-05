using EmployeeManagementOnline.Models;
using EmployeeManagementOnline.Entity;
using System.Data.Entity;

namespace EmployeeManagementOnline
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Account> Accounts { get; set; }
        //public DbSet<SignUpViewModel> SignUpViews { get; set; }
    }
}