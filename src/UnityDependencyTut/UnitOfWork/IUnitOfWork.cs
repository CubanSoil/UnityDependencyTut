using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityDependencyTut.Repository;

namespace UnityDependencyTut.UnitOfWork
{
  public interface IUnitOfWork:IDisposable
  {
    ICustomerRepo Customers { get; }
    int Complete();
  }
}
