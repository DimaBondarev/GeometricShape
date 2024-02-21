using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle : GeometricShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public override double CalculateArea(params double[] parameters)
    {
        if (parameters.Length == 2)
        {
            return parameters[0] * parameters[1];
        }
        return 0;
    }

    public override double CalculatePerimeter(params double[] parameters)
    {
        if (parameters.Length == 2)
        {
            return 2 * (parameters[0] + parameters[1]);
        }
        return 0;
    }

    public static bool operator ==(Rectangle r1, Rectangle r2)
    {
        return r1.CalculateArea(r1.Length, r1.Width) == r2.CalculateArea(r2.Length, r2.Width);
    }

    public static bool operator !=(Rectangle r1, Rectangle r2)
    {
        return !(r1 == r2);
    }
}
