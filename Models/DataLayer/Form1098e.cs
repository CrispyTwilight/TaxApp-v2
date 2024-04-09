using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("form1098e")]
public partial class Form1098e
{
    [Key]
    [Column("form1098e_id")]
    public int Form1098eId { get; set; }

    [Column("client_id")]
    public int? ClientId { get; set; }

    [Column("tax_year")]
    public int? TaxYear { get; set; }

    [Column("corrected")]
    public bool? Corrected { get; set; }

    [Column("recipient_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string? RecipientName { get; set; }

    [Column("recipient_address_line1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RecipientAddressLine1 { get; set; }

    [Column("recipient_address_line2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RecipientAddressLine2 { get; set; }

    [Column("recipient_city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RecipientCity { get; set; }

    [Column("recipient_state")]
    [StringLength(2)]
    [Unicode(false)]
    public string? RecipientState { get; set; }

    [Column("recipient_zip")]
    [StringLength(10)]
    [Unicode(false)]
    public string? RecipientZip { get; set; }

    [Column("recipient_phone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? RecipientPhone { get; set; }

    [Column("recipient_tin")]
    [StringLength(10)]
    [Unicode(false)]
    public string? RecipientTin { get; set; }

    [Column("borrower_tin")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BorrowerTin { get; set; }

    [Column("account_number")]
    [StringLength(17)]
    [Unicode(false)]
    public string? AccountNumber { get; set; }

    [Column("student_loan_interest_received_by_lender", TypeName = "decimal(15, 2)")]
    public decimal? StudentLoanInterestReceivedByLender { get; set; }

    [Column("box2")]
    public bool? Box2 { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("Form1098es")]
    public virtual Client? Client { get; set; }
}
