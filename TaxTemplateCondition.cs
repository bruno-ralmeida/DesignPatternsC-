namespace boasPraticas
{
  public abstract class TaxTemplateCondition
  {
    public double Calculate(Budget budget)
    {
      if (hasMaxTax(budget))
      {
        return MaxTax(budget);
      }

      return MinTax(budget);
    }
    public abstract bool hasMaxTax(Budget budget);
    public abstract double MaxTax(Budget budget);
    public abstract double MinTax(Budget budget);
  }
}