using Solid.Principles.Enums;
using Solid.Principles.Models;
using Solid.Principles.Repositories;

var goldCustomer = new GoldCustomer(CustomerType.Gold);
var platinumCustomer = new PlatinumCustomer(CustomerType.Platinum);
var inStoreCustomer = new InStoreCustomer(CustomerType.InStore);

var customerRepository = new CustomerRepository();
customerRepository.AddCustomer(goldCustomer);
customerRepository.AddCustomer(platinumCustomer);
customerRepository.AddCustomer(inStoreCustomer);

var customers = customerRepository.GetCustomers();

foreach (var customer in customers)
    customer.CalculateFees();

Console.ReadKey();