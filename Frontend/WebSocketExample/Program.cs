using System;
using System.Windows.Forms;
using System.Globalization;

namespace WebSocketExample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //PrintCultures();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new Form1(new CultureInfo("de-DE")));
            //Application.Run(new Form1(new CultureInfo("en-UK")));
            //Application.Run(new Form1(new CultureInfo("es-MX")));
        }

        /*
        static void PrintCultures()
        {
            // Displays several properties of the neutral cultures.
            Console.WriteLine("CULTURE\tISO\tISO\tWIN\tDISPLAYNAME\tENGLISHNAME");
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                Console.Write("{0}", ci.Name);
                Console.Write("\t{0}", ci.TwoLetterISOLanguageName);
                Console.Write("\t{0}", ci.ThreeLetterISOLanguageName);
                Console.Write("\t{0}", ci.ThreeLetterWindowsLanguageName);
                Console.Write("\t{0}", ci.DisplayName);
                Console.WriteLine("\t{0}", ci.EnglishName);
            }
        }
        */
    }
}
