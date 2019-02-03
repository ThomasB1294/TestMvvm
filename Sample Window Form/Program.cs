using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleWindowForm.DAO;
using SampleWindowForm.ViewModel;
using SampleWindowForm.Views;
namespace SampleWindowForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var viewModel = new PersonViewModel(new PersonMockDAO());

            Application.Run(new PersonView(viewModel));
        }
    }
}
