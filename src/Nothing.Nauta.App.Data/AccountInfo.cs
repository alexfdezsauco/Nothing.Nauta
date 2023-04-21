namespace Nothing.Nauta.App.Data;

public class AccountInfo
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public AccountType AccountType { get; set; } = AccountType.International;

    //fpublic TimeSpan Rem
}