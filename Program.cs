using System;

namespace boasPraticas
{
  class Program
  {
    static void Main(string[] args)
    {
      var calculator = new TaxCalculator();
      var iss = new ISS();
      var icms = new ICMS();

      Budget budget = new Budget(500);

      calculator.Calculate(budget, iss);
      calculator.Calculate(budget, icms);

    }
  }
}
