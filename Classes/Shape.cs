
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Shape : IShape
    {
        private int area;

        public double GetArea()
        {
            throw new NotImplementedException();
        }
       

        public void SetArea(int Area)
        {
            area = Area;
        }

        public string? Colour { get; set; }
    }
}
