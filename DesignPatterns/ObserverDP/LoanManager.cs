using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DesignPatterns.ObserverDP
{
    public class LoanManager : IObserver
    {
        private float _loanAmount;
        private List<ILoanObserver> _loanObservers;
        public List<ILoanObserver> LoanObservers => _loanObservers ?? (_loanObservers = new List<ILoanObserver>());

        public string Bank { get; set; }
        public string LoanType { get; set; }

        public float LoanAmount
        {
            get => _loanAmount;
            set
            {
                _loanAmount = value;
                NotifyObservers();
            }
        }


        public LoanManager(string bank, string loanType, float loanAmount)
        {
            Bank = bank;
            LoanType = loanType;
            LoanAmount = loanAmount;
        }
        public void AddObserver(ILoanObserver loanObserver)
        {
            LoanObservers.Add(loanObserver);
        }

        public void RemoveObserver(ILoanObserver loanObserver)
        {
            LoanObservers.Remove(loanObserver);
        }

        public void NotifyObservers()
        {
            LoanObservers.ForEach(observer =>
            {
                Console.WriteLine("Loan amount has changed.");
                observer.UpdateLoan(LoanAmount);
            });
        }
    }
}
