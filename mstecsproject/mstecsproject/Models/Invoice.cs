using System;
using System.Collections.Generic;

namespace mstecsproject.Models;

public partial class Invoice
{
    public int InvoiceId { get; set; }

    public DateTime Date { get; set; }

    public int ClientId { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; } = new List<InvoiceDetail>();
}
