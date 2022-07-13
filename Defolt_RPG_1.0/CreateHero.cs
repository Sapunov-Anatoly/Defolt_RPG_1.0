using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Defolt_RPG_1._0
{
    public partial class CreateHero : Form
    {
        public CreateHero()
        {
            InitializeComponent();

            string wanted_path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\")); // Поиск пути до корневой папки
            textBoxDescription.Text = File.ReadAllText(wanted_path + "\\Text\\WarriorDescription.txt");

            var Stats = Defolt_RPG_1._0.Heroes.GetWarriorStats();
            labelPowePoints.Text = Stats.Power.ToString();
            labelProtectionPoints.Text = Stats.Protection.ToString();
            labelEndurancePoints.Text = Stats.Endurance.ToString();
            labelInntelligencePoints.Text = Stats.Inntelligence.ToString();
            labelLuckPoints.Text = Stats.Luck.ToString();
            labelCritChancePoints.Text = Stats.CritChance.ToString();
        }
        public string wanted_path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\")); // Поиск пути до корневой папки
        public int HealthPoints = 10;
        public int ManaPoints = 10;
        public int StaminaPoints = 10;

        private void buttonEntryWarrior_Click(object sender, EventArgs e)
        {
            textBoxDescription.Text = File.ReadAllText(wanted_path + "\\Text\\WarriorDescription.txt"); 

            var Stats = Defolt_RPG_1._0.Heroes.GetWarriorStats();
            labelPowePoints.Text = Stats.Power.ToString();
            labelProtectionPoints.Text = Stats.Protection.ToString();
            labelEndurancePoints.Text = Stats.Endurance.ToString();
            labelInntelligencePoints.Text = Stats.Inntelligence.ToString();
            labelLuckPoints.Text = Stats.Luck.ToString();
            labelCritChancePoints.Text = Stats.CritChance.ToString();
        }

        private void buttonEntryMage_Click(object sender, EventArgs e)
        {
            textBoxDescription.Text = File.ReadAllText(wanted_path + "\\Text\\MageDescription.txt");

            var Stats = Defolt_RPG_1._0.Heroes.GetMageStats();
            labelPowePoints.Text = Stats.Power.ToString();
            labelProtectionPoints.Text = Stats.Protection.ToString();
            labelEndurancePoints.Text = Stats.Endurance.ToString();
            labelInntelligencePoints.Text = Stats.Inntelligence.ToString();
            labelLuckPoints.Text = Stats.Luck.ToString();
            labelCritChancePoints.Text = Stats.CritChance.ToString();
        }

        private void buttonEntryArcher_Click(object sender, EventArgs e)
        {
            textBoxDescription.Text = File.ReadAllText(wanted_path + "\\Text\\ArcherDescription.txt");

            var Stats = Defolt_RPG_1._0.Heroes.GetArcherStats();
            labelPowePoints.Text = Stats.Power.ToString();
            labelProtectionPoints.Text = Stats.Protection.ToString();
            labelEndurancePoints.Text = Stats.Endurance.ToString();
            labelInntelligencePoints.Text = Stats.Inntelligence.ToString();
            labelLuckPoints.Text = Stats.Luck.ToString();
            labelCritChancePoints.Text = Stats.CritChance.ToString();
        }

        private void buttonEntryThief_Click(object sender, EventArgs e)
        {
            textBoxDescription.Text = File.ReadAllText(wanted_path + "\\Text\\ThiefDescription.txt");

            var Stats = Defolt_RPG_1._0.Heroes.GetThiefStats();
            labelPowePoints.Text = Stats.Power.ToString();
            labelProtectionPoints.Text = Stats.Protection.ToString();
            labelEndurancePoints.Text = Stats.Endurance.ToString();
            labelInntelligencePoints.Text = Stats.Inntelligence.ToString();
            labelLuckPoints.Text = Stats.Luck.ToString();
            labelCritChancePoints.Text = Stats.CritChance.ToString();
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Ввести имя")
            {
                textBoxName.Clear();
                textBoxName.ForeColor = Color.Black;
            }
        }
        private void textBoxName_Leave(object sender, EventArgs e)
        {
                textBoxName.Text = "Ввести имя";
                textBoxName.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameProcess gameProcess = new GameProcess();
            gameProcess.Show();
            this.Close();
        }

        private void CreateHero_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
