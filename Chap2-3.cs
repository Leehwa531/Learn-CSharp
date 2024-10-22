using System;

class ExerciseCh2_12_8
{
    static void Main(string[] args)
    {
        int year; //년도

        //년도값 입력받기
        Console.Write("연도를 입력하세요. : ");
        year = int.Parse(Console.ReadLine());


        if (((year % 4 == 0) && (year % 1000 != 0) || (year % 400 == 0))) //윤년공식
            Console.WriteLine(year + "년은 윤년입니다."); //윤년 조건 만족시 출력

        else
            Console.Write(year + "년은 평년입니다."); //나머지 조건 출력
    }
}
