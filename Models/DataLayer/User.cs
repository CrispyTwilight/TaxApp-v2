using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaxApp_v2.Models.DataLayer;

[Table("users")]
public partial class User
{
    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [Column("username")]
    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("password_hash")]
    [StringLength(64)]
    [Unicode(false)]
    public string PasswordHash { get; set; } = null!;

    [Column("role")]
    [StringLength(18)]
    [Unicode(false)]
    public string Role { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    [InverseProperty("User")]
    public virtual Employee? Employee { get; set; }
}
