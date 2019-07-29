using POSManagement.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSManagementApp.DatabaseContext.DatabaseContext
{
    public class SBMSystemDb:DbContext
    {
        DbSet<Customer> Customers { get; set; }
    }
}
