using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;


namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidator wv = new WriterValidator();
			ValidationResult results = wv.Validate(p);
			if (results.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "Deneme test";
				p.WriterImage = "varsayilan_resim.jpg";
				wm.WriterAdd(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();


		}
	}
}
