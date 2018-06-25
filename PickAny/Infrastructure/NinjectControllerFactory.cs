using Ninject;
using PickAny;
using PickAny_.Model;
using PickAny_.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using PickAny_.Logic.Interface;
using PickAny_.Logic.Service;

namespace PickAny.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            //Put Your Binding Contents Here...

            //ninjectKernel.Bind<IMaster>().To<EFMaster>();
            ninjectKernel.Bind<IIndustryMaster>().To<IndustryMasterServices>();
            ninjectKernel.Bind<IUserProfile>().To<UserProfileService>();
        }
    }

}