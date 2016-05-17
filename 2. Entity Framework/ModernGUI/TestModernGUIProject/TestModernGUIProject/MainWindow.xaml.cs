using FirstFloor.ModernUI.Windows.Controls;
using System.Windows;

namespace TestModernGUIProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            int a = 10;
            int b = 100;
            string msg = "Hello";
            int c = a + b;
            MessageBox.Show(msg);
        }
    }
}
