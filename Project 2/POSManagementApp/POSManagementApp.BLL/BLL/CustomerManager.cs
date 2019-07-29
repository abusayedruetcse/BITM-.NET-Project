using POSManagement.Models.Models;
using POSManagement.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSManagementApp.BLL.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository;
        Customer _customer;
        public CustomerManager()
        {
            _customerRepository = new CustomerRepository();
        }
    }
}
