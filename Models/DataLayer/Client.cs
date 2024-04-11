using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("clients")]
[Index("Ssn", Name = "UQ__clients__DDDF0AE6F0B08934", IsUnique = true)]
public partial class Client
{
    [Key]
    [Column("client_id")]
    public int ClientId { get; set; }

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

    [Column("suffix")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Suffix { get; set; }

    [Column("ssn")]
    [StringLength(11)]
    [Unicode(false)]
    public string Ssn { get; set; } = null!;

    [Column("birth_date", TypeName = "date")]
    public DateTime? BirthDate { get; set; }

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

    [Column("occupation")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Occupation { get; set; }

    [Column("routing_number")]
    [StringLength(9)]
    [Unicode(false)]
    public string? RoutingNumber { get; set; }

    [Column("account_number")]
    [StringLength(17)]
    [Unicode(false)]
    public string? AccountNumber { get; set; }

    [Column("checking")]
    public bool? Checking { get; set; }

    [Column("savings")]
    public bool? Savings { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [InverseProperty("Client")]
    public virtual ICollection<Appointment> Appointments { get; } = new List<Appointment>();

    [InverseProperty("Client")]
    public virtual ICollection<Form1040> Form1040s { get; } = new List<Form1040>();

    [InverseProperty("Client")]
    public virtual ICollection<Form1098e> Form1098es { get; } = new List<Form1098e>();

    [InverseProperty("Client")]
    public virtual ICollection<Invoice> Invoices { get; } = new List<Invoice>();

    [InverseProperty("Client")]
    public virtual ICollection<ScheduleDMetadatum> ScheduleDMetadata { get; } = new List<ScheduleDMetadatum>();

    [InverseProperty("Client")]
    public virtual ICollection<ScheduleK1> ScheduleK1s { get; } = new List<ScheduleK1>();

    [ForeignKey("UserId")]
    [InverseProperty("Clients")]
    public virtual User? User { get; set; }

    [InverseProperty("Client")]
    public virtual ICollection<W2> W2s { get; } = new List<W2>();
}
