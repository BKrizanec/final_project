using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models;

public class OrderServices
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int OrderId { get; set; }
    [ForeignKey(nameof(OrderId))]
    public Order Order { get; set; }

    [Required]
    public int ServiceId { get; set; }
    [ForeignKey(nameof(ServiceId))]
    public Services Services { get; set; }

    [Required]
    [StringLength(200, MinimumLength = 2)]
    public string ServiceTitle { get; set; }

    [Required]
    [Column(TypeName = "decimal(9,2)")]
    public double Quantity { get; set; }

    [Required]
    [Column(TypeName = "decimal(9,2)")]
    public double Price { get; set; }

    [Required]
    [Column(TypeName = "decimal(9,2)")]
    public double Total { get; set; }
}
