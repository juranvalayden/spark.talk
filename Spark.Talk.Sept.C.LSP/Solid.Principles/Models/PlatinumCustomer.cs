using Solid.Principles.Enums;

namespace Solid.Principles.Models;

public class PlatinumCustomer : Customer
{
    public PlatinumCustomer(CustomerType customerType)
        : base(customerType)
    {
    }

    public override double CalculateFees() => base.CalculateFees() + 5;

    public override double CalculateDiscount() => base.CalculateDiscount() + 15;
}