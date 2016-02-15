using System.Data;
using System.Windows.Controls;
using System.Windows.Input;
using BusinessLib;
using BusinessLib.DataAccess;
using BusinessLib.DataModel;

namespace myTreeViewMVVM.TextSearch.View
{
    /// <summary>
    /// Interaction logic for TextSearchDemoControl.xaml
    /// </summary>
    public partial class TextSearchDemoControl : UserControl
    {
        public TextSearchDemoControl()
        {
            InitializeComponent();

            Person rootPerson = Database.GetFamilyTree();

        }
    }
}
