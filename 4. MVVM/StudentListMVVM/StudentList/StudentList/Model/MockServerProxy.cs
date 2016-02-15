using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class MockServerProxy
    {
        ObservableCollection<StudentViewModel> _students = new ObservableCollection<StudentViewModel>();

        public ObservableCollection<StudentViewModel> GetStudents()
        {
            return _students;
        }

        public void SaveStudents(ObservableCollection<StudentViewModel> students)
        {
            _students = students;
        }

        public MockServerProxy()
        {
            _students.Add(new StudentViewModel {FirstName = "John", LastName = "Smith", GradePointAverage = 3.75});
            _students.Add(new StudentViewModel {FirstName = "Antoha", LastName = "Garmosha", GradePointAverage = 4.0});
        }
    }
}
