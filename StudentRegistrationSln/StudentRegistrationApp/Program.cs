using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRegistration.MVP;
using StudentRegistration.Domain;

namespace StudentRegistrationApp
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new StudentRegistrationForm());

			IModel model = new Model();
            helper(model);
            IView view = new StudentRegistrationForm();
			var presenter = new Presenter(model, view);

			//var form = view as StudentRegistrationForm;

			//if (form != null)
			//{
			//	form.ShowDialog();
			//}

			presenter.Show();
		}
        private static Random random = new Random();
        private static string[] department = new string[]{ "Information Systems", "International Affairs", "Nursing", "Pharmacy",
                "Professional Studies", "Psychology", "Public Administration" };

        private static void helper(IModel m)
        {
            
            
            
            for(int i = 0; i < 10; i++)
            {
                int random_index = random.Next(0, 7);
                int random_type = random.Next(0, 2);
                string enrolltype = "";
                if(random_type == 1)
                {
                    enrolltype = "Full Time";
                }
                else
                {
                    enrolltype = "Part Time";
                }
                string FirstName = nameGenerator();
                string LastName = nameGenerator();
                string id = numberGenerator();
            
                Student s = new Student(id,FirstName,LastName,department[random_index],enrolltype);
                m.Add(s);
            }
        }
        private static string nameGenerator()
        {
            var stringChars = new char[5];
            var upper_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var low_chars = "abcdefghijklmnopqrstuvwxyz";
            
            stringChars[0] = upper_chars[random.Next(upper_chars.Length)];
            for (int i = 1; i < stringChars.Length; i++)
            {
                stringChars[i] = low_chars[random.Next(low_chars.Length)];
            }
            string name = new string(stringChars);
            return name;
        }
        private static string numberGenerator()
        {
            var stringChars = new char[11];
            var number_chars = "0123456789";
            
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = number_chars[random.Next(number_chars.Length)];
            }
            stringChars[3] = '-';
            stringChars[6] = '-';
            string number = new string(stringChars);
            return number;
        }
           
            
        
	}
}

