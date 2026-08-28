namespace _260828_FirstTest;


public class MealMenu : Menu, IBuyable
{
    public MealMenu(string name, int price, MenuType type, bool canDiscount) : base(name, price, type, canDiscount)
    {
    }
    public override void Buy(int addPrice, int amount)
    {
        addPrice = price * amount;
    }
}



public class SaleMenu : MealMenu
{
    public SaleMenu(string name, int price, MenuType type, bool canDiscount) : base(name, price, MenuType.Meal, canDiscount)
    {
    }

    public override void Buy(int addPrice, int amount)
    {
        float TotalPrice = amount * price;
        
        // 돈까스 3개 이상이면 10퍼 할인
        if (amount >= 3)
        {
            TotalPrice *= 0.9f;
            addPrice = (int)TotalPrice;
        }
        else
        {
            addPrice = (int)TotalPrice;
        }
    }
}
