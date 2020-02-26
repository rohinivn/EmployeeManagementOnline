using System;
using System.Collections.Generic;
using EmployeeManagementOnline.Entity;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementOnline.Repository
{
    class AccountRepository
    {
        public static List<Account> accounts = new List<Account>();
        static AccountRepository()
        {
            accounts.Add(new Account("rohini", "rohini@gmail.com", "Roh1ni12", "female", "tamil", "UG", "268 A", "coimabatore", "tamilnadu", 9896543211, 765432));
        }

    }
}
