// https://github.com/yr1103/mp15-FirstTest

using System;
using _260828_FirstTest;

class Program
{
    const string STORE_NAME = "수라 냉면";
    const int AMOUNT_TO_SALE = 3;
    const int SALE_VALUE = 10;
    const string COLD_NOODLE = "냉면";
    const string PORK_CUTLET = "돈까스";
    const string DRINK = "음료";
    
    static void Main(string[] args)
    {
        // 입력 받은 값으로부터 장바구니 List<T>에서 누른 번호로 add해준다.
        
        List<IBuyable> purchase = new List<IBuyable>();
        

        while (true)  
        {  
            Console.Clear();
            // 화면을 그린다
            PrintLine();
            Console.WriteLine($"=== {STORE_NAME} 주문 키오스크 ===\n");
            PrintLine();

            int picked = ConsoleInput.ReadIntInRange("번호 : ", 1, 4);

            // 골라진 번호대로 처리하고 결과를 출력한다

            ConsoleInput.Pause();  
        }
        
        // 1부터 6 사이의 번호를 받습니다. 숫자가 아니거나 범위를 벗어나면 다시 묻습니다.  
        int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호 : ", 1, 6);

        // 0 이상의 값을 받습니다. 위쪽 한계를 정하기 어려울 때 씁니다.  
        int paid = ConsoleInput.ReadIntAtLeast("받은 금액 : ", 0);

        // 결과를 보여 준 뒤 화면을 지우기 전에 잠시 멈춥니다.  
        ConsoleInput.Pause();
        
        // 번호 받고 몇개 구매할지 화면 다시 받고 다시 이동하기
        //


    }

    public static void PrintMenu(IBuyable purchase)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"");
        }
    }

    public static void PrintLine()
    {
        Console.WriteLine("----------------------------------------");
    }
}

// 항목 물냉, 비냉, 왕돈까스, 치즈돈까스, 카레돈까스, 제로콜라, 스프라이트
// 분류 냉면(coldNoodle), 돈까스(porkcutlet), 음료(drink)



// 식사메뉴 구분
// 나중에 규칙 구현시 사용
// 전체가격 만원 나눈 몫만큼 천원 쿠폰 지급
// 식사 메뉴 최소 한개 주문해야함 (나의 규칙)
// 음료만 시키면 결제 안되게
// 돈까스 3개 이상 시키면 10% 할인
public interface IEdible
{
    string Name { get;}
    int Price { get; }
    MenuType Type { get; }
}

// 구매가능한 애들 전부
public interface IBuyable
{
    void Buy();
}


public abstract class Menu
{
    protected string name;
    protected int price;
    protected MenuType type;
    
    public Menu(string menuName, int menuPrice, int menuType)
    {
        name = menuName;
        price = menuPrice;
        type = (MenuType)menuType;
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

}


// 분류 : 냉면, 돈까스, 음료
public enum MenuType
{ 
    ColdNoodle,
    PorkCutlet,
    Drink
}