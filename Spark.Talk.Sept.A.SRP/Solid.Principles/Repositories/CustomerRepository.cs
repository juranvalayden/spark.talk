using Solid.Principles.DataStores;
using Solid.Principles.Models;

namespace Solid.Principles.Repositories;
public class CustomerRepository
{
    private CustomerDataStore _customerDataStore;

    public CustomerRepository() =>
        _customerDataStore = new CustomerDataStore();

    public void AddCustomer(Customer customer)
    {
        try
        {
            _customerDataStore.Customers.Add(customer);
        }
        catch (Exception ex)
        {
            File.WriteAllText("c:/solid/log.txt", ex.Message);
        }
    }
}
