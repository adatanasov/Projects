/* 01. Refactor the following code to use proper variable naming and simplified expressions:
    public class Size
{
  public double wIdTh, Viso4ina;
  public Size(double w, double h)
  {
    this.wIdTh = w;
    this.Viso4ina = h;
  }
}

public static Size GetRotatedSize(
  Size s, double angleOfTheFigureThatWillBeRotaed)
{
  return new Size(
    Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
      Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina,
    Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
      Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina);
} */

using System;

public class Size
{
    private double width, height;

    public Size(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Width
    {
        get 
        { 
            return this.width; 
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("The width should be positive!");
            }
            else
            {
                this.width = value;
            }
        }
    }

    public double Height
    {
        get 
        { 
            return this.height; 
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("The height should be positive!");
            }
            else
            {
                this.height = value;
            }
        }
    }
    
    public static Size GetRotatedSize(Size size, double angle)
    {
        double absoluteSinusOfAngle = Math.Abs(Math.Sin(angle));
        double absoluteCosinusOfAngle = Math.Abs(Math.Cos(angle));
        double rotatedWidth = (absoluteCosinusOfAngle * size.width) + (absoluteSinusOfAngle * size.height);
        double rotatedHeight = (absoluteSinusOfAngle * size.width) + (absoluteCosinusOfAngle * size.height);
        Size rotatedSize = new Size(rotatedWidth, rotatedHeight);
        return rotatedSize;
    }
}
