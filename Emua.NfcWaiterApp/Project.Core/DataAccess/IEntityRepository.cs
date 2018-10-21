using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Project.Core.DataAccess
{
	//IEntityRepository Arayüzünün Oluşturulması
	public interface IEntityRepository<T> where T : class,  new()
	{
		List<T> GetList(Expression<Func<T, bool>> filter = null);

		T Get(Expression<Func<T, bool>> filter);

		T Add(T entity);

		T Update(T entity);

		void Delete(T entity);
	}
}
