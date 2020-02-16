using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutor.DependencyInjection.Version2.Entity;

namespace Tutor.DependencyInjection.Version2.Business
{
    public class ProductManagerDI
    {
        private ILogable _log;
        private ISaveable _save;

        public ProductManagerDI(ILogable log, ISaveable save)
        {
            _log = log;
            _save = save;
        }
        public void SaveProduct()
        {
            _save.Save();
            _log.Log();
        }
    }
}
