using Solid.Principles.DataStores;
using Solid.Principles.Models;
using Solid.Principles.Repositories;

var customerRepository = new CustomerRepository();
var customer = new Customer(CustomerType.Gold);

customerRepository.AddCustomer(customer);

Console.ReadKey();