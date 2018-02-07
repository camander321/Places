using Microsoft.AspNetCore.Mvc;
using Places.Models;

namespace Places.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("/")]
		public ActionResult Index()
		{
			return View("Index", Place.GetAll());
		}
		
		[HttpPost("/")]
		public ActionResult AddPlace()
		{
			string city = Request.Form["city"];
			if (city.Length > 0)
				new Place(city);
			
			return View("Index", Place.GetAll());
		}
		
		[HttpGet("/{city}")]
		public ActionResult Detail(string city)
		{
			return View("Detail", Place.Find(city));
		}
		
		[HttpGet("/form")]
		public ActionResult Form()
		{
			return View("Form");
		}
		
		[Route("/remove/{city}")]
		public ActionResult Remove(string city)
		{
			Place.Remove(city);
			return View("Index", Place.GetAll());
		}
	}
}