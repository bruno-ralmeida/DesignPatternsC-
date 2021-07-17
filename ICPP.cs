namespace boasPraticas
{
  public class ICPP : TaxTemplateCondition
  {
    public override bool hasMaxTax(Budget budget)
    {
      return (budget.Value >= 500);
    }
    public override double MinTax(Budget budget)
    {
      return budget.Value * 0.05;
    }
    public override double MaxTax(Budget budget)
    {
      return budget.Value * 0.07;
    }
  }
}