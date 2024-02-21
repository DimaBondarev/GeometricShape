using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Triangle : GeometricShape
{
    public override double CalculateArea(params double[] parameters)
    {
        if (parameters.Length == 2)
        {
            return 0.5 * parameters[0] * parameters[1];
        }
        return 0;
    }

    public override double CalculatePerimeter(params double[] parameters)
    {
        if (parameters.Length == 3)
        {
            return parameters[0] + parameters[1] + parameters[2];
        }
        return 0;
    }
}
