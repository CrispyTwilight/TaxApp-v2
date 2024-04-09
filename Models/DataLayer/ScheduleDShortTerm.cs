using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("schedule_d_short_term")]
public partial class ScheduleDShortTerm
{
    [Key]
    [Column("schedule_d_short_term_id")]
    public int ScheduleDShortTermId { get; set; }

    [Column("schedule_d_metadata_id")]
    public int? ScheduleDMetadataId { get; set; }

    [Column("form1099b_proceeds", TypeName = "decimal(15, 2)")]
    public decimal? Form1099bProceeds { get; set; }

    [Column("form1099b_cost", TypeName = "decimal(15, 2)")]
    public decimal? Form1099bCost { get; set; }

    [Column("form1099b_adjustment", TypeName = "decimal(15, 2)")]
    public decimal? Form1099bAdjustment { get; set; }

    [Column("form1099b_gain_loss", TypeName = "decimal(15, 2)")]
    public decimal? Form1099bGainLoss { get; set; }

    [Column("form8949_box_a_proceeds", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxAProceeds { get; set; }

    [Column("form8949_box_a_cost", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxACost { get; set; }

    [Column("form8949_box_a_adjustment", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxAAdjustment { get; set; }

    [Column("form8949_box_a_gain_loss", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxAGainLoss { get; set; }

    [Column("form8949_box_b_proceeds", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxBProceeds { get; set; }

    [Column("form8949_box_b_cost", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxBCost { get; set; }

    [Column("form8949_box_b_adjustment", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxBAdjustment { get; set; }

    [Column("form8949_box_b_gain_loss", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxBGainLoss { get; set; }

    [Column("form8949_box_c_proceeds", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxCProceeds { get; set; }

    [Column("form8949_box_c_cost", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxCCost { get; set; }

    [Column("form8949_box_c_adjustment", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxCAdjustment { get; set; }

    [Column("form8949_box_c_gain_loss", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxCGainLoss { get; set; }

    [Column("gain_loss_forms6252_4684_6781_8824", TypeName = "decimal(15, 2)")]
    public decimal? GainLossForms6252468467818824 { get; set; }

    [Column("net_gain_loss_schedule_k1", TypeName = "decimal(15, 2)")]
    public decimal? NetGainLossScheduleK1 { get; set; }

    [Column("capital_loss_carryover", TypeName = "decimal(15, 2)")]
    public decimal? CapitalLossCarryover { get; set; }

    [Column("net_short_term_capital_gain_loss", TypeName = "decimal(15, 2)")]
    public decimal? NetShortTermCapitalGainLoss { get; set; }

    [ForeignKey("ScheduleDMetadataId")]
    [InverseProperty("ScheduleDShortTerms")]
    public virtual ScheduleDMetadatum? ScheduleDMetadata { get; set; }
}
