using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DependencyInjection.Version2.NinjectImplementation
{
    public class InstanceFactory
    {
        public static IKernel _kernel { get; set; }

        public static T GetInstance<T>()
        {
            _kernel = new StandardKernel(new InstanceModule());
            return _kernel.Get<T>();
        }
    }
}
