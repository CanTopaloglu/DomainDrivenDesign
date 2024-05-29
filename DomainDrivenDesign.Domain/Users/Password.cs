namespace DomainDrivenDesign.Domain.Users;

public sealed record Password
{
    public string Value { get; init; }

    public Password(string value)
    {
        if(value.Length < 6)
        {
            throw new ArgumentException("Password needs to be atleast 6 characters");
        }

        Value = value;
    }

}
