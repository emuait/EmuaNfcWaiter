using Project.Core.Entities;
using System.Data.Entity;
using System.Linq;

namespace Project.Core.DataAccess.EntityFramework
{
	//Entity Framework İçin IQueryable İmplementasyonun Yapılması
	public class EfQueryableRepository<T> : IQueryableRepository<T>
		where T : class,   new()
	{
		private DbContext _context;
		private IDbSet<T> _entities;

		public EfQueryableRepository(DbContext context)
		{
			_context = context;
		}

		public IQueryable<T> Table => this.Entities;


		protected virtual IDbSet<T> Entities
		{
			get { return _entities ?? (_entities = _context.Set<T>()); }
		}
		//protected virtual IDbSet<T> Entities
		//{
		//    get
		//    {
		//        if (_entities==null)
		//        {
		//            _entities = _context.Set<T>();
		//        }
		//        return _entities;
		//    }

		//}
	}
}
