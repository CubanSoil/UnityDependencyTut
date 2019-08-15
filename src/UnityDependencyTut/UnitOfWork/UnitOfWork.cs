using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnityDependencyTut.Data;
using UnityDependencyTut.Repository;

namespace UnityDependencyTut.UnitOfWork
{
  public class UnitOfWork:IUnitOfWork
  {
    private readonly MyDbContext _context;

    public UnitOfWork(MyDbContext context)
    {
      _context = context;
      Customers = new CustomerRepo(_context);

    }
    public void Dispose()
    {
     _context.Dispose();
    }

    public ICustomerRepo Customers { get; private set; }
    public int Complete()
    {
      return _context.SaveChanges();
    }
  }
}