using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PazlMVP
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // View form = new View();
            // Application.Run(Form);

            // ----Application.Run(new View());
            //+++++++++++сами
            View view = new View();  
            Presenter presenter = new Presenter(view);//  Presenter presenter = new Presenter(form); 
            presenter.Start();

            Application.Run();
            ////
            
        }
    }
}
