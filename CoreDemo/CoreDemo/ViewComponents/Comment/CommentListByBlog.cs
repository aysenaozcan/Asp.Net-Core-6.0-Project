using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Comment
{
	public class CommentListByBlog:ViewComponent
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IViewComponentResult Invoke()
		{
			var values = cm.GetList(2);
			return View(values);
		}
	}
}
