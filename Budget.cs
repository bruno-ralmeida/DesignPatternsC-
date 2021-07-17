using System.Collections.Generic;

namespace boasPraticas
{
  public class Budget
  {
    public double Value { get; private set; }
    public IList<Item> Items { get; private set; }
    public Budget(double value)
    {
      this.Value = value;
      this.Items = new List<Item>();
    }

    public void AddItem(Item item)
    {
      this.Items.Add(item);
    }

  }
}