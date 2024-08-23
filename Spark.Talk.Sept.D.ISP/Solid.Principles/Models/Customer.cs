using Solid.Principles.Enums;

namespace Solid.Principles.Models;
public class Customer
{
    public CustomerType CustomerType { get; set; }

    public Customer(CustomerType customerType)
        => CustomerType = customerType;

    public virtual double CalculateFees() => 3;

    public virtual double CalculateDiscount() => 1;
}