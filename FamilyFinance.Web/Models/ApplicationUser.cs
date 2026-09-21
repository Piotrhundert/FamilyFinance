using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FamilyFinance.Web.Models;

public class ApplicationUser : IdentityUser
{
    [MaxLength(100)]
    public string? FirstName { get; set; }

    [MaxLength(100)]
    public string? LastName { get; set; }

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public DateTime? LastLoginAtUtc { get; set; }

    public bool IsActive { get; set; } = true;

    public UserAccountStatus AccountStatus { get; set; } = UserAccountStatus.Active;
}

public enum UserAccountStatus
{
    PendingActivation = 0,
    Active = 1,
    Blocked = 2,
    Suspended = 3,
    Deleted = 4
}
