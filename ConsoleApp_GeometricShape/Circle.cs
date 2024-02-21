using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circle : GeometricShape
{
    public override double CalculateArea(params double[] parameters)
    {
        if (parameters.Length == 1)
        {
            return Math.PI * parameters[0] * parameters[0];
        }
        return 0;
    }

    public override double CalculatePerimeter(params double[] parameters)
    {
        if (parameters.Length == 1)
        {
            return 2 * Math.PI * parameters[0];
        }
        return 0;
    }

}
