using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MsdnDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private ObservableCollection<Task> _tasks = new ObservableCollection<Task>()
        {
            new Task() {Description = "Send email to friend", Priority = 2, TaskName = "eMail", TaskType = TaskType.Work},
            new Task() {Description = "Clean bathroom", Priority = 3, TaskName = "Clining", TaskType = TaskType.Home},
            new Task() {Description = "Play games", Priority = 1, TaskName = "Games", TaskType = TaskType.Home}
        };
        public ObservableCollection<Task> Tasks
        {
            get { return _tasks; }
        }
    }


}
