using System.Windows.Shapes;
using System.Windows.Media;

namespace PotatoTakers
{
    public class Schuss
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Rectangle Visual { get; set; }

        public Schuss(double x, double y)
        {
            X = x;
            Y = y;

            Visual = new Rectangle
            {
                Width = 10,
                Height = 5,
                Fill = Brushes.Yellow
            };
        }

        public void Bewege()
        {
            X += 10; // fliegt nach rechts
        }
    }
}
