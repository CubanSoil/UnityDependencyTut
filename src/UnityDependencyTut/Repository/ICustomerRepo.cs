using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityDependencyTut.Models;

namespace UnityDependencyTut.Repository
{
  public interface ICustomerRepo
  {
    IEnumerable<Customer> GetTopCustomers(int count);

  }
}
