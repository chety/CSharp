using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DependencyInjection.Version2.Entity
{
    public class EfDal : ISaveable
    {
        public void Save()
        {
            Console.WriteLine("Save to database via Entity Framework");
        }
    }
}
