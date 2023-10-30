using System;
class URI
{

    static void Main(string[] args)
    {

        decimal A = Convert.ToDecimal(Console.ReadLine());
        decimal B = Convert.ToDecimal(Console.ReadLine());
        decimal C = Convert.ToDecimal(Console.ReadLine());

        decimal perimetro = A + B + C;
        decimal area = ((A + B) * C) / 2;

        if (A < B + C && B < A + C && C < A + B)
        {
            Console.WriteLine("Perimetro = " + perimetro);
        }
        else
        {
            Console.WriteLine("Area = " + area);
        }

    }

}
