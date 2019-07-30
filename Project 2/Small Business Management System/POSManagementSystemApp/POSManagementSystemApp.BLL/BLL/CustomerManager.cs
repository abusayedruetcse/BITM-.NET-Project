using POSManagementSystem.Models.Models;
using POSManagementSystem.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSManagementSystem.BLL.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository;
        Customer _customer;
        public CustomerManager()
        {
            _customerRepository = new CustomerRepository();
        }
        public bool check(Customer customer)
        {
            return _customerRepository.check(customer);
        }
    }
}
