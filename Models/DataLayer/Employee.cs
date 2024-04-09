using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("employees")]
[Index("UserId", Name = "UQ__employee__B9BE370E68C1FB5A", IsUnique = true)]
public partial class Employee
{
    [Key]
    [Column("employee_id")]
    public int EmployeeId { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("first_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [Column("middle_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [Column("last_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

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

    [Column("home_phone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? HomePhone { get; set; }

    [Column("mobile_phone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? MobilePhone { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [InverseProperty("Employee")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    [InverseProperty("Employee")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [ForeignKey("UserId")]
    [InverseProperty("Employee")]
    public virtual User? User { get; set; }
}
