using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutor.DependencyInjection.Entity;
using Tutor.DependencyInjection.Version1.Entity;

namespace Tutor.DependencyInjection.Version1.Business
{
    public class ProductManager
    {
        private LogManager _logManager;
        private EFDal _efDal;

        /// <summary>
        /// Our product manager is tight coupled with LogManager and EfDal
        /// If we want to change log or DAl class later we have to 
        /// change lots of places. Second version is coming later on.
        /// </summary>
        public ProductManager()
        {
            _logManager = new LogManager();
            _efDal = new EFDal();
        }

        public void SaveProduct()
        {
            _efDal.SaveToDatabase();
            _logManager.Log();
        }
    }
}
