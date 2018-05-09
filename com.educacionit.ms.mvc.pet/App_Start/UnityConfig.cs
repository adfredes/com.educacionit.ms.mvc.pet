using com.educacionit.ms.pet.dataaccess;
using com.educacionit.ms.pet.dataaccess.Interfaces;
using com.educacionit.ms.pet.dataaccess.Repositories;
using com.educacionit.ms.pet.services.ImplementServices;
using com.educacionit.ms.pet.services.Interfaces;
using System;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using Unity;

namespace com.educacionit.ms.mvc.pet
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();            
            container.RegisterType<IAdopterService, AdopterServiceImp>();
            container.RegisterType<IAdopterRepository, AdopterRepository>();

            container.RegisterType<IAdoptionService, AdoptionServiceImp>();
            container.RegisterType<IAdoptionRepository, AdoptionRepository>();

            container.RegisterType<IOwnerService, OwnerServiceImp>();
            container.RegisterType<IOwnerRepository, OwnerRepository>();

            container.RegisterType<IPetService, PetServiceImp>();
            container.RegisterType<IPetRepository, PetRepository>();

            container.RegisterType<DbContext, PetsDbContext>();

            container.RegisterType<IUnitOfWork, UnitOfWork>();


        }

        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            RegisterTypes(container);                        
            DependencyResolver.SetResolver(new Unity.AspNet.Mvc.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.AspNet.WebApi.UnityDependencyResolver(container);
        }
    }
}