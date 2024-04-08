using BuissnessObjectLayer.Entities;
using DataAccessLayer.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissessLogicLayer.LogicServices
{
    public class CustomerLogic : ICustomer
    {
        private readonly ICustomerDataDAL _customerDataDAL;

        public CustomerLogic(ICustomerDataDAL customerDataDAL)
        {
            _customerDataDAL = customerDataDAL;
        }

        public List<Customer> GetCustomers() 
        {
          List<Customer> ret = new List<Customer>();
            ret = _customerDataDAL.GetCustomers();
            return ret;
        }

       
    }
}
