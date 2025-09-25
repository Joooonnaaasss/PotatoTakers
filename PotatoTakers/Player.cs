using System.Windows.Shapes;
using System.Windows.Media;

namespace PotatoTakers
{
    public class Player
    {
        public Rectangle Visual { get; set; } = null!;

        public Player()
        {
            Visual = new Rectangle
            {
                Width = 40,
                Height = 40,
                Fill = Brushes.Green
            };
        }
    }
}
