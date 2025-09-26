using System.Collections.Generic;
using System.Windows.Shapes;
using System.Windows.Media;

namespace PotatoTakers
{

    public class Tower
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Rectangle Visual { get; set; }
        public List<Schuss> Schuesse { get; set; } = new List<Schuss>();

        public Tower(double x, double y)
        {
            X = x;
            Y = y;

            Visual = new Rectangle
            {
                Width = 40,
                Height = 40,
                Fill = Brushes.Green
            };
        }
    }
}
