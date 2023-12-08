using System;
using System.Collections.Generic;

namespace bead_proba1.Models;

public partial class OrderProduct
{
    public string? OrderId { get; set; }

    public string? ProductId { get; set; }

    public decimal? Sales { get; set; }

    public virtual OrderDetail? Order { get; set; }

    public virtual Product? Product { get; set; }
}
