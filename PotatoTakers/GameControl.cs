using System;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Threading;

namespace PotatoTakers
{
    public static class GameManager
    {
        public static List<Tower> Towers { get; set; } = new List<Tower>();
        public static List<Enemy> Enemies { get; set; } = new List<Enemy>();
    }
}
