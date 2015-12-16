using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CommandBinding
{
    class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            HiButtonCommand = new RelayCommand(ShowMessage, param => this.canExecute);
            ToggleExecuteCommand = new RelayCommand(param => canExecute = !canExecute);
        }
        
        

        public string HiButtonContent
        {
            get
            {
                return "click to hi";
            }
        }
        #region Commands

        public ICommand ToggleExecuteCommand { get; set; }

        public ICommand HiButtonCommand { get; set; }

        #endregion

       

        private bool canExecute = true;
        public bool CanExecute
        {
            get
            {
                return this.canExecute;
            }

            set
            {
                if (this.canExecute == value)
                {
                    return;
                }

                this.canExecute = value;
            }
        }
        

        public void ShowMessage(object obj)
        {
            MessageBox.Show(obj.ToString());
        }


    }
}
