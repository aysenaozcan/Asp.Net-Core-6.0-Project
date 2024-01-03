using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.BlogLastThreePosts
{
	public class BlogLastThreePosts: ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			var values = bm.GetListThreeBlog(); //daha sonra id yazılacak
			return View(values);
		}
	}
}
