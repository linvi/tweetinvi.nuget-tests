using Tweetinvi;

namespace Console.NET_4._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auth.SetUserCredentials("CONSUMER_KEY", "CONSUMER_SECRET", "ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");

            var user = User.GetAuthenticatedUser();

            System.Console.WriteLine(user);
            System.Console.ReadKey();
        }
    }
}
