using System;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Threading;
using System.Windows;

namespace PotatoTakers
{
    public static class GameControl
    {
        private static DispatcherTimer timer;
        static int Counter;
        public static void Initializierung()
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(100); // 10 FPS
            timer.Start();
        }

        private static void Timer_Tick(object? sender, EventArgs e)
        {
            Counter++;
            if (Counter % Global.SpawnSpeed == 0) // Alle 10 Ticks (1 Sekunde)
            {
                Global.Enemies.Add(new Enemy());
                //MessageBox.Show(" ");
            }   
            

        }
    }
}
