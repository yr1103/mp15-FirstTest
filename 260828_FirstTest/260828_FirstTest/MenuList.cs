namespace _260828_FirstTest;

// 메뉴판
public class MenuList<T> where T : IBuyable
{
    private T[] menus;
    private int count = 0;

    public MenuList(int capacity)
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
            Console.WriteLine("더 추가할 수 없습니다.");
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