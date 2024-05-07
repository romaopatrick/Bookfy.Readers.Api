
namespace Bookfy.Readers.Api.Domain;

public class Reader
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; }
    public required string Username { get; set; }
    public string? Name { get; set; }
    public required string Email { get; set; }
    public IDictionary<string, string> Settings { get; set; } = new Dictionary<string, string>();
    public required ReaderStats Stats { get; set; }
    public List<Guid> FollowersIds { get; set; } = [];
    public List<Guid> FollowingIds { get; set; } = [];
    public List<Guid> FriendsIds { get; set; } = [];
    public string? ProfilePictureUrl { get; set; }
    public Guid PostsHistoryId { get; set; }
    public Guid ReviewHistoryId { get; set; }
    public Guid LibraryId { get; set; }
}