using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PotatoTakers
{
    static class Global
    {
        public static int SpawnSpeed = 50;

        public static Canvas Field { get; set; }

        public static List<Tower> Towers { get; set; } = new List<Tower>();

        public static List<Enemy> Enemies { get; set; } = new List<Enemy>();

    }
}
