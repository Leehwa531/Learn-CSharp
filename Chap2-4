using System;

class ExerciseCh2_12_9
{
    static void Main(string[] args)
    {
        int num = -9999999; //일련의 숫자
        int max = 0; //최대값

        Console.Write("숫자(정수)를 입력하세요.('0' 입력시 최대값 출력)\n");

        while(num != 0 )    //입력시까지 무한반복
        {
            Console.Write("입력 : ");
            num = int.Parse(Console.ReadLine()); //정수값으로 입력받아 num에 저장
            
            //num이 max보다 크다면 num을 max에 저장
            if (num > max)
                max = num;
        }
        Console.WriteLine("최대값 :" + max); // 최대값 출력
    }
}

