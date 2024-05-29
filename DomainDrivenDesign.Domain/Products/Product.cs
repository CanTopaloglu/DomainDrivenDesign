using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Categories;
using DomainDrivenDesign.Domain.Shared;

namespace DomainDrivenDesign.Domain.Products;
public sealed class Product : Entity
{
    public Product(Name name, Description description,Money money, Guid categoryId)
    {
        //ekstra kontrol yazılabilir.
        Name = name;
        Description = description;
        Price = money;
        CategoryId = categoryId;

    }
    public Name Name { get; private set; } = new(string.Empty);
    public Description Description { get; private set; } = new(string.Empty);
    public Money Price { get; private set; } = Money.Zero();
    public  Guid CategoryId { get; private set; }
    public Category? Category { get; private set; }

    public void ChangeName(string name)
    {
        Name = new(name);
    }
}
