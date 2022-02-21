using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    class TermLifeInsurancePolicy : InsurancePolicy
    {
        private string beneficiary { get; set; }
        private int term { get; set; }
        private double termPayout { get; set; }

        public TermLifeInsurancePolicy(string name, string beneficiary, int term, double termPayout) : base(name)
        {
            this.beneficiary = beneficiary;
            this.term = term;
            this.termPayout = termPayout;
        }

        public override void selectPolicyCoverage()
        {
            Console.WriteLine("selecting policy coverages");
        }

        public override void calculatePremium()
        {
            Console.WriteLine("calculating and updating premium");
        }

        public override string ToString()
        {
            return base.ToString() + 
                "\nBeneficiary: " + beneficiary +
                "\nTerm: " + term +
                "\nTerm Payout: " + termPayout;
        }
    }
}
