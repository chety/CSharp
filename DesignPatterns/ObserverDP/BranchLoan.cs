using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.ObserverDP
{
    public    class BranchLoan : ILoanObserver
    {
        public void UpdateLoan(float loanAmount)
        {
            Console.WriteLine($"New Loan in Branch: {loanAmount}");
        }
    }
}
