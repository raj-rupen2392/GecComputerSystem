using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Assignment2
{
    public void Area(double X, double Y)
    {
        double a = X;
        double b = Y;
        double c = 0.5 * a * b;
        Console.WriteLine("Area of triangle : " + c);
    }

    public void Area(double R)
    {
        double a = R;
        double c = 3.14 * (a * a);
        Console.WriteLine("Area of circle : " + c);
    }

    public void Area(int X)
    {
        int a = X;
        int c = a * a;
        Console.WriteLine("Area of square : " + c);
    }
}
public class Test
{ 
public static void Main(string[] args)
    {
        Assignment2 A = new Assignment2();
        A.Area(24.0, 12.0);
        A.Area(7.0);
        A.Area(6);
        Console.ReadLine();
    }
    
    
}