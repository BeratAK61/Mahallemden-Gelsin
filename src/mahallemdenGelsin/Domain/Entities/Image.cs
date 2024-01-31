using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Image : Entity<int>
{
    public string FileName { get; set; }

    public string FilePath { get; set; }

    public string ImageUrl { get; set; }

    public bool IsMainImage { get; set; }

    public int? ProductId { get; set; }
    public Product? Product { get; set; }

}
