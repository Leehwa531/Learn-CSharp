namespace practice5_7
{
    //연습문제 5.7
    using system;

    class temperature
    {
        double degree;
        public temperature(double degree) { this.degree = degree; }
        public double degree { get { return degree; } }
    }

    class celsius : temperature
    {
        public celsius(double t) : base(t) { }
        public static explicit operator celsius(double d) //1-1 번 문제
        {
            return new celsius(d);
        }
        public static explicit operator celsius(fahrenheit f) //1-2번 문제
        {
            double d = (f.degree - 32) * 5 / 9;
            return new celsius(d);
        }
        public static explicit operator double(celsius c) //1-3번 문제
        {
            return c.degree;
        }

    }

    class fahrenheit : temperature
    {
        public fahrenheit(double t) : base(t) { }
        public static explicit operator fahrenheit(double d) //2-1번 문제
        {
            return new fahrenheit(d);
        }
        public static explicit operator fahrenheit(celsius c) //2-2번 문제
        {
            double d = c.degree * 9 / 5 + 32;
            return new fahrenheit(d);
        }
        public static explicit operator double(fahrenheit f) //2-3번 문제
        {
            return f.degree;
        }
    }
    
    
    class test
    {
        public static void main()
        {
            fahrenheit fahr = new fahrenheit(50.0);
            console.writeline("fahr.degree(50.0) :" + fahr.degree);
            celsius cels = (celsius)fahr; // fahrenheit -> celsius 로 명시적 형 변환한 값을 c에 대입
            console.writeline("fahr -> cels 형 변환한 값 :" + cels.degree);     //(50 - 32) * 5 / 9 = 10, 즉 10이 출력

            celsius cels2 = new celsius(50.0);
            console.writeline("cels2.degree(50.0) :" + cels2.degree);
            fahrenheit fahr2 = (fahrenheit)cels2; //celsius -> fahrenheit 로 명시적 형 변환한 값을 fahr2에 대입
            console.writeline("cels2 -> fahr2 형 변환한 값 :" + fahr2.degree);     //50 * 9 / 5 + 32 = 122, 즉 122가 출력

            console.writeline("\n이상! 테스트 완료 했습니다.\n");

        }
    }
}
