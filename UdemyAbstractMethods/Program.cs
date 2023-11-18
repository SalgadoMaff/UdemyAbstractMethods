using System.Globalization;
using UdemyAbstractMethods.Entities;

string readName()
{
    Console.Write("Name: ");
    return Console.ReadLine();
}

double readIncome()
{
    Console.Write("Annual income: ");
    return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}


double readHealthExpenditures()
{
    Console.Write("Health expenditures: ");
    return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

int readNumEmployees()
{
    Console.Write("Number of employees: ");
    return int.Parse(Console.ReadLine());
}



Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());
List<TaxPayer> list = new List<TaxPayer>();

try
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Tax payer #{i + 1} data:");
        Console.Write("Individual or company (i/c)? ");
        char op = Console.ReadLine()[0];
        switch (op)
        {
            case 'i':

                list.Add(new Individual(readName(), readIncome(), readHealthExpenditures()));

                break;
            case 'c':

                list.Add(new Company(readName(), readIncome(), readNumEmployees()));

                break;
            default:
                throw new Exception();
        }
    }
}
catch (Exception)
{

    throw;
}

double totaltax = 0;
Console.WriteLine("TAXES PAID:");

foreach (TaxPayer taxPayer in list)
{
    Console.WriteLine(taxPayer.ToString());
    totaltax += taxPayer.CalculateTax();

}
Console.WriteLine("TOTAL TAXES: $ "+totaltax.ToString("F2",CultureInfo.InvariantCulture));