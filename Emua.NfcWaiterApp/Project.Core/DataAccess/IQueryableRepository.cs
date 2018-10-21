using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.DataAccess
{
	//IQueryableRepository Arayüzünün Yazılması
	public interface IQueryableRepository<T> where T : class,  new()
	{
		IQueryable<T> Table { get; }
	}
}
