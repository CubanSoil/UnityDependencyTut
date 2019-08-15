using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnityDependencyTut.Data;
using UnityDependencyTut.Models;

namespace UnityDependencyTut.Repository
{
  public class CustomerRepo : Repository<Customer>,ICustomerRepo
  {

    public CustomerRepo(MyDbContext context): base(context)
    {
    }
    public IEnumerable<Customer> GetTopCustomers(int count)
    {
      return MyDbContext.Users.OrderByDescending(c => c.Id).Take(count).ToList();
    }

    public MyDbContext MyDbContext {
      get
      {
        return Context as MyDbContext;
      }
    }
  }
}