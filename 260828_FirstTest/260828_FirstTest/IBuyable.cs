namespace _260828_FirstTest;

// 구매가능한 애들 전부

public interface IBuyable
{
    string Name { get; }
    int Price { get; }
    MenuType Type { get; }
    int Buy(int addPrice, int amount);
}
