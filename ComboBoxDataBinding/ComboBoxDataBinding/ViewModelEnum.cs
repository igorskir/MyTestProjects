using System.Collections.Generic;
using System.ComponentModel;

namespace ComboBoxDataBinding
{
    public class ViewModelEnum : INotifyPropertyChanged
    {
        public enum Colors
        {
            Red = 1,
            Gree = 2,
            Blue = 3,
        }

        private Colors _colorEnum = Colors.Red;

        public ViewModelEnum.Colors ColorEnum
        {
            get { return _colorEnum; }
            set
            {
                if (_colorEnum != value)
                {
                    _colorEnum = value;
                    NotifyPropertyChanged("ColorEnum");
                }
            }

        }
        public List<ComboBoxItemColor> ColorListEnum { get; set; }

        public ViewModelEnum()
        {
            ColorListEnum = new List<ComboBoxItemColor>()
                {
                    new ComboBoxItemColor(){ ValueColorEnum = Colors.Red, 
				ValueColorString = "RedText"},
                    new ComboBoxItemColor(){ ValueColorEnum = Colors.Gree, 
				ValueColorString = "GreenText" },
                    new ComboBoxItemColor(){ ValueColorEnum = Colors.Blue, 
				ValueColorString = "BlueText" },
                };
        }

        #region NotifyProperty Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        #endregion

    }
}
