using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models;
using SalesWeb.Models.ViewModels;
using SalesWeb.Services;

namespace SalesWeb.Controllers
{
	public class SellersController : Controller
	{
		private readonly SellersService _sellersService;

		private readonly DepartmentService _departmentService;

		public SellersController(SellersService sellersService, DepartmentService departmentService)
		{
			_sellersService = sellersService;
			_departmentService = departmentService;
		}

		public IActionResult Index()
		{
			var list = _sellersService.FindAll();
			return View(list);
		}
		
		public IActionResult Create()
		{
			var departments = _departmentService.FindAll();
			var VieWModel = new SellerFormViewModel { Departments = departments };
			return View(VieWModel);
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
