using FinalProject.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models;

public class Order
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "datetime")]
    public DateTime DateCreated { get; set; } = DateTime.Now;

    [Required]
    [Column(TypeName = "decimal(9,2)")]
    public double Subtotal { get; set; }

    [Required]
    [Column(TypeName = "decimal(9,2)")]
    public double Tax { get; set; }

    [Required]
    [Column(TypeName = "decimal(9,2)")]
    public double Total { get; set; }

    [ForeignKey(nameof(UserId))]
    public ApplicationUser? User { get; set; }
    [Column(TypeName = "nvarchar(450)")]
    public string? UserId { get; set; }
}
