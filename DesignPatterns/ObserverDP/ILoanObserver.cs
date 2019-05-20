using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.ObserverDP
{
   public    interface ILoanObserver
   {
       void UpdateLoan(float loanAmount);
   }
}
