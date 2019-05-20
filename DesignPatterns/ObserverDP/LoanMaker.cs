using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.ObserverDP
{
    class LoanMaker
    {
        private static void Main1(string[] args)
        {
            var loanManager = new LoanManager("Chety Bank", "Home", 1.35f);
            var internet = new InternetLoan();
            var branch = new BranchLoan();

            loanManager.AddObserver(internet);
            loanManager.AddObserver(branch);
            loanManager.LoanAmount = 2.00f;

            loanManager.RemoveObserver(branch);
            loanManager.LoanAmount = 1.65f;

            Console.ReadLine();
        }
    }
}
