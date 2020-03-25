using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogcore.Data
{
	public interface IDAO<TEntity, TKey> where TEntity : class
	{
		IEnumerable<TEntity> getAll();
		TEntity getById(TKey key);
		void Add(TEntity entity);
		void Delete(TEntity entity);
		void Update(TEntity entity);
		TEntity getLast();

	}
}
