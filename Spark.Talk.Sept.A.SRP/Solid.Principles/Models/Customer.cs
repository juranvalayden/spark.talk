namespace Solid.Principles.Models;
public class Customer
{
    public Guid Id { get; set; }

    public Customer() => Id = Guid.NewGuid();
}
