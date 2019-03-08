using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Hierarchy.AbstractClasses
{
    public abstract class PlaneShape : Shape
    {
        public abstract double Perimeter { get; }
    }

    public abstract class SpatialShape : Shape
    {
        public abstract double Volume { get; }
    }

    public class Circle : PlaneShape
    {
        public double Radius { get; set; }
        public override double Perimeter { get { return 2 * Math.PI * Radius; } }
        public override double Area { get { return Math.PI * Radius * Radius; } }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }

    public class Rectangle : PlaneShape
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public override double Perimeter { get { return 2 * (Lenght + Width); } }
        public override double Area { get { return Lenght * Width; } }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }   

    public class Cylinder : SpatialShape
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public override double Volume { get { return Math.PI * Radius * Radius * Height; } }
        public override double Area { get { return 2 * Math.PI * Radius * Height + 2 * Math.PI * Radius * Radius; } }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
