using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.ObserverDP
{
    public    class InternetLoan : ILoanObserver
    {
        public void UpdateLoan(float loanAmount)
        {
            Console.WriteLine($"New Loan in Internet: {loanAmount}");
        }
    }
}
