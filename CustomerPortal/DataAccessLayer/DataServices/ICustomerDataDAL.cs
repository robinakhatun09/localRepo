using BuissnessObjectLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataServices
{
    public interface ICustomerDataDAL
    {
        List<Customer> GetCustomers();
    }
}
