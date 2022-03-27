// See https://aka.ms/new-console-template for more information
using DecoratorPattern;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override double Cost()
    {
        switch(this.beverage.GetSize())
        {
            case Size.TALL: 
                return this.beverage.Cost() + 0.10;
            case Size.GRANDE:
                return this.beverage.Cost() + 0.15;
            case Size.VENTI:
                return this.beverage.Cost() + 0.20;
        }
        return this.beverage.Cost() + 0.15;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Soy";
    }
}