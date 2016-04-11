using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentRegistrationWPF;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Presenter presenter = new Presenter();
            presenter.Show();
        }
    }
}
