using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindingSample
{
    class StudentData : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private string _firstName = null;
        public string StudentFirstName
        {
            get { return _firstName; }
            set 
            {
                if (_firstName == value) return;
                _firstName = value;
                OnPropertyChanged("StudentFirstName");
                FullInformationChange();
            }
        }

        private double _gradePointAverage;
        public double StudentGradePointAverage
        {
            get { return _gradePointAverage; }
            set
            {
                if (Math.Abs(_gradePointAverage - value) > 0.02)
                {
                    _gradePointAverage = value;
                    OnPropertyChanged("StudentGradePointAverage");
                    FullInformationChange();
                }
            }
        }
        private string _studentFullInformation = null;
        public string StudentFullInformation
        {
            get { return _studentFullInformation; }
            set
            {
                _studentFullInformation = value;
                OnPropertyChanged("StudentFullInformation");
            }
        }
        private void FullInformationChange()
        {
            StudentFullInformation = string.Format("Student name: {0}, and GradePointAverage: {1}", _firstName, _gradePointAverage);
            OnPropertyChanged("StudentFullInformation");
        }
    }
}
