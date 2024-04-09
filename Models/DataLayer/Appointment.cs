using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("appointments")]
public partial class Appointment
{
    [Key]
    [Column("appointment_id")]
    public int AppointmentId { get; set; }

    [Column("client_id")]
    public int? ClientId { get; set; }

    [Column("employee_id")]
    public int? EmployeeId { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("time")]
    public TimeOnly? Time { get; set; }

    [Column("purpose")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Purpose { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("Appointments")]
    public virtual Client? Client { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("Appointments")]
    public virtual Employee? Employee { get; set; }
}
