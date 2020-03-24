using blogcore.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogcore.Controllers
{
	public class ArticlesAPIController : Controller
	{
		private ArtilclesDAO dao { get; set; }
		public ArticlesAPIController(ArtilclesDAO dao)
		{
			this.dao = dao;
		}
		[HttpGet]
		public IActionResult getAll()
		{
			IEnumerable<Article> res = dao.getAll();
			return Json(res);
		}
	}
}
