using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("form1040_dependents")]
[Index("Form1040Id", Name = "UQ__form1040__402C2DEDF90E8D5A", IsUnique = true)]
[Index("Ssn", Name = "UQ__form1040__DDDF0AE67F7AB86B", IsUnique = true)]
public partial class Form1040Dependent
{
    [Key]
    [Column("form1040_dependents_id")]
    public int Form1040DependentsId { get; set; }

    [Column("form1040_id")]
    public int? Form1040Id { get; set; }

    [Column("first_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [Column("last_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [Column("ssn")]
    [StringLength(11)]
    [Unicode(false)]
    public string Ssn { get; set; } = null!;

    [Column("relationship")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Relationship { get; set; }

    [Column("child_tax_credit")]
    public bool? ChildTaxCredit { get; set; }

    [Column("credit_for_other_dependents")]
    public bool? CreditForOtherDependents { get; set; }

    [ForeignKey("Form1040Id")]
    [InverseProperty("Form1040Dependent")]
    public virtual Form1040? Form1040 { get; set; }
}
