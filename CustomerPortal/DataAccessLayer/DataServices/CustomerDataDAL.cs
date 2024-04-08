using BuissnessObjectLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataServices
{
   public class CustomerDataDAL: ICustomerDataDAL
    {
        private readonly CustomerDataDAL _customerDataDAL;
        public List<Customer> GetCustomers()
        {
          
            return new List<Customer>();
        }
    }
}
