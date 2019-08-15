using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UnityDependencyTut.Models;
using UnityDependencyTut.UnitOfWork;

namespace UnityDependencyTut.service
{
  public class CustomerService: ICustomerService
  {
    private readonly IUnitOfWork _unitOfWork;
    public CustomerService(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    public IEnumerable<Customer> GetTopCustomer(int code)
    {
      return _unitOfWork.Customers.GetTopCustomers(code);
    }
  }
}