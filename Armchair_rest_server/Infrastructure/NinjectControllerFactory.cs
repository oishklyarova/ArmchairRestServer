using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using System.Web.Routing;
using Armchair_rest_server.Models;

namespace Armchair_rest_server.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory(IKernel kernel)
        {
            // создание контейнера
            ninjectKernel = kernel;
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            // получение объекта контроллера из контейнера 
            // используя его тип
            return controllerType == null
              ? null
              : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            // конфигурирование контейнера
            ninjectKernel.Bind<IFurnitureRepository>().To<FurnitureRepository>();
            ninjectKernel.Bind<IFeedbackRepository>().To<FeedbackRepository>();
            ninjectKernel.Bind<IFurnitureWithLikeRepository>().To<FurnitureWithLikeRepository>();
            ninjectKernel.Bind<ILikedRepository>().To<LikedRepository>();
            ninjectKernel.Bind<IPromotionRepository>().To<PromotionRepository>();
        }
    }
}