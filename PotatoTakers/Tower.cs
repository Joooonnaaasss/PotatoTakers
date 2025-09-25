using System.Windows.Media;
using System.Windows.Shapes;

namespace PotatoTakers
{
    public class Tower
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Health { get; set; } = 5;
        public Rectangle Visual { get; set; } = null!;

        public Tower(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Rectangle CreateVisual()
        {
            return new Rectangle
            {
                Width = 40,
                Height = 40,
                Fill = Brushes.Blue
            };
        }
    }
}
