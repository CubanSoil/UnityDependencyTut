using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UnityDependencyTut.Data;

namespace UnityDependencyTut.Repository
{
  public class Repository<T> : IRepository<T>
    where T : class
  {
    protected readonly  DbContext Context;


    public Repository(DbContext context)
    {
      Context = context;
    }

    public IEnumerable<T> GetAll()
    {
      return Context.Set<T>().ToList();
    }

    public T GetById(object id)
    {
      return Context.Set<T>().Find(id);
    }
  }
}