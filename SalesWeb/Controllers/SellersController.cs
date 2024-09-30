using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models;
using SalesWeb.Services;

namespace SalesWeb.Controllers
{
	public class SellersController : Controller
	{
		private readonly SellersService _sellersService;

		public SellersController(SellersService sellersService)
		{
			_sellersService = sellersService;
		}

		public IActionResult Index()
		{
			var list = _sellersService.FindAll();
			return View(list);
		}
		
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Seller seller)
		{
			_sellersService.Insert(seller);	
			return RedirectToAction(nameof(Index));
		}
	}
}
