using Solid.Principles.Enums;

namespace Solid.Principles.Models;

public class InStoreCustomer : Customer
{
    public InStoreCustomer(CustomerType customerType) 
        : base(customerType)
    {
    }

    public override double CalculateFees() => throw new NotImplementedException();

    public override double CalculateDiscount() => base.CalculateDiscount() + 2;
}
