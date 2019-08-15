using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UnityDependencyTut.Models;

namespace UnityDependencyTut.Data
{
  public class MyDbContext : DbContext
  {
    public MyDbContext()
      : base("DefaultConnection")
    {
    }
    //Every time you need to add new Table you add them here.
    public DbSet<Customer> Users { get; set; }

  }
}