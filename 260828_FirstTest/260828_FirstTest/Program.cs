using System;
using _260828_FirstTest;

class Program
{
    static void Main(string[] args)
    {
        // 1부터 6 사이의 번호를 받습니다. 숫자가 아니거나 범위를 벗어나면 다시 묻습니다.  
        int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호 : ", 1, 6);

        // 0 이상의 값을 받습니다. 위쪽 한계를 정하기 어려울 때 씁니다.  
        int paid = ConsoleInput.ReadIntAtLeast("받은 금액 : ", 0);

        // 결과를 보여 준 뒤 화면을 지우기 전에 잠시 멈춥니다.  
        ConsoleInput.Pause();
        
        while (true)  
        {  
            Console.Clear();

            // 화면을 그린다

            int picked = ConsoleInput.ReadIntInRange("번호 : ", 1, 4);

            // 골라진 번호대로 처리하고 결과를 출력한다

            ConsoleInput.Pause();  
        }

    }
}