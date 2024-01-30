using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class OperationClaim : Entity<int>
{
    public string Name { get; set; }


}
