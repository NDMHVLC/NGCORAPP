using Microsoft.AspNetCore.Mvc;
using NGCORAPP.Models;
using NGCORAPP.Operation;
using System.Diagnostics;

namespace NGCORAPP.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string GenerateShortLink([FromBody] Link _link)
        {
            GenerateLink generate = new GenerateLink();
            _link.ShortLink = generate.Generate();

            return _link.ShortLink;
        }


    }
}