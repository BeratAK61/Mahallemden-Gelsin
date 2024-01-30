using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Entities;

public class RefreshToken : Entity<int>
{
    public int UserId { get; set; }

    public string Token { get; set; }

    public DateTime TimeStamp { get; set; }

    public string CreatedByIp { get; set; }

    public DateTime? Revoked { get; set; }

    public string? RevokedByIp { get; set; }

    public string? ReplacedByToken { get; set; }

    public string? ReasonRevoked { get; set; }


    public virtual User User { get; set; } = null!;
}
