using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
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

namespace MovingTowardWPFDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindInXaml();
        }

        #region ManuallyBing

        private Person _person;

        private void ManuallyMoveData()
        {
            _person = new Person
            {
                FirstName = "Josh",
                LastName = "Smith"
            };

            this.firstNameTextBox.Text = _person.FirstName;
            this.lastNameTextBox.Text = _person.LastName;
            this.fullNameTextBlock.Text = _person.FullName;

            this.firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            this.lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;


        }

        private void firstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _person.FirstName = this.firstNameTextBox.Text;
            this.fullNameTextBlock.Text = _person.FullName;
        }

        void lastNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _person.LastName = this.lastNameTextBox.Text;
            this.fullNameTextBlock.Text = _person.FullName;
        }

        #endregion

        #region BindInCode

        private void BindInCode()
        {
            var person = new Person
            {
                FirstName = "Josh",
                LastName = "Smith"
            };

            Binding b = new Binding();
            b.Source = person;
            b.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            b.Path = new PropertyPath("FirstName");
            b.Mode = BindingMode.TwoWay;
            this.firstNameTextBox.SetBinding(TextBox.TextProperty, b);

            b = new Binding();
            b.Source = person;
            b.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            b.Path = new PropertyPath("LastName");
            this.lastNameTextBox.SetBinding(TextBox.TextProperty, b);

            b = new Binding();
            b.Source = person;
            b.Path = new PropertyPath("FullName");
            this.fullNameTextBlock.SetBinding(TextBlock.TextProperty, b);

        }

        #endregion

        #region BindInXAML

        public void BindInXaml()
        {
            Person p = new Person();
            p.FirstName = "Andrey";
            p.LastName = "Ugarov";
            DataContext = p;

            //base.DataContext = new Person
            //{
            //    FirstName = "Josh",
            //    LastName = "Smith"
            //};
        }

        #endregion


    }

    
}
