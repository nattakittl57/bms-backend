namespace api.Models.Session;

public class UserSession
{
    public required string SessionId { get; set; }
    public required int UserId { get; set; }
    public required string Username { get; set; }
    public required string Token { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ExpiresAt { get; set; }
    public DateTime? LastAccessedAt { get; set; }
    public string? IpAddress { get; set; }
    public string? UserAgent { get; set; }
}
