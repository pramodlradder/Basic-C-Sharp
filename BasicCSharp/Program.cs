using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Circle
{
    double radius;
    double area;
    public const double Pi = 3.14159;
    //Int32 circumference;

    Circle()
    {
        Console.WriteLine("Enter the Radius:");
        radius = Int32.Parse(Console.ReadLine());
    }
    public double getradius()
    {
        return radius;
    }
    public double calcarea()
    {
        double r = getradius();
        area = Pi * Math.Pow(r, 2);
        return area;
    }
    public double calccircumference()
    {
        double r = getradius();
        area = 2 * Pi * r;
        return area;
    }
    public void display()
    {
        Console.WriteLine("Area of circle is: {0}", calcarea());
        Console.WriteLine("Circumference of circle is: {0}", calccircumference());
        Console.ReadKey();
    }
    static void Main(string[] args)
    {
        Circle c = new Circle();
        c.display();
    }
}

