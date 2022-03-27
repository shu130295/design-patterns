using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI };
        Size size = Size.TALL;
        public string description = "Unknown beverage";

        public void SetSize(Size size)
        {
            this.size = size;
        }

        public Size GetSize()
        {
            return this.size;
        }

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
