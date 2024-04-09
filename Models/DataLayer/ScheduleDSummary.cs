using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("schedule_d_summary")]
public partial class ScheduleDSummary
{
    [Key]
    [Column("schedule_d_summary_id")]
    public int ScheduleDSummaryId { get; set; }

    [Column("schedule_d_metadata_id")]
    public int? ScheduleDMetadataId { get; set; }

    [Column("total_gain_loss", TypeName = "decimal(15, 2)")]
    public decimal? TotalGainLoss { get; set; }

    [Column("yes_line15_16_both_gains")]
    public bool? YesLine1516BothGains { get; set; }

    [Column("no_line15_16_both_gains")]
    public bool? NoLine1516BothGains { get; set; }

    [Column("rate_gain_28_line7", TypeName = "decimal(15, 2)")]
    public decimal? RateGain28Line7 { get; set; }

    [Column("unrecaptured_section1250_gain_line18", TypeName = "decimal(15, 2)")]
    public decimal? UnrecapturedSection1250GainLine18 { get; set; }

    [Column("yes_line18_19_zero_and_not_filing_form4952")]
    public bool? YesLine1819ZeroAndNotFilingForm4952 { get; set; }

    [Column("no_line18_19_zero_and_not_filing_form4952")]
    public bool? NoLine1819ZeroAndNotFilingForm4952 { get; set; }

    [Column("line16_loss", TypeName = "decimal(15, 2)")]
    public decimal? Line16Loss { get; set; }

    [Column("yes_qualified_dividends_line3a")]
    public bool? YesQualifiedDividendsLine3a { get; set; }

    [Column("no_qualified_dividends_line3a")]
    public bool? NoQualifiedDividendsLine3a { get; set; }

    [ForeignKey("ScheduleDMetadataId")]
    [InverseProperty("ScheduleDSummaries")]
    public virtual ScheduleDMetadatum? ScheduleDMetadata { get; set; }
}
