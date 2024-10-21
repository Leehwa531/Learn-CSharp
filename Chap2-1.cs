using system;

class exercisech2_12_1
{
    static void main(string[] args)
    {
        //세변의 길이 a,b,c
        int a, b, c;
        double l;   //세변의 길이 나누기 2
        double s; //삼각형 넓이

        //세변의 값 입력받기
        console.write("삼각형의 세변을 입력하세요. : ");
        a = console.read() - '0';
        b = console.read() - '0';
        c = console.read() - '0';

        //l값 구하기
        l = (double)(a + b + c) / 2;

        //면적 구하기
        s = math.sqrt(l * (l - a) * (l - b) * (l - c));

        //결과출력
        console.write("삼각형의 넓이 : {0} ", s);

    }
}
