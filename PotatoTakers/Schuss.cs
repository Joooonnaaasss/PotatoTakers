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
                Height = 10,
                Fill = Brushes.Yellow
            };
        }
    }
}
