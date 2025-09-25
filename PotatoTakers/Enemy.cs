using System.Windows.Shapes;
using System.Windows.Media;

namespace PotatoTakers
{
    public class Enemy
    {
        public Ellipse Visual { get; set; }

        public Enemy()
        {
            Visual = new Ellipse
            {
                Width = 30,
                Height = 30,
                Fill = Brushes.Red
            };
        }
    }
}
