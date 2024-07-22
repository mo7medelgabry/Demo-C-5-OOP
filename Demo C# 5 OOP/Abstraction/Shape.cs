using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_C__5_OOP.Abstraction
{
    internal abstract class Shape
    {
       
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        protected Shape(decimal dim01, decimal dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }


        public abstract decimal CalcArea();

        public abstract decimal Perimeter { get; }

    }

   abstract class RecBase : Shape
    {
        public RecBase(decimal dim01 , decimal dim02) : base(dim01, dim02)
        {

        }

        public override decimal CalcArea()
        { 
            return Dim01 * Dim02;
        }
    }

    class Area : RecBase
    {
        public Area(decimal dim01, decimal dim02) : base(dim01, dim02)
        {

        }

        public override decimal Perimeter
        {
            get { return ((Dim01 + Dim02) * 2); }
        }

      

    }

    class Square : RecBase
    {
        public Square(decimal Dim) : base(Dim, Dim)
        {
        }

        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }
     
    
    }

    class Circle : Shape
    {
        public Circle(decimal Radius): base(Radius, Radius)
        {
        }
        public override decimal Perimeter => 2 * 3.14M* Dim01;
        public override decimal CalcArea()
        {
            return 3.14M*Dim01*Dim02;
        }
    }
}
