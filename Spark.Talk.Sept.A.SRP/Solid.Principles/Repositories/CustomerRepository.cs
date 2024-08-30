using Solid.Principles.DataStores;
using Solid.Principles.Models;

namespace Solid.Principles.Repositories;
public class CustomerRepository
{
    private readonly CustomerDataStore _customerDataStore;
    private readonly string _filePath = "c:/solid/log.txt";

    public CustomerRepository() => _customerDataStore = new CustomerDataStore();

    public void AddCustomer(Customer customer)
    {
        try
        {
            _customerDataStore.Customers.Add(customer);
        }
        catch (Exception exception)
        {
            File.WriteAllText(_filePath, exception.Message);
        }
    }

    public void RemoveCustomer(Guid id)
    {
        try
        {
            var customer = _customerDataStore.Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null) _customerDataStore.Customers.Remove(customer);
        }
        catch (Exception exception)
        {
            File.WriteAllText(_filePath, exception.Message);
        }
    }
}
