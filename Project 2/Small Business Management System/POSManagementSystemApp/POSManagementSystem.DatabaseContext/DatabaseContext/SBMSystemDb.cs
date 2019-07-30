using POSManagementSystem.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSManagementSystem.DatabaseContext.DatabaseContext
{
    public class SBMSystemDb:DbContext
    {
        DbSet<Customer> Customers { get; set; }
    }
}
