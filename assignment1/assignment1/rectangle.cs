using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
   public class rectangle
    {
        private double length;
        private double width;

        public rectangle() { }
        public rectangle(double Length, double Width)
        {
            this.length = Length;
            this.width = Width;

        }
        public double Length { get => Length; set => Length = value; }
        public double Width { get => Width; set => Width = value; }

        public double Getrectanglelength()
        {
            return Length;
        }
        public double ChangerectangleLength(double Length)
        {
            this.length = Length;
            return this.length;
        }

        public double GetrectangleWidth()
        {
            return Width;
        }
        public double ChangerectangleWidth(double Width)
        {
            this.Width = Width;
            return this.Width;
        }
        public double GetrectanglePerimeter()
        {
            return (2 * (Length + Width));
        }
        public double GetrectangleArea()
        {
            return (Length * Width);
        }
    }


}