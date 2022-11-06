using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Defolt_RPG_1._0
{
    public partial class CreateHero : Form
    {
        private int level = 1;
        private int exp = 0;
        private int skillPoints = 0;
        private int powerPoints;
        private int protectionPoints;
        private int endurancePoints;
        private int inntelligencePoints;
        private int luckPoints;
        private int critChancePoints;
        public int healthPoints;
        public int manaPoints;
        public int staminaPoints;
        public string wanted_path = Environment.CurrentDirectory.ToString(); // Поиск пути до исполняемого файла
        private string classHero;

        public CreateHero()
        {
            InitializeComponent();

            string wanted_path = Environment.CurrentDirectory.ToString() + "\\Text\\WarriorDescription.txt";
            textBoxDescription.Text = File.ReadAllText(wanted_path);

            Heroes.ClassStats Stats = Heroes.GetWarriorStats();
            CreateHeroOptions(Stats);
        }

        private void buttonEntryWarrior_Click(object sender, EventArgs e)
        {
            textBoxDescription.Text = File.ReadAllText(wanted_path + "\\Text\\WarriorDescription.txt");

            Heroes.ClassStats Stats = Heroes.GetWarriorStats();
            CreateHeroOptions(Stats);
        }

        private void buttonEntryMage_Click(object sender, EventArgs e)
        {
            textBoxDescription.Text = File.ReadAllText(wanted_path + "\\Text\\MageDescription.txt");

            Heroes.ClassStats Stats = Heroes.GetMageStats();
            CreateHeroOptions(Stats);
        }

        private void buttonEntryArcher_Click(object sender, EventArgs e)
        {
            textBoxDescription.Text = File.ReadAllText(wanted_path + "\\Text\\ArcherDescription.txt");

            Heroes.ClassStats Stats = Heroes.GetArcherStats();
            CreateHeroOptions(Stats);
        }

        private void buttonEntryThief_Click(object sender, EventArgs e)
        {
            textBoxDescription.Text = File.ReadAllText(wanted_path + "\\Text\\ThiefDescription.txt");

            Heroes.ClassStats Stats = Heroes.GetThiefStats();
            CreateHeroOptions(Stats);
        }

        private void CreateHeroOptions(Heroes.ClassStats Stats)
        {
            labelPowerPoints.Text = Stats.power.ToString();
            labelProtectionPoints.Text = Stats.protection.ToString();
            labelEndurancePoints.Text = Stats.endurance.ToString();
            labelInntelligencePoints.Text = Stats.inntelligence.ToString();
            labelLuckPoints.Text = Stats.luck.ToString();
            labelCritChancePoints.Text = Stats.critChance.ToString();

            classHero = Stats.classHero;
            powerPoints = Stats.power;
            protectionPoints = Stats.protection;
            endurancePoints = Stats.endurance;
            inntelligencePoints = Stats.inntelligence;
            luckPoints = Stats.luck;
            critChancePoints = Stats.critChance;

            healthPoints = Stats.healthPoints;
            manaPoints = Stats.manaPoints;
            staminaPoints = Stats.staminaPoints;
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
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Ввести имя";
                textBoxName.ForeColor = Color.Gray;
            }
        }

        private void buttonCreateHeroGoToGame_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxName.Text == "Ввести имя")
            {
                MessageBox.Show("Введите имя персонажа", 
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                GameProcess gameProcess = new GameProcess(this.textBoxName.Text,
                                                          this.classHero,
                                                          this.powerPoints,
                                                          this.protectionPoints,
                                                          this.endurancePoints,
                                                          this.inntelligencePoints,
                                                          this.luckPoints,
                                                          this.critChancePoints,
                                                          this.healthPoints,
                                                          this.manaPoints,
                                                          this.staminaPoints,
                                                          level, 
                                                          exp,
                                                          skillPoints);
                gameProcess.Show();
                this.Hide();
            }
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCreateHeroGoToGame_Click(sender, e);
            }
        }
    }
}
