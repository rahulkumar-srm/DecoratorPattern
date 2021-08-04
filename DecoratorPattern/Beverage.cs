using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public Size Size { get; set; } = Size.TALL;

        public abstract double Cost();
    }

    public enum Size { TALL, GRANDE, VENTI };
}
