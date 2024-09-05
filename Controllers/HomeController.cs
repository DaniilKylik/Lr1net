using Lr1net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lr1net.Controllers
{
    public class HomeController : Controller
    {
		public IActionResult Index()
		{
            // Завдання: 2
            // var random = new Random();
            //int randomNumber = random.Next(0, 101);

            var company = new Company
			{
                text1 = "Daniil",
                text2 = "Kylik",
				number = 19 // randomNumber
            };
			return View(company);
		}
	}
}
