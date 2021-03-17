using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker sm = new ShapeMaker();
            sm.drawCircle();
            sm.drawRectangle();
            sm.drawSquare();

            Console.Read();
        }
    }
}
