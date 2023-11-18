using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAbstractMethods.Entities
{
    internal class Individual : TaxPayer
    {
        public Individual()
        {
        }

        public double HealthCosts { get; set; }

        public Individual(string name, double annualIncome, double healthCosts) : base(name, annualIncome)
        {
            HealthCosts = healthCosts;
        }

       
        public override string ToString()
        {
            return base.ToString() + CalculateTax().ToString("F2", CultureInfo.InvariantCulture);
        }

        protected internal override double CalculateTax()
        {
            double tax = 0;
            if (AnnualIncome < 2000.00)
            {
                tax = AnnualIncome * .15;

            }
            else
            {
                tax = AnnualIncome * .25;
            }
            if (HealthCosts > 0)
            {
                tax -= HealthCosts / 2;
            }
            return tax;
        }
    }
}
