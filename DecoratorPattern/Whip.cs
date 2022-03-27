// See https://aka.ms/new-console-template for more information
using DecoratorPattern;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override double Cost()
    {
        return beverage.Cost() + 0.10;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Whip";
    }
}