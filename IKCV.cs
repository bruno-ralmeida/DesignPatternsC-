namespace boasPraticas
{
  public class IKCV : TaxTemplateCondition
  {
    public override bool hasMaxTax(Budget budget)
    {
      return budget.Value > 500 && isItemMoreExpensiveThan100(budget);
    }
    public override double MaxTax(Budget budget)
    {
      return budget.Value * 0.1;
    }
    public override double MinTax(Budget budget)
    {
      return budget.Value * 0.06;
    }
    private bool isItemMoreExpensiveThan100(Budget budget)
    {
      foreach (Item item in budget.Items)
      {
        if (item.Price > 100)
        {
          return true;
        }
      }
      return false;
    }

  }
}