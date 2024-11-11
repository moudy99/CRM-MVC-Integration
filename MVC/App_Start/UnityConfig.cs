using BLL.Service.Movements;
using BLL.Service.Product;
using DAL.Repository.Movements;
using DAL.Repository.Product;
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


            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IProductRepository, ProductRepository>();

            container.RegisterType<IMovementsRepository, MovementsRepository>();
            container.RegisterType<IMovementsService, MovementsService>();
            // Set the dependency resolver for MVC
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}