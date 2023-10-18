using Microsoft.AspNetCore.Mvc;
using NewsWebsit.Models;
using System.Diagnostics;

namespace NewsWebsit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
            NewsContext db;
        private readonly IWebHostEnvironment webHostEnvironment;
        public HomeController(ILogger<HomeController> logger ,NewsContext context , IWebHostEnvironment webHostEnvironment   )
        {
            _logger = logger;
            db = context;
            
        }

      
       
       
        public IActionResult Index()
        {

            
          
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Messages()
        {
            var result2 = db.Contacts.ToList();
            return View(result2);
            
        }

        [HttpPost]
        public IActionResult SaveContact(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveTeam(Members members)
        {

            db.Members.Add(members);
            db.SaveChanges();

            return RedirectToAction("Team");
        }
        public IActionResult Team()
        {
            
            var result1= db.Members.ToList();
            return View(result1);
        }
       /* public string uploadDir( Members m)
        {
            string imgname = null;
            if(m.image != null)
            {

                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "photos");
                imgname = Guid.NewGuid().ToString()+"-" m.image.fil   

            }
            return View();
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}