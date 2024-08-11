
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {
        private static readonly string[] Colours = { "Yellow", "Red", "Blue", "Green", "Orange" };

        private static readonly Random Random = new Random();
        public static Shape AddColour(Shape s)
        {
            s.Colour = "Red";

            return s;
        }

        public static Shape ChangeColour(Shape s)
        {
            s.Colour = "Blue";

            return s;
        }
        public static Shape SetRandomColour(Shape s)
        {
            int randomIndex = Random.Next(Colours.Length);
            s.Colour = Colours[randomIndex];
            return s;
        }

    }
}
