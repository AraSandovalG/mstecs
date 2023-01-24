using System;
using System.Collections.Generic;

namespace mstecsproject.Models;

public partial class InvoiceDetail
{
    public int InvoiceDetailId { get; set; }

    public int InvoiceId { get; set; }

    public int ProductId { get; set; }

    public decimal Price { get; set; }

    public double Quantity { get; set; }

    public decimal Amount { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
