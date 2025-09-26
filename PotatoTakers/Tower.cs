using System.Windows.Media;
using System.Windows.Shapes;

namespace PotatoTakers
{

    public class Tower
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Tower(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
