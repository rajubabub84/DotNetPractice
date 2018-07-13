using DecoratorDemo.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDemo.Component;

namespace DecoratorDemo.ConcreteDecorator
{
    public class OfferPrice : CarDecorator
    {
        public OfferPrice(ICar Car) : base(Car)
        {
        }

        public override double GetDiscountedPrice()
        {
            return .8 * base.GetPrice();
        }
    }
}
