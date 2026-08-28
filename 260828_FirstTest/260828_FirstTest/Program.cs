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

            PrintLine();
            Console.WriteLine("1. 담기   2. 전체 비우기   3. 결제   4. 영업 종료");
            int picked = ConsoleInput.ReadIntInRange("번호 : ", 1, 10);

            // 골라진 번호대로 처리하고 결과를 출력한다
            switch (picked)
            {
                case 1:
                    int addMenu = ConsoleInput.ReadIntInRange("구매할 수량을 입력해주세요 : ", 1, 10);
                    break;
                    // 메뉴판과 장바구니를 출력하는 반복문에서 메뉴 형식을 구분하지 않습니다.
                    // 기반 형식 하나로 받아 반복문 한 번으로 처리합니다. 형식을 알아내려는 조건문이나 클래스 이름이 그 안에 들어가면 안 됩니다. 금액이나 수량을 비교하는 조건문은 상관없음
                

                case 2:
                    Console.WriteLine("장바구니를 초기화했습니다.");
                    break;
                case 3 :
                    int add = ConsoleInput.ReadIntInRange("구매할 수량을 입력해주세요 : ", 1, 10);
                    break;
                //여기서 막힘

            }

            ConsoleInput.Pause();  
        }
        
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
    void Buy(int addPrice, int amount);
}


// 식사 메뉴
// 정가 계산
// 메뉴에 메뉴이름, 분류, 가격, 추가 계산 방식 여부

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

public class ColdNoodle : MealMenu
{
    public ColdNoodle(string name, int price, MenuType type, bool canDiscount) : base(name, price, MenuType.NangMyeon, canDiscount)
    {
    }
}

public class PorkCutlet : MealMenu
{
    public PorkCutlet(string name, int price, MenuType type, bool canDiscount) : base(name, price, MenuType.PorkCutlet, canDiscount)
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

public class Drink : Menu
{
    public Drink(string name, int price, MenuType type, bool canDiscount) : base(name, price, MenuType.Drink, canDiscount)
    {
        
    }

    public override void Buy(int addPrice, int amount)
    {
        
    }
}

// 분류 : 냉면, 돈까스, 음료
public enum MenuType
{ 
    NangMyeon,
    PorkCutlet,
    Drink
}


