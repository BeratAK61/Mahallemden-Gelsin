using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Product : Entity<int>
{
    public string Name { get; set; }

    public string Description { get; set; }

    public string Barcode { get; set; }

    public decimal? Quantity { get; set; }

    public bool IsHome { get; set; }

}
