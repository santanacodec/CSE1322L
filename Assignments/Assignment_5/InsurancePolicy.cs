using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    abstract class InsurancePolicy
    {
        private string policyHolder { get; set; }
        private int policyNumber { get; set; }
        private static int numberOfPolicies { get; set; } = 0;
        private double premium { get; set; } = 0;

        public InsurancePolicy(string name)
        {
            this.policyHolder = name;
            policyNumber = ++numberOfPolicies;
        }

        public abstract void selectPolicyCoverage();

        public abstract void calculatePremium();

        public override string ToString()
        {
            return "Policy Holder: " + policyHolder +
                "\nPolicy Number: " + policyNumber +
                "\nNumber of Policies: " + numberOfPolicies +
                "\nPremium: " + premium;
        }

    }
}
