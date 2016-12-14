using System.Web.Mvc;
using Tweetinvi;

namespace ASP.NET._4._6._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Auth.SetUserCredentials("CONSUMER_KEY", "CONSUMER_SECRET", "ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");
            var user = Tweetinvi.User.GetAuthenticatedUser();

            ViewBag.User = user.Name;

            return View();
        }
    }
}