using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models;

public class ServiceCategories
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public Category? Category { get; set; }

    [Required]
    public int ServiceId { get; set; }
    [ForeignKey(nameof(ServiceId))]
    public Services? Service { get; set; }        
}
