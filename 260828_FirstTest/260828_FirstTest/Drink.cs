namespace _260828_FirstTest;

public class Drink : Menu
{
    public Drink(string name, int price, MenuType type, bool canDiscount) : base(name, price, MenuType.Drink, canDiscount)
    {
        
    }

    public override void Buy(int addPrice, int amount)
    {
    }
}