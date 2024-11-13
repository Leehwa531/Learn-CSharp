namespace Practice5_11
{
    //연습문제 5.11
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IFigure
    {
        void Area();    //넓이를 구하는 메소드
        void Grith();   //둘레를 구하는 메소드
        void Draw();    //도형을 그리는 메소드
    }

    class Circle : IFigure
    {
        double radius;      //반지름
        public Circle(double r) { radius = r; }     //생성자
        public void Area()     //원 넓이 구하는함수 
        {
            Console.WriteLine("원의 넓이 = {0}", radius * radius * 3.14);       //원 넓이 구하는함수 
        }
        public void Grith()    //원 둘레 구하는함수 
        {
            Console.WriteLine("원의 둘레 = {0}", radius * 2 * 3.14);

        }
        public void Draw()     //원 그리기 함수
        {
            Console.WriteLine("원그리기");
        }
    }

    class Square : IFigure
    {
        double length;
        public Square(double r) { length = r; }
        public void Area()     //사각형 넓이 구하는함수 
        {
            Console.WriteLine("사각형의 넓이 = {0}", length * length);
        }
        public void Grith()    //사각형 둘레 구하는함수 
        {
            Console.WriteLine("사각형의 둘레 = {0}", length * 4);

        }
        public void Draw()     //사각형 그리기 함수
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
