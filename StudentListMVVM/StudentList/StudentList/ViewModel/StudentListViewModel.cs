﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class StudentListViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, 
                    new PropertyChangedEventArgs(propertyName));
        }

        public Func<ObservableCollection<StudentViewModel>> GetStudentsDelegate = null;
        public Action<ObservableCollection<StudentViewModel>> SaveStudentsDelegate = null;

        private ObservableCollection<StudentViewModel> _theStudents = null;

        public ObservableCollection<StudentViewModel> TheStudents
        {
            
            get { return _theStudents; }
            set
            {
                if (_theStudents == value)
                    return;
                if (_theStudents != null)
                {
                    foreach (var student in _theStudents)
                    {
                        DisconnectStudentViewModel(student);
                    }
                }

                _theStudents = value;

                if (_theStudents != null)
                {
                    foreach (var student in _theStudents)
                    {
                        ConnectStudentViewModel(student);
                    }
                }

                OnPropertyChanged("TheStudents");
            }
        }

        void Student_DeleteStudentEvent(StudentViewModel student)
        {
            DisconnectStudentViewModel(student);
            TheStudents.Remove(student);
        }

        void ConnectStudentViewModel(StudentViewModel student)
        {
            student.DeleteStudentEvent += Student_DeleteStudentEvent;
        }

        void DisconnectStudentViewModel(StudentViewModel student)
        {
            student.DeleteStudentEvent -= Student_DeleteStudentEvent;
        }

        public void GetStudentsAction()
        {
            TheStudents = GetStudentsDelegate();

            IsSaveStudentsActionEnabled = true;
            IsAddStudentsActionEnabled = true;
        }

        private bool _isSaveStudentsActionEnabled = false;

        public bool IsSaveStudentsActionEnabled
        {
            get { return _isSaveStudentsActionEnabled; }
            set
            {
                _isSaveStudentsActionEnabled = value;
                OnPropertyChanged("IsSaveStudentsActionEnabled");
            }
        }

        public void SaveStudentsAction()
        {
            if (SaveStudentsDelegate != null)
                SaveStudentsDelegate(TheStudents);
        }

        private bool _isAddStudentsActionEnabled = false;

        public bool IsAddStudentsActionEnabled
        {
            get { return _isAddStudentsActionEnabled; }
            set
            {
                _isAddStudentsActionEnabled = value;
                OnPropertyChanged("IsAddStudentsActionEnabled");
            }
        }

        public void AddStudentAction()
        {
            StudentViewModel newStudentVM = new StudentViewModel {FirstName = null, LastName = null};

            ConnectStudentViewModel(newStudentVM);

            TheStudents.Add(newStudentVM);
        }

    }
}
