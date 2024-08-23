using Solid.Principles.Enums;

namespace Solid.Principles.Models;

public class InStoreCustomer : CustomerNoFee
{
    public InStoreCustomer(CustomerType customerType)
        : base(customerType)
    {
    }

    public override double CalculateDiscount() => base.CalculateDiscount() + 2;
}