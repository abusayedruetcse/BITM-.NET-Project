using POSManagementSystem.Models.Models;
using POSManagementSystem.DatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSManagementSystem.Repository.Repository
{
    public class CustomerRepository
    {
        SBMSystemDb db;
        Customer _customer;
        public CustomerRepository()
        {
            db = new SBMSystemDb();
        }
        public bool check(Customer customer)
        {
            return true;
        }
    }
}
