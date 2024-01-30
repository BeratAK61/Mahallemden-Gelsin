using Core.Persistence.Repositories;
using Core.Security.Enums;

namespace Core.Security.Entities;

public class User : Entity<int>
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }

    public bool Status { get; set; }

    public bool EmailConfirmed { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public AuthenticatiorType AuthenticatiorType { get; set; }

}
