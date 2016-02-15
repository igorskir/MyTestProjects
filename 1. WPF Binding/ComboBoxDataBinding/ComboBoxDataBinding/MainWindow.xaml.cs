using System.Windows;

namespace ComboBoxDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            Example1Window test1 = new Example1Window();
            test1.ShowDialog();
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            Example2Window test2 = new Example2Window();
            test2.ShowDialog();
        }
    }

    


}
