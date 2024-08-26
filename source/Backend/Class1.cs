using TDAmeritradeAPI;
using TDAmeritradeAPI.Models.Auth;
using TDAmeritradeAPI.Models.Accounts;

class Program
{
    static void Main(string[] args)
    {
        var client = new TDClient();

        // Authenticate with your TD Ameritrade developer credentials
        var auth = new TokenAuth("your_client_id", "your_redirect_uri", "your_access_token");
        client.Authenticate(auth);

        // Get account information
        var account = client.Accounts.GetAccount();
        Console.WriteLine($"Account number: {account.AccountId}");
        Console.WriteLine($"Account type: {account.AccountType}");
        Console.WriteLine($"Account value: {account.CurrentBalances.CashAvailableForTrading}");
    }
}