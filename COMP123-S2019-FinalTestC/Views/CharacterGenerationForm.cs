using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME: SANAMPREET KAUR
 * STUDENT ID:301045503
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

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
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
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            //generating first name

            string[] FirstNameList = File.ReadAllLines(@"..\..\Data\firstNames.txt");
            Random random = new Random();

            int generate_random_number = random.Next(0, FirstNameList.Length - 1);
            FirstNameDataLabel.Text = FirstNameList[generate_random_number];

            //generating last name
            string[] LastNameList = File.ReadAllLines(@"..\..\Data\lastNames.txt");
            Random rand = new Random();

            int generateRandomNumber = rand.Next(0, LastNameList.Length - 1);
            LastNameDataLabel.Text = LastNameList[generateRandomNumber];

        }

        private void output1_Click(object sender, EventArgs e)
        {
         
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            //generating abilities
            string[] AbilitiesList = File.ReadAllLines(@"..\..\Data\abilities.txt");
            Random random = new Random();

            int generate_random_abilities = random.Next(0, AbilitiesList.Length - 1);
              FirstNameDataLabel.Text= AbilitiesList[generate_random_abilities];

        }

        private void GenerateSkillButton_Click(object sender, EventArgs e)
        {
            //generating skills
            string[] SkillList = File.ReadAllLines(@"..\..\Data\skills.txt");
            Random random = new Random();

            int generate_random_skill = random.Next(0, SkillList.Length - 1);
            FirstNameDataLabel.Text = SkillList[generate_random_skill];
        }
    }
}
