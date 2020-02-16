using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DependencyInjection.Version2.Entity
{
    public class LogToDb : ILogable
    {
        public void Log()
        {
            Console.WriteLine("Log to database");
        }
    }
}
