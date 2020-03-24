using blogcore.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogcore.Controllers
{
	[Controller]
	public class ArticlesController : Controller
	{

		public IActionResult index()
		{
			return View();
		}


	}
}
