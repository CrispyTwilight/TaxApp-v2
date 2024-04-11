using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("schedule_k1")]
public partial class ScheduleK1
{
    [Key]
    [Column("schedule_k1_id")]
    public int ScheduleK1Id { get; set; }

    [Column("client_id")]
    public int? ClientId { get; set; }

    [Column("tax_year")]
    public int? TaxYear { get; set; }

    [Column("final_k1")]
    public bool? FinalK1 { get; set; }

    [Column("amended_k1")]
    public bool? AmendedK1 { get; set; }

    [Column("beginning_date", TypeName = "date")]
    public DateTime? BeginningDate { get; set; }

    [Column("ending_date", TypeName = "date")]
    public DateTime? EndingDate { get; set; }

    [Column("estate_or_trust_ein")]
    [StringLength(10)]
    [Unicode(false)]
    public string? EstateOrTrustEin { get; set; }

    [Column("estate_or_trust_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string? EstateOrTrustName { get; set; }

    [Column("fiduciary_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string? FiduciaryName { get; set; }

    [Column("fiduciary_address_line1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FiduciaryAddressLine1 { get; set; }

    [Column("fiduciary_address_line2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FiduciaryAddressLine2 { get; set; }

    [Column("fiduciary_city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FiduciaryCity { get; set; }

    [Column("fiduciary_state")]
    [StringLength(2)]
    [Unicode(false)]
    public string? FiduciaryState { get; set; }

    [Column("fiduciary_zip")]
    [StringLength(10)]
    [Unicode(false)]
    public string? FiduciaryZip { get; set; }

    [Column("d_1041t_filed")]
    public bool? D1041tFiled { get; set; }

    [Column("d_date_filed", TypeName = "date")]
    public DateTime? DDateFiled { get; set; }

    [Column("e_final_form1041")]
    public bool? EFinalForm1041 { get; set; }

    [Column("beneficiary_id")]
    [StringLength(11)]
    [Unicode(false)]
    public string? BeneficiaryId { get; set; }

    [Column("beneficiary_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string? BeneficiaryName { get; set; }

    [Column("beneficiary_street_address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BeneficiaryStreetAddress { get; set; }

    [Column("beneficiary_city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BeneficiaryCity { get; set; }

    [Column("beneficiary_state")]
    [StringLength(2)]
    [Unicode(false)]
    public string? BeneficiaryState { get; set; }

    [Column("beneficiary_zip")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BeneficiaryZip { get; set; }

    [Column("h_domestic_beneficiary")]
    public bool? HDomesticBeneficiary { get; set; }

    [Column("h_foreign_beneficiary")]
    public bool? HForeignBeneficiary { get; set; }

    [Column("interest_income", TypeName = "decimal(15, 2)")]
    public decimal? InterestIncome { get; set; }

    [Column("ordinary_dividends", TypeName = "decimal(15, 2)")]
    public decimal? OrdinaryDividends { get; set; }

    [Column("qualified_dividends", TypeName = "decimal(15, 2)")]
    public decimal? QualifiedDividends { get; set; }

    [Column("net_short_term_capital_gain", TypeName = "decimal(15, 2)")]
    public decimal? NetShortTermCapitalGain { get; set; }

    [Column("net_long_term_capital_gain", TypeName = "decimal(15, 2)")]
    public decimal? NetLongTermCapitalGain { get; set; }

    [Column("rate_28_gain", TypeName = "decimal(15, 2)")]
    public decimal? Rate28Gain { get; set; }

    [Column("other_portfolio_and_non_business_income", TypeName = "decimal(15, 2)")]
    public decimal? OtherPortfolioAndNonBusinessIncome { get; set; }

    [Column("ordinary_business_income", TypeName = "decimal(15, 2)")]
    public decimal? OrdinaryBusinessIncome { get; set; }

    [Column("net_rental_real_estate_income", TypeName = "decimal(15, 2)")]
    public decimal? NetRentalRealEstateIncome { get; set; }

    [Column("other_rental_income", TypeName = "decimal(15, 2)")]
    public decimal? OtherRentalIncome { get; set; }

    [Column("directly_apportioned_deductions", TypeName = "decimal(15, 2)")]
    public decimal? DirectlyApportionedDeductions { get; set; }

    [Column("estate_tax_deduction", TypeName = "decimal(15, 2)")]
    public decimal? EstateTaxDeduction { get; set; }

    [Column("final_year_deductions", TypeName = "decimal(15, 2)")]
    public decimal? FinalYearDeductions { get; set; }

    [Column("alternative_minimum_tax_adjustment", TypeName = "decimal(15, 2)")]
    public decimal? AlternativeMinimumTaxAdjustment { get; set; }

    [Column("credits_credit_recapture", TypeName = "decimal(15, 2)")]
    public decimal? CreditsCreditRecapture { get; set; }

    [Column("other_information")]
    [StringLength(255)]
    [Unicode(false)]
    public string? OtherInformation { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("ScheduleK1s")]
    public virtual Client? Client { get; set; }
}
