using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistrationWPF.Domain;
using System.Collections.ObjectModel;

namespace StudentRegistrationWPF
{
    public class Model
    {
        //ObservableCollection<Student> studentList = new ObservableCollection<Student>();
        List<Student> studentList = new List<Student>();

        public void Add(Student s)
        {
            studentList.Add(s);
        }

        public void Remove(Student s)
        {
            studentList.Remove(s);
        }
        public List<Student> ReturnList()
        {
            return studentList;
        }
        
    }
}
