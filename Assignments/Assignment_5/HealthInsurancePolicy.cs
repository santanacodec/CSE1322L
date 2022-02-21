using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    class HealthInsurancePolicy : InsurancePolicy, IDeductable
    {
        private double deductibleLimit { get; set; }
        private double totalDeductiblePaid { get; set; } = 0;
        private double coPayment { get; set; }
        private double totalCoPaymentPaid { get; set; } = 0;
        private double totalOutOfPocket { get; set; }

        public HealthInsurancePolicy(string policyHolder, 
            double deductibleLimit, 
            double coPayment, 
            double totalOutOfPocket) : base(policyHolder)
        {
            this.deductibleLimit = deductibleLimit;
            this.coPayment = coPayment;
            this.totalOutOfPocket = totalOutOfPocket;
        }

        public override void selectPolicyCoverage()
        {
            Console.WriteLine("selecting policy coverages");
        }

        public override void calculatePremium()
        {
            Console.WriteLine("calculating and updating premium");
        }

        public bool hasMetDeductible()
        {

            if (totalDeductiblePaid >= deductibleLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool hasMetTotalOutOfPocket()
        {
            if ((totalDeductiblePaid + totalCoPaymentPaid) >= totalOutOfPocket)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nDeductible Limit: " + deductibleLimit +
                "\nTotal Deductible Paid: " + totalDeductiblePaid +
                "\nCopayment: " + coPayment +
                "\nTotal Copayment Paid: " + totalCoPaymentPaid + 
                "\nTotal Out Of Pocket: " + totalOutOfPocket +
                "\nHas Met deductible: " + hasMetDeductible() +
                "\nHas Met Total Out Of Pocket Payout: " + hasMetTotalOutOfPocket();
        }
    }
}
