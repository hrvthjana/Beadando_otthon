using System;
using System.Collections.Generic;

namespace bead_proba1.Models;

public partial class Product
{
    public string ProductId { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string SubCategory { get; set; } = null!;
}
