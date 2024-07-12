using Assignment1Api.Entities;
using Assignment1Api.Interfaces;
using System.Collections.Generic;

namespace Assignment1Api.Services
{
    /// <summary>
    /// Represents a service for managing customers.
    /// </summary>
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerService"/> class.
        /// </summary>
        /// <param name="customerRepo">The customer repository.</param>
        public CustomerService(ICustomerRepo customerRepo) => _customerRepo = customerRepo;

        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns>A list of customers.</returns>
        public List<Customer> GetAllCustomers() => _customerRepo.GetAllCustomers();

        /// <summary>
        /// Gets a customer by ID.
        /// </summary>
        /// <param name="id">The ID of the customer.</param>
        /// <returns>The customer with the specified ID.</returns>
        public Customer GetCustomerById(int id) => _customerRepo.GetCustomerById(id);
    }
}
