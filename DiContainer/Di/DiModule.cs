using DiContainer.Services;
using DiContainer.Services.Resources;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiContainer.Di
{
    public class DiModuleHttp : NinjectModule
    {
        public override void Load()
        {
            Bind<IApiResource>().To<ApiHttpResource>().WithConstructorArgument("domain", Properties.Settings.ApiDomain);
        }
    }
}
