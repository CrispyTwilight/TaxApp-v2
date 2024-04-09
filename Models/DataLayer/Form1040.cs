using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("form1040")]
public partial class Form1040
{
    [Key]
    [Column("form1040_id")]
    public int Form1040Id { get; set; }

    [Column("client_id")]
    public int? ClientId { get; set; }

    [Column("beginning_month_day")]
    [StringLength(12)]
    [Unicode(false)]
    public string? BeginningMonthDay { get; set; }

    [Column("ending_month_day")]
    [StringLength(12)]
    [Unicode(false)]
    public string? EndingMonthDay { get; set; }

    [Column("ending_year_last_2_digits")]
    [StringLength(2)]
    [Unicode(false)]
    public string? EndingYearLast2Digits { get; set; }

    [Column("address_line1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AddressLine1 { get; set; }

    [Column("address_line2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AddressLine2 { get; set; }

    [Column("city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [Column("state")]
    [StringLength(2)]
    [Unicode(false)]
    public string? State { get; set; }

    [Column("zip")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Zip { get; set; }

    [Column("foreign_country_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ForeignCountryName { get; set; }

    [Column("foreign_province_state_county")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ForeignProvinceStateCounty { get; set; }

    [Column("foreign_postal_code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ForeignPostalCode { get; set; }

    [Column("you_presidential_election_fund")]
    public bool? YouPresidentialElectionFund { get; set; }

    [Column("spouse_presidential_election_fund")]
    public bool? SpousePresidentialElectionFund { get; set; }

    [Column("single")]
    public bool? Single { get; set; }

    [Column("married_filing_jointly")]
    public bool? MarriedFilingJointly { get; set; }

    [Column("married_filing_separately")]
    public bool? MarriedFilingSeparately { get; set; }

    [Column("head_of_household")]
    public bool? HeadOfHousehold { get; set; }

    [Column("qualifying_surviving_spouse")]
    public bool? QualifyingSurvivingSpouse { get; set; }

    [Column("filing_status_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FilingStatusName { get; set; }

    [Column("yes_digital_asset_transaction")]
    public bool? YesDigitalAssetTransaction { get; set; }

    [Column("no_digital_asset_transaction")]
    public bool? NoDigitalAssetTransaction { get; set; }

    [Column("you_as_a_dependent")]
    public bool? YouAsADependent { get; set; }

    [Column("spouse_as_a_dependent")]
    public bool? SpouseAsADependent { get; set; }

    [Column("spouse_itemizes")]
    public bool? SpouseItemizes { get; set; }

    [Column("born_before_jan2_1959")]
    public bool? BornBeforeJan21959 { get; set; }

    [Column("blind")]
    public bool? Blind { get; set; }

    [Column("spouse_born_before_jan2_1959")]
    public bool? SpouseBornBeforeJan21959 { get; set; }

    [Column("spouse_blind")]
    public bool? SpouseBlind { get; set; }

    [Column("more_than_4_dependents")]
    public bool? MoreThan4Dependents { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("Form1040s")]
    public virtual Client? Client { get; set; }

    [InverseProperty("Form1040")]
    public virtual Form1040Dependent? Form1040Dependent { get; set; }

    [InverseProperty("Form1040")]
    public virtual Form1040Income? Form1040Income { get; set; }

    [InverseProperty("Form1040")]
    public virtual Form1040TaxPayment? Form1040TaxPayment { get; set; }
}
