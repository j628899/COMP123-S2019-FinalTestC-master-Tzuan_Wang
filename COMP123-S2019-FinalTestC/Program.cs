using COMP123_S2019_FinalTestC.Views;
using COMP123_S2019_FinalTestC.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_FinalTestC
{
    public static class Program
    {
        
        public static CharacterGenerationForm characterForm;
        public static CharacterPortfolio characterPortfolio;
        public static AboutForm aboutForm;

        public static object Identity { get; internal set; }

        public static Identity identity;
        public static Skill skill;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGenerationForm();
            characterPortfolio =new CharacterPortfolio();
            identity = new Identity();
            skill = new Skill();
            aboutForm = new AboutForm();
            Application.Run(characterForm);
        }
    }
}
