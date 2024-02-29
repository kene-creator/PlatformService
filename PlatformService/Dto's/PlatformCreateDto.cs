using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dto_s;

public record PlatformCreateDto
{
    [Required(ErrorMessage = "Name is required")]
    public required string Name { get; init; }

    [Required(ErrorMessage = "Publisher is required")]
    public required string Publisher { get; init; }

    [Required(ErrorMessage = "Cost is required")]
    public required string Cost { get; init; }
}