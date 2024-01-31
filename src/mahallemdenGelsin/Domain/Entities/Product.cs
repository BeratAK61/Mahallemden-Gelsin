using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Product : Entity<int>
{
    public string Name { get; set; }

    public string Description { get; set; }

    public string Barcode { get; set; }

    public decimal? Quantity { get; set; }

    public bool IsHome { get; set; }



    public int? BrandId { get; set; }
    public virtual Brand? Brand { get; set; }

    public int? SizeId { get; set; }
    public virtual Size? Size { get; set; }

    public int? UnitId { get; set; }
    public virtual Unit? Unit { get; set; }


    public ICollection<Image>? Images { get; set; }
}
