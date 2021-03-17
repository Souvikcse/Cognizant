using FacadeDemo.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemo
{
    public class ShapeMaker
    {
        private Shape circle;
        private Shape square;
        private Shape rectangle;

        public ShapeMaker()
        {
            circle = new Circle();
            square = new Square();
            rectangle = new Rectangle();
        }

        public void drawCircle()
        {
            circle.draw();
        }
        public void drawRectangle()
        {
            rectangle.draw();
        }
        public void drawSquare()
        {
            square.draw();
        }
    }
}
