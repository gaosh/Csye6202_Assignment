using System;
using StudentRegistration.Domain;
using System.Collections.Generic;

namespace StudentRegistration.MVP
{
	public class Model : IModel
	{
        static List<Student> studentList = new List<Student>();

        void IModel.Add(Student s)
        {
            studentList.Add(s);
        }

        void IModel.Remove(Student s)
        {
            studentList.Remove(s);
        }
        public List<Student> ReturnList()
        {
            return studentList;
        }
    }
}
