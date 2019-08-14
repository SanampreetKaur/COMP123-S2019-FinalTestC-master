using COMP123_S2019_FinalTestC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * STUDENT NAME: SANAMPREET KAUR
 * STUDENT ID:301045503
 * DESCRIPTION: This is the Programs.cs for the application
 */
namespace COMP123_S2019_FinalTestC
{
    public static class Program
    {
        
        public static CharacterGenerationForm characterForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGenerationForm();

            Application.Run(characterForm);
        }
    }
}
