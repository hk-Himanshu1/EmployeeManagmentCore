using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TblUser
{
    public Guid UserId { get; set; }

    public string? UserType { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public bool? Active { get; set; }

    public bool? ResetPassword { get; set; }

    public string Password { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public DateOnly PasswordExpireDate { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public int? Pincode { get; set; }
}
