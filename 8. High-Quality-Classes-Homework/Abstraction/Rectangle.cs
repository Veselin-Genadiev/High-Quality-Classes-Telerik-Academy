using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        double Width { get; set; }
        double Height { get; set; }
        public Rectangle()
            : this(0, 0)
        {

        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
