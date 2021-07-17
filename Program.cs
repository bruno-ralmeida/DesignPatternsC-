using System;

namespace boasPraticas
{
  class Program
  {
    static void Main(string[] args)
    {
      var calculator = new TaxCalculator();
      var icpp = new ICPP();
      var ikcv = new IKCV();

      Budget budget = new Budget(300);
      Console.WriteLine("Budget: {0}", budget.ToString());
      calculator.Calculate(budget, icpp);
      calculator.Calculate(budget, ikcv);
      Console.ReadKey();

    }
  }
}
