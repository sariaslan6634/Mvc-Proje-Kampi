﻿using DataAccessLayer.Abstract;
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
	public class WriterRepository : IWriterDal
	{
		Context context = new Context();
		DbSet<Writer> _object;
			
		public void Delete(Writer p)
		{
			throw new NotImplementedException();
		}

		public void Insert(Writer p)
		{
			throw new NotImplementedException();
		}

		public List<Writer> List(Writer p)
		{
			throw new NotImplementedException();
		}

		public List<Writer> List(Expression<Func<Writer, bool>> Filter)
		{
			throw new NotImplementedException();
		}

		public void Update(Writer p)
		{
			throw new NotImplementedException();
		}
	}
}
