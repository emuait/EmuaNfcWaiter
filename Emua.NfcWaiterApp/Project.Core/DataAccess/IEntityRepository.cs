using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Project.Core.DataAccess
{
	//IEntityRepository Arayüzünün Oluşturulması
	public interface IEntityRepository<T> where T : class, new()
	{
		List<T> GetList(Expression<Func<T, bool>> filter = null);

		List<T> GetListInclude(Expression<Func<T, bool>> filter = null, string[] includes = null);

		T Get(Expression<Func<T, bool>> filter);

		T GetInclude(Expression<Func<T, bool>> filter, string[] includes = null);

		T Add(T entity);

		T Update(T entity);

		void Delete(T entity);
	}
}
