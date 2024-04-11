using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("form1040_income")]
[Index("Form1040Id", Name = "UQ__form1040__402C2DEDF852D586", IsUnique = true)]
public partial class Form1040Income
{
    [Key]
    [Column("form1040_income_id")]
    public int Form1040IncomeId { get; set; }

    [Column("form1040_id")]
    public int? Form1040Id { get; set; }

    [Column("total_w2_income", TypeName = "decimal(15, 2)")]
    public decimal? TotalW2Income { get; set; }

    [Column("household_employee_wages", TypeName = "decimal(15, 2)")]
    public decimal? HouseholdEmployeeWages { get; set; }

    [Column("tip_income", TypeName = "decimal(15, 2)")]
    public decimal? TipIncome { get; set; }

    [Column("medicaid_waiver_payments", TypeName = "decimal(15, 2)")]
    public decimal? MedicaidWaiverPayments { get; set; }

    [Column("dependent_care_benefits", TypeName = "decimal(15, 2)")]
    public decimal? DependentCareBenefits { get; set; }

    [Column("adoption_benefits", TypeName = "decimal(15, 2)")]
    public decimal? AdoptionBenefits { get; set; }

    [Column("form8919_wages", TypeName = "decimal(15, 2)")]
    public decimal? Form8919Wages { get; set; }

    [Column("other_earned_income", TypeName = "decimal(15, 2)")]
    public decimal? OtherEarnedIncome { get; set; }

    [Column("combat_pay_election", TypeName = "decimal(15, 2)")]
    public decimal? CombatPayElection { get; set; }

    [Column("total_earned_income", TypeName = "decimal(15, 2)")]
    public decimal? TotalEarnedIncome { get; set; }

    [Column("tax_exempt_interest", TypeName = "decimal(15, 2)")]
    public decimal? TaxExemptInterest { get; set; }

    [Column("taxable_interest", TypeName = "decimal(15, 2)")]
    public decimal? TaxableInterest { get; set; }

    [Column("qualified_dividends", TypeName = "decimal(15, 2)")]
    public decimal? QualifiedDividends { get; set; }

    [Column("ordinary_dividends", TypeName = "decimal(15, 2)")]
    public decimal? OrdinaryDividends { get; set; }

    [Column("ira_distributions", TypeName = "decimal(15, 2)")]
    public decimal? IraDistributions { get; set; }

    [Column("taxable_ira_distributions", TypeName = "decimal(15, 2)")]
    public decimal? TaxableIraDistributions { get; set; }

    [Column("pensions_annuities", TypeName = "decimal(15, 2)")]
    public decimal? PensionsAnnuities { get; set; }

    [Column("taxable_pensions_annuities", TypeName = "decimal(15, 2)")]
    public decimal? TaxablePensionsAnnuities { get; set; }

    [Column("social_security_benefits", TypeName = "decimal(15, 2)")]
    public decimal? SocialSecurityBenefits { get; set; }

    [Column("taxable_social_security_benefits", TypeName = "decimal(15, 2)")]
    public decimal? TaxableSocialSecurityBenefits { get; set; }

    [Column("lump_sum_election")]
    public bool? LumpSumElection { get; set; }

    [Column("schedule_d_not_required")]
    public bool? ScheduleDNotRequired { get; set; }

    [Column("capital_gain_loss", TypeName = "decimal(15, 2)")]
    public decimal? CapitalGainLoss { get; set; }

    [Column("additional_income", TypeName = "decimal(15, 2)")]
    public decimal? AdditionalIncome { get; set; }

    [Column("total_income", TypeName = "decimal(15, 2)")]
    public decimal? TotalIncome { get; set; }

    [Column("adjustments_to_income", TypeName = "decimal(15, 2)")]
    public decimal? AdjustmentsToIncome { get; set; }

    [Column("adjusted_gross_income", TypeName = "decimal(15, 2)")]
    public decimal? AdjustedGrossIncome { get; set; }

    [Column("standard_or_itemized_deduction", TypeName = "decimal(15, 2)")]
    public decimal? StandardOrItemizedDeduction { get; set; }

    [Column("qualified_business_income_deduction", TypeName = "decimal(15, 2)")]
    public decimal? QualifiedBusinessIncomeDeduction { get; set; }

    [Column("taxable_income", TypeName = "decimal(15, 2)")]
    public decimal? TaxableIncome { get; set; }

    [ForeignKey("Form1040Id")]
    [InverseProperty("Form1040Income")]
    public virtual Form1040? Form1040 { get; set; }
}
