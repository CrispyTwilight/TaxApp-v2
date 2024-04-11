using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("invoices")]
public partial class Invoice
{
    [Key]
    [Column("invoice_id")]
    public int InvoiceId { get; set; }

    [Column("client_id")]
    public int? ClientId { get; set; }

    [Column("employee_id")]
    public int? EmployeeId { get; set; }

    [Column("invoice_date", TypeName = "date")]
    public DateTime? InvoiceDate { get; set; }

    [Column("due_date", TypeName = "date")]
    public DateTime? DueDate { get; set; }

    [Column("amount", TypeName = "decimal(15, 2)")]
    public decimal? Amount { get; set; }

    [Column("paid")]
    public bool? Paid { get; set; }

    [Column("payment_date", TypeName = "date")]
    public DateTime? PaymentDate { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("Invoices")]
    public virtual Client? Client { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("Invoices")]
    public virtual Employee? Employee { get; set; }
}
