using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
/*
* STUDENT NAME: Tzu-An Wang
* STUDENT ID: 300987902
* DESCRIPTION: This is the main form for the application
*/

namespace COMP123_S2019_FinalTestC.Views
{
    public partial class CharacterGenerationForm : COMP123_S2019_FinalTestC.Views.MasterForm
    {
        public CharacterGenerationForm()
        {
            InitializeComponent();
        }

        public Stream FRead { get; private set; }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {

            

        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            string LoadFirstName = @"..\..\Data\firstNames.txt";

            var ReadFirstNames = File.ReadAllLines(LoadFirstName);
            List<string> FirstNameList = ReadFirstNames.ToList();
            int FirstNameEndNumber = ReadFirstNames.Length;
            int FirstNameRadomNumber = new Random().Next(0, FirstNameEndNumber);
            Program.identity.FirstName = FirstNameList[FirstNameRadomNumber];
            FirstNameDataLabel.Text = Program.identity.FirstName;


            string LoadLastName = @"..\..\Data\lastNames.txt";

            var ReadLastNames = File.ReadAllLines(LoadLastName);
            List<string> LastNameList = ReadLastNames.ToList();
            int LastNameEndNumber = ReadLastNames.Length;
            int LastNameRadomNumber = new Random().Next(0, LastNameEndNumber);
            Program.identity.LastName = LastNameList[LastNameRadomNumber];
            LastNameDataLabel.Text = Program.identity.LastName;


            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

            private void HelpToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        { 
            

            Random rand = new Random(Guid.NewGuid().GetHashCode());

            List<int> StrengthlistLinq = new List<int>(Enumerable.Range(1, 15));
            StrengthlistLinq = StrengthlistLinq.OrderBy(num => rand.Next()).ToList<int>();

            List<int> DexteritylistLinq = new List<int>(Enumerable.Range(1, 15));
            DexteritylistLinq = DexteritylistLinq.OrderBy(num => rand.Next()).ToList<int>();

            List<int> EndurancelistLinq = new List<int>(Enumerable.Range(1, 15));
            EndurancelistLinq = EndurancelistLinq.OrderBy(num => rand.Next()).ToList<int>();

            List<int> IntellectlistLinq = new List<int>(Enumerable.Range(1, 15));
            IntellectlistLinq = IntellectlistLinq.OrderBy(num => rand.Next()).ToList<int>();

            List<int> EducationlistLinq = new List<int>(Enumerable.Range(1, 15));
            EducationlistLinq = EducationlistLinq.OrderBy(num => rand.Next()).ToList<int>();

            List<int> SocialStandinglistLinq = new List<int>(Enumerable.Range(1, 15));
            SocialStandinglistLinq = SocialStandinglistLinq.OrderBy(num => rand.Next()).ToList<int>();


            int i = 0;
            do
            {
                StrengthlistLinq[i].ToString();
                DexteritylistLinq[i].ToString();
                EndurancelistLinq[i].ToString();
                IntellectlistLinq[i].ToString();
                EducationlistLinq[i].ToString();
                SocialStandinglistLinq[i].ToString();
            }
            while (i > 1);

            Program.characterPortfolio.Strength = StrengthlistLinq[i].ToString();
            Program.characterPortfolio.Dexterity = DexteritylistLinq[i].ToString();
            Program.characterPortfolio.Intellect = EndurancelistLinq[i].ToString();
            Program.characterPortfolio.Dexterity = IntellectlistLinq[i].ToString();
            Program.characterPortfolio.Education = EducationlistLinq[i].ToString();
            Program.characterPortfolio.SocialStanding = SocialStandinglistLinq[i].ToString();

            FirstNameDataLabel.Text = Program.identity.FirstName;
            LastNameDataLabel.Text = Program.identity.LastName;
            StrengthDataLabel.Text = Program.characterPortfolio.Strength;
            DexterityDataLabel.Text = Program.characterPortfolio.Dexterity;
            EnduranceDataLabel.Text = Program.characterPortfolio.Intellect;
            IntellectDataLabel.Text = Program.characterPortfolio.Dexterity;
            EducationDataLabel.Text = Program.characterPortfolio.Education;
            SocialStandingDataLabel.Text = Program.characterPortfolio.SocialStanding;

        }

        private void saveToolStripButton2_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputStream = new StreamWriter(
              File.Open("Character.txt", FileMode.Create)))
            {
                outputStream.WriteLine(Program.identity.FirstName);
                outputStream.WriteLine(Program.identity.LastName);
                outputStream.WriteLine(Program.characterPortfolio.Strength);
                outputStream.WriteLine(Program.characterPortfolio.Dexterity);
                outputStream.WriteLine(Program.characterPortfolio.Intellect);
                outputStream.WriteLine(Program.characterPortfolio.Dexterity);
                outputStream.WriteLine(Program.characterPortfolio.Education);
                outputStream.WriteLine(Program.characterPortfolio.SocialStanding);
                outputStream.WriteLine(Program.skill.Skills1);
                outputStream.WriteLine(Program.skill.Skills2);
                outputStream.WriteLine(Program.skill.Skills3);
                outputStream.WriteLine(Program.skill.Skills4);
                outputStream.Close();
                outputStream.Dispose();
                

                MessageBox.Show("File Saved Successfully!", "Saving...",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputStream = new StreamWriter(
              File.Open("Character.txt", FileMode.Create)))
            {
                outputStream.WriteLine(Program.identity.FirstName);
                outputStream.WriteLine(Program.identity.LastName);
                outputStream.WriteLine(Program.characterPortfolio.Strength);
                outputStream.WriteLine(Program.characterPortfolio.Dexterity);
                outputStream.WriteLine(Program.characterPortfolio.Intellect);
                outputStream.WriteLine(Program.characterPortfolio.Dexterity);
                outputStream.WriteLine(Program.characterPortfolio.Education);
                outputStream.WriteLine(Program.characterPortfolio.SocialStanding);

                outputStream.Close();
                outputStream.Dispose();
                

                MessageBox.Show("File Saved Successfully!", "Saving...",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void openToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader inputStream = new StreamReader(File.Open("Product.txt", FileMode.Open)))
                {



                    Program.identity.FirstName = inputStream.ReadLine();
                    Program.identity.LastName = inputStream.ReadLine();
                    Program.characterPortfolio.Strength = inputStream.ReadLine();
                    Program.characterPortfolio.Dexterity = inputStream.ReadLine();
                    Program.characterPortfolio.Intellect = inputStream.ReadLine();
                    Program.characterPortfolio.Dexterity = inputStream.ReadLine();
                    Program.characterPortfolio.Education = inputStream.ReadLine();
                    Program.characterPortfolio.SocialStanding = inputStream.ReadLine();
                    Program.skill.Skills1 = inputStream.ReadLine();
                    Program.skill.Skills2 = inputStream.ReadLine();
                    Program.skill.Skills3 = inputStream.ReadLine();
                    Program.skill.Skills4 = inputStream.ReadLine();




                    inputStream.Close();
                    inputStream.Dispose();
                }
            }
            catch (IOException exception)
            {

                Debug.WriteLine("ERROR: " + exception.Message);


            }
            StrengthDataLabel.Text = Program.characterPortfolio.Strength;
            DexterityDataLabel.Text = Program.characterPortfolio.Dexterity;
            EnduranceDataLabel.Text = Program.characterPortfolio.Intellect;
            IntellectDataLabel.Text = Program.characterPortfolio.Dexterity;
            EducationDataLabel.Text = Program.characterPortfolio.Education;
            SocialStandingDataLabel.Text = Program.characterPortfolio.SocialStanding;
            Skill1Label.Text = Program.skill.Skills1;
            Skill2Label.Text = Program.skill.Skills2;
            Skill3Label.Text = Program.skill.Skills3;
            Skill4Label.Text = Program.skill.Skills4;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

                try
                {
                    using (StreamReader inputStream = new StreamReader(File.Open("Character.txt", FileMode.Open)))
                    {


                        Program.identity.FirstName = inputStream.ReadLine();
                        Program.identity.LastName = inputStream.ReadLine();
                        Program.characterPortfolio.Strength = inputStream.ReadLine();
                        Program.characterPortfolio.Dexterity = inputStream.ReadLine();
                        Program.characterPortfolio.Intellect = inputStream.ReadLine();
                        Program.characterPortfolio.Dexterity = inputStream.ReadLine();
                        Program.characterPortfolio.Education = inputStream.ReadLine();
                        Program.characterPortfolio.SocialStanding = inputStream.ReadLine();
                    Program.skill.Skills1=inputStream.ReadLine();
                    Program.skill.Skills2=inputStream.ReadLine();
                    Program.skill.Skills3=inputStream.ReadLine();
                    Program.skill.Skills4=inputStream.ReadLine();

                    inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (IOException exception)
                {

                    Debug.WriteLine("ERROR: " + exception.Message);

            }
            StrengthDataLabel.Text = Program.characterPortfolio.Strength;
            DexterityDataLabel.Text = Program.characterPortfolio.Dexterity;
            EnduranceDataLabel.Text = Program.characterPortfolio.Intellect;
            IntellectDataLabel.Text = Program.characterPortfolio.Dexterity;
            EducationDataLabel.Text = Program.characterPortfolio.Education;
            SocialStandingDataLabel.Text = Program.characterPortfolio.SocialStanding;
            Skill1Label.Text = Program.skill.Skills1;
            Skill2Label.Text = Program.skill.Skills2;
            Skill3Label.Text = Program.skill.Skills3;
            Skill4Label.Text = Program.skill.Skills4;

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputStream = new StreamWriter(
              File.Open("Character.txt", FileMode.Create)))
            {
                outputStream.WriteLine(Program.identity.FirstName);
                outputStream.WriteLine(Program.identity.LastName);
                outputStream.WriteLine(Program.characterPortfolio.Strength);
                outputStream.WriteLine(Program.characterPortfolio.Dexterity);
                outputStream.WriteLine(Program.characterPortfolio.Intellect);
                outputStream.WriteLine(Program.characterPortfolio.Dexterity);
                outputStream.WriteLine(Program.characterPortfolio.Education);
                outputStream.WriteLine(Program.characterPortfolio.SocialStanding);
                outputStream.WriteLine (Program.skill.Skills1);
                outputStream.WriteLine (Program.skill.Skills2);
                outputStream.WriteLine ( Program.skill.Skills3);
                outputStream.WriteLine ( Program.skill.Skills4);
                outputStream.Close();
                outputStream.Dispose();


                MessageBox.Show("File Saved Successfully!", "Saving...",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.Show();
            
        }

        private void helpToolStripButton_Click_1(object sender, EventArgs e)
        {
            Program.aboutForm.Show();
        }

        private void SkillLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
                    }

        private void GenerateSkillsButton_Click(object sender, EventArgs e)
        {
            string LoadSkills = @"..\..\Data\Skills.txt";

            var ReadSkills = File.ReadAllLines(LoadSkills);
            List<string> SkillsList = ReadSkills.ToList();
            int SkillsListNumber = ReadSkills.Length;
            int SkillsListRadomNumber = new Random().Next(0, SkillsListNumber);



            Program.skill.Skills1 = SkillsList[SkillsListRadomNumber];


            for (int i = 0; i < 200; i++)
            {
                
                switch (i)
                {
                    case 1:
                        Program.skill.Skills1 = (Program.skill.Skills1 = SkillsList[SkillsListRadomNumber]);
                        break;
                    case 2:
                        Program.skill.Skills2 = (Program.skill.Skills2 = SkillsList[SkillsListRadomNumber]);
                        break;
                    case 3:
                        Program.skill.Skills3 = (Program.skill.Skills3 = SkillsList[SkillsListRadomNumber]);
                        break;
                    case 4:
                        Program.skill.Skills4 = (Program.skill.Skills4 = SkillsList[SkillsListRadomNumber]);
                        break;

                }
            }

            Skill1Label.Text  = Program.skill.Skills1;
            Skill2Label.Text = Program.skill.Skills2;
            Skill3Label.Text = Program.skill.Skills3;
            Skill4Label.Text = Program.skill.Skills4;





        }

 
    } }

