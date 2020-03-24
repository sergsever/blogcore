using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogcore.Data
{
	public abstract class AbstractDAO<TEntity, TKey> : IDAO<TEntity, TKey> where TEntity : class
	{
		private DbContext dbcontext;

		public AbstractDAO(DbContext dbcontext)
			{
				this.dbcontext = dbcontext;
			}


		public void Add(TEntity entity)
		{
			dbcontext.Add<TEntity>(entity);
		}

		public void Delete(TEntity entity)
		{
			dbcontext.Remove<TEntity>(entity);
		}

		public abstract IEnumerable<TEntity> getAll();
		

		public TEntity getById(TKey key)
		{
			throw new NotImplementedException();
		}

		public void Update(TEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
