using Solid.Principles.Models;
using Solid.Principles.Repositories;

var customerRepository = new CustomerRepository();
var customer = new Customer();

customerRepository.AddCustomer(customer);

Console.ReadKey();