using System;
class FinallyClause
{
 public void MethodA()
 {
 try
 {
 Console.WriteLine("1"); // 1 실행
 }
 catch (Exception e)
 {
 Console.WriteLine("2"); //오류 발생시에만 실행
 }
 }
 public void MethodB()
 {
 try
 {
 Console.WriteLine("3"); // 2 실행
 }
 finally
 {
 Console.WriteLine("4"); // 3 실행
 }
 }
}
class ExerciseCh6_10_3
{
 public static void Main()
 {
 FinallyClause fc = new FinallyClause();
 fc.MethodA();
 fc.MethodB();
 }
}
