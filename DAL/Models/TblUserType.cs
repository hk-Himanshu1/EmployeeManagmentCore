using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TblUserType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public bool? Active { get; set; }

    public DateOnly? Created { get; set; }

    public string? CreatedBy { get; set; }
}
