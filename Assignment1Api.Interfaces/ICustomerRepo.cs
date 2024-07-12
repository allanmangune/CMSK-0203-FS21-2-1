using Assignment1Api.Entities;
using System.Collections.Generic;

namespace Assignment1Api.Interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
    }
}
