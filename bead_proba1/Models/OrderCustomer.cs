using System;
using System.Collections.Generic;

namespace bead_proba1.Models;

public partial class OrderCustomer
{
    public string? OrderId { get; set; }

    public string? CustomerId { get; set; }

    public virtual CustomerDetail? Customer { get; set; }

    public virtual OrderDetail? Order { get; set; }
}
