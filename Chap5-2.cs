namespace Practice5_8
{
    //연습문제 5.8
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    abstract class Figure   //부모클래스
    {
        public abstract void Area();
        public abstract void Grith();
        public abstract void Draw();
    }

    class Circle : Figure   //자식 클래스 : 부모 클래스
    {
        double radius;      //반지름
        public Circle(double r) { radius = r; }     //생성자
        public override void Area()     //원 넓이 구하는함수 
        {
            Console.WriteLine("원의 넓이 = {0}", radius * radius * 3.14);       //원 넓이 구하는함수 
        }
        public override void Grith()    //원 둘레 구하는함수 
        {
            Console.WriteLine("원의 둘레 = {0}", radius * 2 * 3.14);

        }
        public override void Draw()     //원 그리기 함수
        {
            Console.WriteLine("원그리기");
        }
    }

    class Square : Figure
    {
        double length;
        public Square(double r) { length = r; }
        public override void Area()     //사각형 넓이 구하는함수 
        {
            Console.WriteLine("사각형의 넓이 = {0}", length * length);
        }
        public override void Grith()    //사각형 둘레 구하는함수 
        {
            Console.WriteLine("사각형의 둘레 = {0}", length * 4);

        }
        public override void Draw()     //사각형 그리기 함수
        {
            Console.WriteLine("사각형 그리기");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            circle.Area();
            circle.Grith();
            circle.Draw();
            Square square = new Square(3);
            square.Area();
            square.Grith();
            square.Draw();
        }
    }
}
