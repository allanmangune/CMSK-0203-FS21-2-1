using Assignment1Api.Entities;
using Assignment1Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers
{
    /// <summary>
    /// Represents a controller for managing customer data.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerController"/> class.
        /// </summary>
        /// <param name="customerService">The customer service.</param>
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns>An <see cref="IActionResult"/> representing the response of the action.</returns>
        [HttpGet("GetAllCustomers")]
        public IActionResult GetAllCustomers()
        {
            List<Customer> customerList = _customerService.GetAllCustomers();
            return Ok(customerList);
        }

        /// <summary>
        /// Gets a customer by ID.
        /// </summary>
        /// <param name="id">The ID of the customer.</param>
        /// <returns>An <see cref="IActionResult"/> representing the response of the action.</returns>
        [HttpGet("GetCustomerById/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            Customer existingCustomer = _customerService.GetCustomerById(id);
            return existingCustomer == null ? NoContent() : Ok(existingCustomer);
        }
    }
}
