using Tweetinvi;

namespace Console.NETCore_4._6._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Auth.SetUserCredentials("CONSUMER_KEY", "CONSUMER_SECRET", "ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");

            var user = User.GetAuthenticatedUser();

            System.Console.WriteLine(user);
            System.Console.ReadKey();
        }
    }
}
