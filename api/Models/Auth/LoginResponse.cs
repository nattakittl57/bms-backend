namespace api.Models.Auth;

public class LoginResponse
{
    public required string Token { get; set; }
    public required string RefreshToken { get; set; }
    public required int UserId { get; set; }
    public required string Username { get; set; }
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Nickname { get; set; }
    public string? Email { get; set; }
    public string? PositionName { get; set; }
    public int UsertypeId { get; set; }
    public int? CmpId { get; set; }
    public string? CompanyName { get; set; }
    public DateTime ExpiresAt { get; set; }
}
