using System.Collections.Generic;
using System.Resources;
using System.Windows;

namespace ComboBoxDataBinding
{
    /// <summary>
    /// Interaction logic for Example2Window.xaml
    /// </summary>
    public partial class Example2Window : Window
    {
        
        
        private ViewModelEnum _viewModelEnum = new ViewModelEnum();
        public ViewModelEnum ViewModelEnum { get; set; }
        

        public Example2Window()
        {
            ViewModelEnum = _viewModelEnum;

           

            DataContext = ViewModelEnum;
            InitializeComponent();
        }
    }
}
