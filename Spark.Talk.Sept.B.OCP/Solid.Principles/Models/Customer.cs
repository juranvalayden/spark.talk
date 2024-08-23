using Solid.Principles.DataStores;

namespace Solid.Principles.Models;
public class Customer
{
    public CustomerType CustomerType { get; set; }

    public Customer(CustomerType customerType) => CustomerType = customerType;

    public double CalculateDiscount()
    {
        if (CustomerType == CustomerType.Gold)
        {
            return 5;
        }
        else 
        {
            return 3;
        }
    }
}
