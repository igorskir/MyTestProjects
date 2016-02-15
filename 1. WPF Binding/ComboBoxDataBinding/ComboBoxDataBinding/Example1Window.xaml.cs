using System.Windows;

namespace ComboBoxDataBinding
{
    /// <summary>
    /// Interaction logic for Example1Window.xaml
    /// </summary>
    public partial class Example1Window : Window
    {
        private ViewModelString viewModelString = new ViewModelString();
        public Example1Window()
        {
            DataContext = viewModelString;

            InitializeComponent();
        }
    }
}
