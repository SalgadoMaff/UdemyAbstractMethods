using System;
using System.Collections.Generic;
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

        public Company(int employeeNum, string name, double annualIncome) : base(name, annualIncome)
        {
            EmployeeNum = employeeNum;
        }

        protected override double CalculateTax()
        {
            double tax = 0;
            if (EmployeeNum > 10) {
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
