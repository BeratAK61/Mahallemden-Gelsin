using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Brand : Entity<int>
{
    public string Name { get; set; }

    public string Description { get; set; }

    public virtual ICollection<Product> Products { get; set; }

}
