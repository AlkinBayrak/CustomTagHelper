using Microsoft.AspNetCore.Mvc;
using MVCIAttributeRoute.UI.Models;

namespace MVCIAttributeRoute.UI.Controllers
{
	[Route("Kullanici")]
	public class UserController : Controller
    {
        private static List<User> users = new List<User>()
        {
            new User {Id = 1, Name = "Alkın" , Email = "alkin@mail.com"},
            new User {Id = 2, Name = "Meltem" , Email = "meltem@mail.com"}
        };

        [HttpGet("Listele")]
        public IActionResult List()
        {
            ViewData["users"] = users;

            return View();
        }

        [HttpGet("Ekle")]
        public IActionResult Ekle()
        {
            return View();
        }

		[HttpPost("Ekle")]
		public IActionResult Ekle(User user)
		{
            user.Id = users.Count + 1;
			users.Add(user);
            return RedirectToAction("List");

		}
	}
}
