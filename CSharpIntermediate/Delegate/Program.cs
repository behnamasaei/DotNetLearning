using System;
delegate int Calculator(int n);//declaring delegate  

public class DelegateExample
{
    static int number = 100;
    public static int add(int n)
    {
        number = number + n;
        return number;
    }
    public static int mul(int n)
    {
        number = number * n;
        return number;
    }
    public static int getNumber()
    {
        return number;
    }
    public static void Main(string[] args)
    {
        Calculator c1 = new Calculator(add);//instantiating delegate  
        Calculator c2 = new Calculator(mul);
        c1(20);//calling method using delegate  
        Console.WriteLine("After c1 delegate, Number is: " + getNumber());
        c2(3);
        Console.WriteLine("After c2 delegate, Number is: " + getNumber());

    }
}