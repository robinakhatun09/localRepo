using BuissnessObjectLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissessLogicLayer.LogicServices
{
    public interface ICustomer
    {
        public List<Customer> GetCustomers();
    }
}
