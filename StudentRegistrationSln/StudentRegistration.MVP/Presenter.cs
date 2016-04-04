using System;

namespace StudentRegistration.MVP
{
	public class Presenter
	{
		private IModel model;
		private IView view;

		private Presenter() { }

		public Presenter(IModel model, IView view)
		{
			this.model = model;
			this.view = view;
		}

		public void Show()
		{
            var login = new Login();
			var form = view as StudentRegistrationForm;

            form.InitModel(model);
            

			if (form != null)
			{
                
                login.ShowDialog();
                if(login.loginSuccess() == true)
                {
                    form.ShowDialog();
                }

			}
		}
	}
}
