using Solid.Principles.Models;

namespace Solid.Principles.Interfaces;

public interface ICustomerRepository
{
    void AddCustomer(Customer customer);
    ICollection<Customer> GetCustomers();
}