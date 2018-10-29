using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Project.Core.DataAccess.EntityFramework
{
	//Entity Framework İmplementasyonunun Gerçekleştirilmesi
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
		where TEntity : class, new()
		where TContext : DbContext, new()
	{
		public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
		{
			using (var context = new TContext())
			{
				return filter == null
							? context.Set<TEntity>().ToList()
							: context.Set<TEntity>().Where(filter).ToList();
			}
		}

		public List<TEntity> GetListInclude(Expression<Func<TEntity, bool>> filter = null, string[] includes = null)
		{
			using (var context = new TContext())
			{
				var query = context.Set<TEntity>().AsQueryable();
				if (includes != null)
				{
					foreach (var include in includes)
					{
						var set = filter == null
							? query = query.Include(include)
							: query = query.Include(include).Where(filter);
					}
				}
				else
				{
					var set = filter == null
							? context.Set<TEntity>()
							: context.Set<TEntity>().Where(filter);
				}
				return query.ToList();
			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (var context = new TContext())
			{
				return context.Set<TEntity>().SingleOrDefault(filter);
			}
		}

		public TEntity GetInclude(Expression<Func<TEntity, bool>> filter, string[] includes)
		{
			using (var context = new TContext())
			{
				//return context.Set<TEntity>().SingleOrDefault(filter);

				var query = context.Set<TEntity>().AsQueryable();
				if (includes != null)
				{
					foreach (var include in includes)
					{
						var set = filter == null
							? query = query.Include(include)
							: query = query.Include(include).Where(filter);
					}
				}
				else
				{
					var set = filter == null
							? context.Set<TEntity>()
							: context.Set<TEntity>().Where(filter);
				}
				return query.SingleOrDefault();
			}
		}

		public TEntity Add(TEntity entity)
		{
			using (var context = new TContext())
			{
				var addedEntity = context.Entry(entity);
				addedEntity.State = EntityState.Added;
				context.SaveChanges();
				return entity;
			}
		}

		public TEntity Update(TEntity entity)
		{
			using (var context = new TContext())
			{
				var updatedEntity = context.Entry(entity);
				updatedEntity.State = EntityState.Modified;
				context.SaveChanges();
				return entity;
			}
		}

		public void Delete(TEntity entity)
		{
			using (var context = new TContext())
			{
				var deleteEntity = context.Entry(entity);
				deleteEntity.State = EntityState.Deleted;
				context.SaveChanges();
			}
		}
	}
}
