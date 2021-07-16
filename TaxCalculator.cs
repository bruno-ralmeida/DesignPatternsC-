using System;

namespace boasPraticas
{
  public class TaxCalculator
  {
    public void Calculate(Budget budget, ITax tax)
    {
      var result = tax.Calculate(budget);
      Console.WriteLine("Tax: {0:C}", result);
    }
  }
}