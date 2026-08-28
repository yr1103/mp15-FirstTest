namespace _260828_FirstTest;


public abstract class Menu
{
    protected string name;
    protected int price;
    protected MenuType type;
    protected bool canDiscount;
    
    public Menu(string menuName, int menuPrice, MenuType menuType, bool isdiscount)
    {
        name = menuName;
        price = menuPrice;
        type = menuType;
        isdiscount = canDiscount;
        
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    public int Price
    {
        get
        {
            return price;
        }
    }

    public MenuType Type
    {
        get
        {
            return type;
        }
    }
    public abstract void Buy(int addPrice, int  amount);
}
