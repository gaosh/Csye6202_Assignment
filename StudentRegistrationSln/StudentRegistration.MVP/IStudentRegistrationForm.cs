using System;

namespace StudentRegistration.MVP
{
	public interface IStudentRegistrationForm : IView
	{
		event EventHandler DataChanged;
	}
}
