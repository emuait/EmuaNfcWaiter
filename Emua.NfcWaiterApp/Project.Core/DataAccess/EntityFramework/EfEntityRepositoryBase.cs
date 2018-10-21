using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Project.Core.DataAccess.EntityFramework
{
	//Entity Framework İmplementasyonunun Gerçekleştirilmesi
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
		where TEntity : class,  new()
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

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (var context = new TContext())
			{
				return context.Set<TEntity>().SingleOrDefault(filter);
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

		//public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
		//{
		//	using (var context = new TContext())
		//	{
		//		return filter == null
		//			? context.Set<TEntity>().ToListAsync()
		//			: context.Set<TEntity>().Where(filter).ToListAsync();
		//	}
		//}

		//public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
		//{
		//	using (var context = new TContext())
		//	{
		//		return context.Set<TEntity>().SingleOrDefaultAsync(filter);
		//	}
		//}

		//public Task<TEntity> AddAsync(Task<TEntity> entity)
		//{
		//	using (var context = new TContext())
		//	{
		//		var addedEntity = context.Entry(entity);
		//		addedEntity.State = EntityState.Added;
		//		context.SaveChangesAsync();
		//		return entity;
		//	}
		//}

		//public Task<TEntity> UpdateAsync(Task<TEntity> entity)
		//{
		//	using (var context = new TContext())
		//	{
		//		var updatedEntity = context.Entry(entity);
		//		updatedEntity.State = EntityState.Modified;
		//		context.SaveChangesAsync();
		//		return entity;
		//	}
		//}

		//public void DeleteAsync(Task<TEntity> entity)
		//{
		//	using (var context = new TContext())
		//	{
		//		var deleteEntity = context.Entry(entity);
		//		deleteEntity.State = EntityState.Deleted;
		//		context.SaveChangesAsync();
		//	}
		//}

	}
}
