using StudentRegistration.Domain;
using System.Collections.Generic;

namespace StudentRegistration.MVP
{
    
	public interface IModel
	{
        
        
		void Add(Student s);
        List<Student> ReturnList();
		void Remove(Student s);
	}
}
