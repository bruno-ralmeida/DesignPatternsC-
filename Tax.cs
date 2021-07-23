namespace boasPraticas
{
  public abstract class Tax
  {
    public Tax ComposeTax { get; set; }
    public abstract double Calculate(Budget budget);
    public Tax(Tax composeTax)
    {
      this.ComposeTax = composeTax;
    }
    public Tax()
    {
      this.ComposeTax = null;
    }
    protected double CalculateCompose(Budget budget)
    {
      if (this.ComposeTax == null) return 0;
      return ComposeTax.Calculate(budget);
    }

  }
}