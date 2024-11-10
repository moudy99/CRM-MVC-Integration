using BLL.Service.Product;
using DAL.Repository.Product;
using System;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace MVC
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();


            // Register services
            container.RegisterType<IProductService, ProductService>();

            container.RegisterType<IProductRepository, ProductRepository>();
            // Set the dependency resolver for MVC
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}