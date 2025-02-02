using System;

class Program
{
    static string Collision((double, double) positionA, (double, double) speedA,
                            (double, double) positionB, (double, double) speedB)
    {
        double xa = positionA.Item1, ya = positionA.Item2; //posicion a
        double xb = positionB.Item1, yb = positionB.Item2; //posicion b
        double sxa = speedA.Item1, sya = speedA.Item2;  //velocidad a
        double sxb = speedB.Item1, syb = speedB.Item2;  //velocidad b

        double tx, ty;  // tiempo para colicionar

        if (sxa - sxb == 0) //tienen la misma velocidad
        {
            if (xa == xb)  // empienzan en el mismo punto 
                tx = 0;
            else
                return "Los objetos no colisionan.";
        }
        else
        {
            tx = (xb - xa) / (sxa - sxb); // formula de fisica no tengo puta idea pero funciona
        }

        if (sya - syb == 0)  //tienen la misma velocidad
        {
            if (ya == yb)
                ty = 0;
            else
                return "Los objetos no colisionan.";
        }
        else
        {
            ty = (yb - ya) / (sya - syb);
        }

        if (tx == ty)
        {
            double t = tx;
            double x = xa + sxa * tx;
            double y = ya + sya * ty;
            return $"Los objetos colisionan en el punto ({x}, {y}) en un tiempo {t}.";
        }
        else
        {
            return "Los objetos no colisionan.";
        }
    }

    static void Main()
    {
        Console.WriteLine(Collision((0, 0), (1, 1), (1, 2), (0, 1)));
        Console.WriteLine(Collision((2, 0), (0, 1), (0, 2), (1, 0)));
        Console.WriteLine(Collision((0, 0), (10, 5), (100, 50), (-5, -2.5)));
    }
}
