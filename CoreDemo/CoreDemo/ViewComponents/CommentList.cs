using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					Id = 1,
					Username="Aysena"
				},
				new UserComment
				{
					Id = 2,
					Username="Aysena"
				},
				new UserComment
				{
					Id = 3,
					Username="Aysena"
				}

			};
			return View(commentvalues);	
		}
	}
}
