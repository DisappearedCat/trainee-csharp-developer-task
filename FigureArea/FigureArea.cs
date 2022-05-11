//Не понятно как вычислять площадь не зня типа фигуры.
//Не понятно где риализовывать проверку на проямоугольность триугольника. Просто внутри функции вычисления площади?

using System;
public static class FigureArea
{
    /// <summary>
    /// Calculates area the circle with given radius.
    /// </summary>
    /// <param name="radius"></param>
    /// <returns>Area of circle.</returns>
    /// <exception cref="System.ArgumentOutOfRangeException">Throws if radius less that 0.</exception>
    public static double CircleArea(double radius)
    {
        if (radius < 0)
            throw new System.ArgumentOutOfRangeException(nameof(radius), "radius can't be less than zero");

        return System.Math.PI * System.Math.Pow(radius, 2);
    }

    /// <summary>
    /// Calculate area of triangle with given three sides.
    /// </summary>
    /// <param name="a">First side.</param>
    /// <param name="b">Second side.</param>
    /// <param name="c">Third side.</param>
    /// <returns>Area of the triangle. Returns 0 if one of the sides equal 0.</returns>
    /// <exception cref="System.ArgumentOutOfRangeException">Throws if one of the side less than 0.</exception>
    public static double TriangleArea(double a, double b, double c)
    {
        if (a < 0)
            throw new System.ArgumentOutOfRangeException(nameof(a), "can't be less that zero");
        if (b < 0)
            throw new System.ArgumentOutOfRangeException(nameof(b), "can't be less that zero");
        if (c < 0)
            throw new System.ArgumentOutOfRangeException(nameof(c), "can't be less that zero");

        if (a == 0 || b == 0 || c == 0)
            return 0;

        double halfPerimetr = (a + b + c) / 2;
        double area = Math.Sqrt(halfPerimetr * (halfPerimetr - a) * (halfPerimetr - b) * (halfPerimetr - c));
        return area;
    }
}