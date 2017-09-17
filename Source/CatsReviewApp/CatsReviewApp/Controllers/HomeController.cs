namespace CatsReviewApp.Controllers
{
    using System;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.MachineName = Environment.GetEnvironmentVariable("COMPUTERNAME");
            return this.View();
        }
    }
}