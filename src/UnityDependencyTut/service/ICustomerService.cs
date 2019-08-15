using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UnityDependencyTut.Models;

namespace UnityDependencyTut.service
{
  public interface ICustomerService
  {
    IEnumerable<Customer> GetTopCustomer(int code);
  }
}