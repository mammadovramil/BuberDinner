namespace BuberDinner.Contracts.Authentication;

public record RegisterRequet(
    string FirstName,
    string LastName,
    string Email,
    string Password);