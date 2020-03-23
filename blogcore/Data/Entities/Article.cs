using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogcore.Data.Entities
{	
	public class Article
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }
	}
}
