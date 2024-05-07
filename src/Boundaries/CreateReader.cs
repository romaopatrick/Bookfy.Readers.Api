namespace Bookfy.Readers.Api.Boundaries;

public class CreateReader
{
    public required string Username { get; set; }
    public string? Name { get; set; }
    public required string Email { get; set; }
}