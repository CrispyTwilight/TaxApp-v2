using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("w2")]
public partial class W2
{
    [Key]
    [Column("w2_id")]
    public int W2Id { get; set; }

    [Column("client_id")]
    public int? ClientId { get; set; }

    [Column("tax_year")]
    public int? TaxYear { get; set; }

    [Column("employer_ein")]
    [StringLength(10)]
    [Unicode(false)]
    public string? EmployerEin { get; set; }

    [Column("employer_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string? EmployerName { get; set; }

    [Column("employer_address_line1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmployerAddressLine1 { get; set; }

    [Column("employer_address_line2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmployerAddressLine2 { get; set; }

    [Column("employer_city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmployerCity { get; set; }

    [Column("employer_state")]
    [StringLength(2)]
    [Unicode(false)]
    public string? EmployerState { get; set; }

    [Column("employer_zip")]
    [StringLength(10)]
    [Unicode(false)]
    public string? EmployerZip { get; set; }

    [Column("control_number")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ControlNumber { get; set; }

    [Column("wages", TypeName = "decimal(15, 2)")]
    public decimal? Wages { get; set; }

    [Column("federal_tax_withheld", TypeName = "decimal(15, 2)")]
    public decimal? FederalTaxWithheld { get; set; }

    [Column("social_security_wages", TypeName = "decimal(15, 2)")]
    public decimal? SocialSecurityWages { get; set; }

    [Column("social_security_tax_withheld", TypeName = "decimal(15, 2)")]
    public decimal? SocialSecurityTaxWithheld { get; set; }

    [Column("medicare_wages_and_tips", TypeName = "decimal(15, 2)")]
    public decimal? MedicareWagesAndTips { get; set; }

    [Column("medicare_tax_withheld", TypeName = "decimal(15, 2)")]
    public decimal? MedicareTaxWithheld { get; set; }

    [Column("social_security_tips", TypeName = "decimal(15, 2)")]
    public decimal? SocialSecurityTips { get; set; }

    [Column("allocated_tips", TypeName = "decimal(15, 2)")]
    public decimal? AllocatedTips { get; set; }

    [Column("dependent_care_benefits", TypeName = "decimal(15, 2)")]
    public decimal? DependentCareBenefits { get; set; }

    [Column("non_qualified_plans", TypeName = "decimal(15, 2)")]
    public decimal? NonQualifiedPlans { get; set; }

    [Column("statutory_employee")]
    public bool? StatutoryEmployee { get; set; }

    [Column("retirement_plan")]
    public bool? RetirementPlan { get; set; }

    [Column("third_party_sick_pay")]
    public bool? ThirdPartySickPay { get; set; }

    [Column("box_12a_code")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Box12aCode { get; set; }

    [Column("box_12a_amount", TypeName = "decimal(15, 2)")]
    public decimal? Box12aAmount { get; set; }

    [Column("box_12b_code")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Box12bCode { get; set; }

    [Column("box_12b_amount", TypeName = "decimal(15, 2)")]
    public decimal? Box12bAmount { get; set; }

    [Column("box_12c_code")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Box12cCode { get; set; }

    [Column("box_12c_amount", TypeName = "decimal(15, 2)")]
    public decimal? Box12cAmount { get; set; }

    [Column("box_12d_code")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Box12dCode { get; set; }

    [Column("box_12d_amount", TypeName = "decimal(15, 2)")]
    public decimal? Box12dAmount { get; set; }

    [Column("other")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Other { get; set; }

    [Column("state")]
    [StringLength(2)]
    [Unicode(false)]
    public string? State { get; set; }

    [Column("state_employer_id")]
    [StringLength(10)]
    [Unicode(false)]
    public string? StateEmployerId { get; set; }

    [Column("state_wages", TypeName = "decimal(15, 2)")]
    public decimal? StateWages { get; set; }

    [Column("state_tax_withheld", TypeName = "decimal(15, 2)")]
    public decimal? StateTaxWithheld { get; set; }

    [Column("local_wages", TypeName = "decimal(15, 2)")]
    public decimal? LocalWages { get; set; }

    [Column("local_tax_withheld", TypeName = "decimal(15, 2)")]
    public decimal? LocalTaxWithheld { get; set; }

    [Column("local_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LocalName { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("W2s")]
    public virtual Client? Client { get; set; }
}
