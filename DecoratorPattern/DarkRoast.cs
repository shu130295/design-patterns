// See https://aka.ms/new-console-template for more information
using DecoratorPattern;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        this.description = "Dark Roast Coffee";
    }

    public override double Cost()
    {
        return 0.99;
    }
}