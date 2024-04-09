using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("schedule_d_metadata")]
public partial class ScheduleDMetadatum
{
    [Key]
    [Column("schedule_d_metadata_id")]
    public int ScheduleDMetadataId { get; set; }

    [Column("client_id")]
    public int? ClientId { get; set; }

    [Column("tax_year")]
    public int? TaxYear { get; set; }

    [Column("yes_disposal_of_opportunity_fund")]
    public bool? YesDisposalOfOpportunityFund { get; set; }

    [Column("no_disposal_of_opportunity_fund")]
    public bool? NoDisposalOfOpportunityFund { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("ScheduleDMetadata")]
    public virtual Client? Client { get; set; }

    [InverseProperty("ScheduleDMetadata")]
    public virtual ICollection<ScheduleDLongTerm> ScheduleDLongTerms { get; set; } = new List<ScheduleDLongTerm>();

    [InverseProperty("ScheduleDMetadata")]
    public virtual ICollection<ScheduleDShortTerm> ScheduleDShortTerms { get; set; } = new List<ScheduleDShortTerm>();

    [InverseProperty("ScheduleDMetadata")]
    public virtual ICollection<ScheduleDSummary> ScheduleDSummaries { get; set; } = new List<ScheduleDSummary>();
}
