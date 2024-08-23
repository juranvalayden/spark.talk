using Solid.Principles.Enums;

namespace Solid.Principles.Models;

public class GoldCustomer : Customer 
{
    public GoldCustomer(CustomerType customerType) 
        : base(customerType)
    {
    }

    public override double CalculateFees() => base.CalculateFees() + 2;

    public override double CalculateDiscount() => base.CalculateDiscount() + 10;
}
