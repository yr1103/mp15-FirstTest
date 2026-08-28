namespace _260828_FirstTest;

public class CartItem<T> where T : IBuyable
{
    private T[] menus;
    private int count = 0;

    public CartItem(int capacity)
    {
        menus = new T[capacity];
    }

    public int Count
    {
        get
        {
            return count;
        }
    }

    public void Add(T item)
    {
        if (count >= menus.Length)
        {
            Console.WriteLine("더 구매할 수 없습니다.");
            return;
        }
        
        menus[count] = item;
        count++;
    }

    public T Get(int index)
    {
        return menus[index];
    }
}