using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcContactList.Controllers
{
    public class ContactListController : Controller
    {
        // 
        // GET: /ContactList/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /ContactList/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}