using System;
using System.Collections.Generic;

namespace bead_proba1.Models;

public partial class CustomerDetail
{
    public string CustomerId { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string Segment { get; set; } = null!;

    public int? PostalCode { get; set; }

    public virtual CustomerAddress? PostalCodeNavigation { get; set; }
}
