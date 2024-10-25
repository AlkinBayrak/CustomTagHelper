using Microsoft.AspNetCore.Mvc;
using MVCIQueryString.UI.Models;

namespace MVCIQueryString.UI.Controllers
{
	public class OgrenciController : Controller
	{
		private static List<Ogrenci> ogrenciler = new List<Ogrenci>()
		{
			new Ogrenci{Id = 1,Ad = "Alkın"},
			new Ogrenci{Id = 2,Ad = "Meltem"}
		};
		public IActionResult Yeni()
		{
			return View();
		}
		public IActionResult Ekle(string ad)
		{
			if(!string.IsNullOrWhiteSpace(ad))
			{
				var yeniOgrenci = new Ogrenci
				{
					Id = ogrenciler.Count + 1,
					Ad = ad
				};
				ogrenciler.Add(yeniOgrenci);
			}
			
			return RedirectToAction("Liste");
		}

		public IActionResult Liste()
		{
			ViewData["Ogrenciler"] = ogrenciler;
			return View();
		}

		public IActionResult Detay(int id)
		{
			var ogrenci = ogrenciler.FirstOrDefault(o => o.Id == id);
			return View(ogrenci);
		}
	}
}
