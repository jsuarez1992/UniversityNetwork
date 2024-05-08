using System.ComponentModel.DataAnnotations;

namespace UniversityLayout.Model.DataAnnotations;

public class FormA
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    public string City { get; set; }
}
