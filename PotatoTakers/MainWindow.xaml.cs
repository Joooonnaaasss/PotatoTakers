using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PotatoTakers
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();



            Globel.Field = MyCanvas;
            GameControl.Initializierung();

        }
    }
}
