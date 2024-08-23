using Solid.Principles.Enums;

namespace Solid.Principles.Models;

public class CustomerNoFee
{
    public CustomerType CustomerType { get; set; }

    public CustomerNoFee(CustomerType customerType)
        => CustomerType = customerType;

    public virtual double CalculateDiscount() => 2;
}