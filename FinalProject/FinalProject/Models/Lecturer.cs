using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models;

public class Lecturer
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(200, MinimumLength = 2)]
    public string Title { get; set; }

    [Column(TypeName = "ntext")]
    public string? Bio { get; set; }

    [Required]
    [StringLength(200)]
    public string ContactEmail { get; set; }

    [Column(TypeName = "ntext")]
    public string? Image { get; set; }
}
