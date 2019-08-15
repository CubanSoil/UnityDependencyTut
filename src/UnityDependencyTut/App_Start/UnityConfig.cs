using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using UnityDependencyTut.Repository;
using UnityDependencyTut.service;
using UnityDependencyTut.UnitOfWork;

namespace UnityDependencyTut
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			    var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      container.RegisterType<IUnitOfWork, UnitOfWork.UnitOfWork>();
      container.RegisterType<ICustomerRepo, CustomerRepo>();
      container.RegisterType<ICustomerService, CustomerService>();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}