using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("form1040_tax_payments")]
[Index("Form1040Id", Name = "UQ__form1040__402C2DEDFAEAABE7", IsUnique = true)]
public partial class Form1040TaxPayment
{
    [Key]
    [Column("form1040_tax_payments_id")]
    public int Form1040TaxPaymentsId { get; set; }

    [Column("form1040_id")]
    public int? Form1040Id { get; set; }

    [Column("tax", TypeName = "decimal(15, 2)")]
    public decimal? Tax { get; set; }

    [Column("box1_8814")]
    public bool? Box18814 { get; set; }

    [Column("box2_4972")]
    public bool? Box24972 { get; set; }

    [Column("box3_")]
    public bool? Box3 { get; set; }

    [Column("box3_form_number")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Box3FormNumber { get; set; }

    [Column("schedule2_amount", TypeName = "decimal(15, 2)")]
    public decimal? Schedule2Amount { get; set; }

    [Column("line18_total", TypeName = "decimal(15, 2)")]
    public decimal? Line18Total { get; set; }

    [Column("child_tax_credit", TypeName = "decimal(15, 2)")]
    public decimal? ChildTaxCredit { get; set; }

    [Column("schedule3_amount", TypeName = "decimal(15, 2)")]
    public decimal? Schedule3Amount { get; set; }

    [Column("line21_total", TypeName = "decimal(15, 2)")]
    public decimal? Line21Total { get; set; }

    [Column("line22_result", TypeName = "decimal(15, 2)")]
    public decimal? Line22Result { get; set; }

    [Column("other_taxes", TypeName = "decimal(15, 2)")]
    public decimal? OtherTaxes { get; set; }

    [Column("total_tax", TypeName = "decimal(15, 2)")]
    public decimal? TotalTax { get; set; }

    [Column("form_w2_federal_income_tax_withheld", TypeName = "decimal(15, 2)")]
    public decimal? FormW2FederalIncomeTaxWithheld { get; set; }

    [Column("form1099_federal_income_tax_withheld", TypeName = "decimal(15, 2)")]
    public decimal? Form1099FederalIncomeTaxWithheld { get; set; }

    [Column("other_forms_federal_income_tax_withheld", TypeName = "decimal(15, 2)")]
    public decimal? OtherFormsFederalIncomeTaxWithheld { get; set; }

    [Column("total_federal_income_tax_withheld", TypeName = "decimal(15, 2)")]
    public decimal? TotalFederalIncomeTaxWithheld { get; set; }

    [Column("estimated_tax_payments", TypeName = "decimal(15, 2)")]
    public decimal? EstimatedTaxPayments { get; set; }

    [Column("earned_income_credit", TypeName = "decimal(15, 2)")]
    public decimal? EarnedIncomeCredit { get; set; }

    [Column("additional_child_tax_credit", TypeName = "decimal(15, 2)")]
    public decimal? AdditionalChildTaxCredit { get; set; }

    [Column("american_opportunity_credit", TypeName = "decimal(15, 2)")]
    public decimal? AmericanOpportunityCredit { get; set; }

    [Column("schedule3_line15_amount", TypeName = "decimal(15, 2)")]
    public decimal? Schedule3Line15Amount { get; set; }

    [Column("total_other_payments_refundable_credits", TypeName = "decimal(15, 2)")]
    public decimal? TotalOtherPaymentsRefundableCredits { get; set; }

    [Column("total_payments", TypeName = "decimal(15, 2)")]
    public decimal? TotalPayments { get; set; }

    [Column("overpaid_amount", TypeName = "decimal(15, 2)")]
    public decimal? OverpaidAmount { get; set; }

    [Column("refund_request_amount", TypeName = "decimal(15, 2)")]
    public decimal? RefundRequestAmount { get; set; }

    [Column("form8888_attached")]
    public bool? Form8888Attached { get; set; }

    [Column("apply_to_estimated_tax", TypeName = "decimal(15, 2)")]
    public decimal? ApplyToEstimatedTax { get; set; }

    [Column("amount_owe", TypeName = "decimal(15, 2)")]
    public decimal? AmountOwe { get; set; }

    [Column("estimated_tax_penalty", TypeName = "decimal(15, 2)")]
    public decimal? EstimatedTaxPenalty { get; set; }

    [Column("yes_designee")]
    public bool? YesDesignee { get; set; }

    [Column("no_designee")]
    public bool? NoDesignee { get; set; }

    [Column("designee_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DesigneeName { get; set; }

    [Column("designee_phone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? DesigneePhone { get; set; }

    [Column("designee_pin")]
    [StringLength(5)]
    [Unicode(false)]
    public string? DesigneePin { get; set; }

    [Column("signature")]
    public byte[]? Signature { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("occupation")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Occupation { get; set; }

    [Column("identity_protection_pin")]
    [StringLength(6)]
    [Unicode(false)]
    public string? IdentityProtectionPin { get; set; }

    [Column("spouse_signature")]
    public byte[]? SpouseSignature { get; set; }

    [Column("spouse_date")]
    public DateOnly? SpouseDate { get; set; }

    [Column("spouse_occupation")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SpouseOccupation { get; set; }

    [Column("spouse_identity_protection_pin")]
    [StringLength(6)]
    [Unicode(false)]
    public string? SpouseIdentityProtectionPin { get; set; }

    [Column("phone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("preparer_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PreparerName { get; set; }

    [Column("preparer_firm_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PreparerFirmName { get; set; }

    [Column("preparer_address_line1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PreparerAddressLine1 { get; set; }

    [Column("preparer_address_line2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PreparerAddressLine2 { get; set; }

    [Column("preparer_city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PreparerCity { get; set; }

    [Column("preparer_state")]
    [StringLength(2)]
    [Unicode(false)]
    public string? PreparerState { get; set; }

    [Column("preparer_zip")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PreparerZip { get; set; }

    [Column("preparer_ptin")]
    [StringLength(9)]
    [Unicode(false)]
    public string? PreparerPtin { get; set; }

    [Column("preparer_phone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PreparerPhone { get; set; }

    [Column("preparer_firm_ein")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PreparerFirmEin { get; set; }

    [ForeignKey("Form1040Id")]
    [InverseProperty("Form1040TaxPayment")]
    public virtual Form1040? Form1040 { get; set; }
}
