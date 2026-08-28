namespace _260828_FirstTest;


public class MealMenu : Menu
{
    public MealMenu(string name, int price, MenuType type) : base(name, price, type)
    {
    }
    public override void Buy(int addPrice, int amount)
    {
        addPrice = price * amount;
    }
}



public class SaleMenu : MealMenu
{
    public SaleMenu(string name, int price, MenuType type) : base(name, price, MenuType.Meal)
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
