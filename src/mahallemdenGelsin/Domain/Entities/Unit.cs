using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Unit : Entity<int>
{
    public string Name { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}
