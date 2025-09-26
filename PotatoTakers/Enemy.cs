using System.Windows.Shapes;
using System.Windows.Media;

namespace PotatoTakers
{
    public class Enemy
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Rectangle Visual { get; set; }

        public Enemy(double x, double y)
        {
            X = x;
            Y = y;

            Visual = new Rectangle
            {
                Width = 30,
                Height = 30,
                Fill = Brushes.Red
            };
        }

        public void Bewege()
        {
            X += 5; // Gegner läuft z. B. nach rechts
        }
    }
}
