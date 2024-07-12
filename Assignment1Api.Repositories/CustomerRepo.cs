using Assignment1Api.Entities;
using Assignment1Api.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1Api.Repositories
{
    /// <summary>
    /// Represents a repository for managing customers.
    /// </summary>
    public class CustomerRepo : ICustomerRepo
    {
        private readonly List<Customer> _customers;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRepo"/> class.
        /// </summary>
        public CustomerRepo()
        {
            _customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "John", LastName = "Doe" },
                new Customer { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Customer { Id = 3, FirstName = "Alice", LastName = "Smith" },
                new Customer { Id = 4, FirstName = "Bob", LastName = "Johnson" },
                new Customer { Id = 5, FirstName = "Emily", LastName = "Davis" },
                new Customer { Id = 6, FirstName = "Michael", LastName = "Wilson" },
                new Customer { Id = 7, FirstName = "Olivia", LastName = "Brown" },
                new Customer { Id = 8, FirstName = "James", LastName = "Miller" },
                new Customer { Id = 9, FirstName = "Sophia", LastName = "Taylor" },
                new Customer { Id = 10, FirstName = "Benjamin", LastName = "Anderson" },
                new Customer { Id = 11, FirstName = "Ava", LastName = "Thomas" },
                new Customer { Id = 12, FirstName = "William", LastName = "Martinez" }
            };
        }

        /// <summary>
        /// Gets all the customers.
        /// </summary>
        /// <returns>A list of customers.</returns>
        public List<Customer> GetAllCustomers() => _customers;

        /// <summary>
        /// Gets a customer by their ID.
        /// </summary>
        /// <param name="id">The ID of the customer.</param>
        /// <returns>The customer with the specified ID, or null if not found.</returns>
        public Customer GetCustomerById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }
    }
}
