using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models;

public class Services
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(200, MinimumLength = 2)]
    public string Title { get; set; }

    [Required]
    [Column(TypeName = "decimal(9,2)")]
    public double Price { get; set; }

    [Column(TypeName = "ntext")]
    public string? Description { get; set; }

    [Required]
    public int LecturerId { get; set; }
    [ForeignKey(nameof(LecturerId))]
    public Lecturer? Lecturer { get; set; }

}
