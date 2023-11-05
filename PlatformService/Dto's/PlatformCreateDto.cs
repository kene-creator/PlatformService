using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dto_s;

public class PlatformCreateDto
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
        
    [Required(ErrorMessage = "Publisher is required")]
    public string Publisher { get; set; }
        
    [Required(ErrorMessage = "Cost is required")]
    public string Cost { get; set; }
}