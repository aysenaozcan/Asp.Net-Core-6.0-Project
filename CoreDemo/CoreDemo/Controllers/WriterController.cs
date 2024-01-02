using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class WriterController : Controller
	{
		[Authorize]
		public IActionResult Index()
		{
			return View();
		}
	}
}
