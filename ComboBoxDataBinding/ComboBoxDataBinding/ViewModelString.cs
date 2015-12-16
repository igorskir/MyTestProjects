using System.ComponentModel;

namespace ComboBoxDataBinding
{
    class ViewModelString : INotifyPropertyChanged
    {
        public ViewModelString() { }

        private string _colorString = "";

        public string ColorString
        {
            get { return _colorString; }
            set
            {
                if (_colorString != value)
                {
                    _colorString = value;
                    NotifyPropertyChanged("ColorString");
                }
            }
        }

        #region INotifyProperty members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }  

        #endregion

    }
}
