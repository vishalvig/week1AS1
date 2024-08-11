using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape, IShape
    {   
        private double _radius;

        public Circle(int radius)
        {

        _radius = radius; 
        
        }
        
        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

}
