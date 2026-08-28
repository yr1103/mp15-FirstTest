namespace _260828_FirstTest;

public class Drink : Menu
{
    public Drink(string name, int price, MenuType type) : base(name, price, MenuType.Drink)
    {
    }

    public override void Buy(int addPrice, int amount)
    {
    }
}