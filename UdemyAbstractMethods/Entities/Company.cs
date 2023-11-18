using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAbstractMethods.Entities
{
    internal class Company : TaxPayer
    {
        public Company()
        {
        }

        public int EmployeeNum { get; set; }

        public Company(string name, double annualIncome, int employeeNum) : base(name, annualIncome)
        {
            EmployeeNum = employeeNum;
        }

       
        public override string ToString()
        {
            return base.ToString()+CalculateTax().ToString("F2",CultureInfo.InvariantCulture);
        }

        protected internal override double CalculateTax()
        {
            double tax = 0;
            if (EmployeeNum > 10)
            {
                tax = AnnualIncome * .14;
            }
            else
            {
                tax = AnnualIncome * .16;
            }
            return tax;
        }
    }
}
