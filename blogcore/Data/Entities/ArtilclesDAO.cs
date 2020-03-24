using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogcore.Data.Entities
{
	public class ArtilclesDAO : AbstractDAO<Article, int>
	{
		private DataContext dbcontext { get; set; }
		public ArtilclesDAO(DataContext dbcontext) : base(dbcontext)
		{
			this.dbcontext = dbcontext;
		}
			public override IEnumerable<Article> getAll()
		{
			IEnumerable<Article> res = dbcontext.Articles.Where(e => e.Id != 0).ToList();
				return res;
		}
		}
}

