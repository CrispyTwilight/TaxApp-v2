using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("schedule_d_long_term")]
public partial class ScheduleDLongTerm
{
    [Key]
    [Column("schedule_d_long_term_id")]
    public int ScheduleDLongTermId { get; set; }

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

    [Column("form8949_box_d_proceeds", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxDProceeds { get; set; }

    [Column("form8949_box_d_cost", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxDCost { get; set; }

    [Column("form8949_box_d_adjustment", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxDAdjustment { get; set; }

    [Column("form8949_box_d_gain_loss", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxDGainLoss { get; set; }

    [Column("form8949_box_e_proceeds", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxEProceeds { get; set; }

    [Column("form8949_box_e_cost", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxECost { get; set; }

    [Column("form8949_box_e_adjustment", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxEAdjustment { get; set; }

    [Column("form8949_box_e_gain_loss", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxEGainLoss { get; set; }

    [Column("form8949_box_f_proceeds", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxFProceeds { get; set; }

    [Column("form8949_box_f_cost", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxFCost { get; set; }

    [Column("form8949_box_f_adjustment", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxFAdjustment { get; set; }

    [Column("form8949_box_f_gain_loss", TypeName = "decimal(15, 2)")]
    public decimal? Form8949BoxFGainLoss { get; set; }

    [Column("gain_loss_forms4797_2439_6252_4684_6781_8824", TypeName = "decimal(15, 2)")]
    public decimal? GainLossForms479724396252468467818824 { get; set; }

    [Column("net_gain_loss_schedule_k1", TypeName = "decimal(15, 2)")]
    public decimal? NetGainLossScheduleK1 { get; set; }

    [Column("capital_gain_distributions", TypeName = "decimal(15, 2)")]
    public decimal? CapitalGainDistributions { get; set; }

    [Column("capital_loss_carryover", TypeName = "decimal(15, 2)")]
    public decimal? CapitalLossCarryover { get; set; }

    [Column("net_long_term_capital_gain_loss", TypeName = "decimal(15, 2)")]
    public decimal? NetLongTermCapitalGainLoss { get; set; }

    [ForeignKey("ScheduleDMetadataId")]
    [InverseProperty("ScheduleDLongTerms")]
    public virtual ScheduleDMetadatum? ScheduleDMetadata { get; set; }
}
