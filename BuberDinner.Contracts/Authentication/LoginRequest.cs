namespace BuberDinner.Contracts.Authentication;

public record LoginRequet(
    string Email,
    string Password);