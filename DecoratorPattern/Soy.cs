using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            double cost =  beverage.Cost();
            if (beverage.Size == Size.TALL)
                cost += 0.10;
            else if (beverage.Size == Size.GRANDE)
                cost += 0.15;
            else
                cost += 0.20;

            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
