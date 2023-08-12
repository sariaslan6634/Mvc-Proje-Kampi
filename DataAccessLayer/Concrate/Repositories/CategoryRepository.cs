using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.Repositories
{
	public class CategoryRepository : ICategoryDal
	{
		Context context = new Context();
		DbSet<Category> _object;

		public void Delete(Category p)
		{
			_object.Remove(p);	
			context.SaveChanges();
		}

		public void Insert(Category p)
		{
			_object.Add(p);
			context.SaveChanges();
		}

		public List<Category> List(Category p)
		{
			return _object.ToList();
		}

		public List<Category> List(Expression<Func<Category, bool>> Filter)
		{
			throw new NotImplementedException();
		}

		public void Update(Category p)
		{
			context.SaveChanges();
		}
	}
}
