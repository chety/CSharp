using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutor.DependencyInjection.Version2.Entity;

namespace Tutor.DependencyInjection.Version2.NinjectImplementation
{
    public class InstanceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISaveable>().To<NHibernateDal>();
            Bind<ILogable>().To<LogToDb>();
        }
    }
}
