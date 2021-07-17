using System;

namespace boasPraticas
{
  public class DiscountCalculator
  {
    public double Calculate(Budget budget)
    {
      var discountForItems = new DiscountForItems();
      var discountForPrice = new DiscountForPrice();
      var noDiscount = new NoDiscount();

      discountForItems.nextDiscount = discountForPrice;
      discountForPrice.nextDiscount = noDiscount;

      return discountForItems.Discount(budget);
    }
  }
}