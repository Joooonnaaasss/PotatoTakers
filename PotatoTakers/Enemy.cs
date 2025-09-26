using System.Windows.Shapes;
using System.Windows.Media;

namespace PotatoTakers
{
    public class Enemy
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Enemy(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Bewege()
        {
            X += 5; // Gegner läuft z. B. nach rechts
        }
    }
}
