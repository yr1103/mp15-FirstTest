namespace _260828_FirstTest;


public class MealMenu : Menu
{
    public MealMenu(string name, int price, MenuType type) : base(name, price, type)
    {
    }
    
    public override int Buy(int addPrice, int amount)
    {
        return addPrice * amount;
    }
}



public class SaleMenu : MealMenu
{
    public SaleMenu(string name, int price, MenuType type) : base(name, price, MenuType.Meal)
    {
    }

    public int Buy(int addPrice, int amount)
    {   
        const int AMOUNT_TO_SALE = 3;
        const  float SALE_VALUE = 0.9f;
        int totalPrice = addPrice * amount;
        // 돈까스 3개 이상이면 10퍼 할인
        if (amount >= AMOUNT_TO_SALE)
        {
            return  (int)(totalPrice * SALE_VALUE);
        }
        else
        {
            return  (int)(totalPrice);
        }
    }
}
