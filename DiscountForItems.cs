using System;

namespace boasPraticas
{
  public class DiscountForItems : IDiscount
  {
    public IDiscount nextDiscount { get; set; }

    public double Discount(Budget budget)
    {
      if (budget.Items.Count > 5)
      {
        Console.WriteLine("Calculando desconto por Items...");
        return budget.Value * 0.1;
      }
      return nextDiscount.Discount(budget);
    }
  }
}