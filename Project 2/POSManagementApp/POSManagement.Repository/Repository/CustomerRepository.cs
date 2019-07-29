using POSManagementApp.DatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSManagement.Repository.Repository
{
    public class CustomerRepository
    {
        SBMSystemDb db;
        public CustomerRepository()
        {
            db = new SBMSystemDb();
        }
    }
}
