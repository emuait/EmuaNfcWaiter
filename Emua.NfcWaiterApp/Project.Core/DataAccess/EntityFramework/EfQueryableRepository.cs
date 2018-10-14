﻿using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.DataAccess.EntityFramework
{
	//Entity Framework İçin IQueryable İmplementasyonun Yapılması
	public class EfQueryableRepository<T> : IQueryableRepository<T>
		where T : class, IEntity, new()
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
