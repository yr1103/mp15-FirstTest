namespace _260828_FirstTest;


public abstract class Menu : IBuyable
{
    protected string name;
    protected int price;
    protected MenuType type;
    
    public Menu(string menuName, int menuPrice, MenuType menuType)
    {
        name = menuName;
        price = menuPrice;
        type = menuType;
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

    public abstract int Buy(int addPrice, int amount);


}
