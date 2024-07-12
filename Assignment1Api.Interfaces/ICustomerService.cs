using Assignment1Api.Entities;
using System.Collections.Generic;

namespace Assignment1Api.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
    }
}
