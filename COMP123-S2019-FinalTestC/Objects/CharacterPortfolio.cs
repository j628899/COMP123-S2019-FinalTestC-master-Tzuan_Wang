using COMP123_S2019_FinalTestC.Views;
using COMP123_S2019_FinalTestC.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME: Tzu-An Wang
 * STUDENT ID: 300987902
 * DESCRIPTION: This is the main container class for the application
 */

namespace COMP123_S2019_FinalTestC.Objects
{
    public class CharacterPortfolio
    {
        //Identity
        public Identity Identity { get; set; }

        //Characteristics
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding { get; set; }

        // skill list
        List<Skill> Skills;

        // Character Portfolio constructor
        public CharacterPortfolio()
        {
            this.Skills = new List<Skill>();
            this.Identity = new Identity();

        }
    }
}
