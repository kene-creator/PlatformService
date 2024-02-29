namespace PlatformService.Dto_s
{
    public record PlatformReadDto
    {
        public int Id { get; init; }

        public required string Name { get; init; }

        public required string Publisher { get; init; }

        public required string Cost { get; init; }
    }
}