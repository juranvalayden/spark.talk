using Solid.Principles.Models;

namespace Solid.Principles.DataStores;
public class CustomerDataStore
{
    public List<Customer> Customers { get; set; } = [];

    public CustomerDataStore()
    {
        for (var i = 0; i < 10; i++)
            Customers.Add(new Customer());
    }
}
