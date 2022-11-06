using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Defolt_RPG_1._0
{
    public partial class GameProcess : Form
    {
        public int healthPoints;
        public int manaPoints;
        public int staminaPoints;
        public int exp;
        public int level;
        public int skillPoints;

        public string nameHero;
        public string classHero; 
        public int powerPoints;
        public int protectionPoints;
        public int endurancePoints;
        public int inntelligencePoints;
        public int luckPoints;
        public int critChancePoints;

        public int expFirst = 0;
        public int expLast;
        public int newSkillPoints;

        // переменные к сохранениям
        public int slot;

        public GameProcess(string nameHero, string classHero, int powerPoints, int protectionPoints, int endurancePoints, int inntelligencePoints, int luckPoints, int critChancePoints, int healthPoints, int manaPoints, int staminaPoints, int level, int exp, int skillPoints)
        {
            InitializeComponent();

            this.nameHero = nameHero;
            this.classHero = classHero;
            this.powerPoints = powerPoints;
            this.protectionPoints = protectionPoints;
            this.endurancePoints = endurancePoints;
            this.inntelligencePoints = inntelligencePoints;
            this.luckPoints = luckPoints;
            this.critChancePoints = critChancePoints;
            this.level = level;
            this.exp = exp;
            this.skillPoints = skillPoints;
            this.healthPoints = healthPoints;
            this.manaPoints = manaPoints;
            this.staminaPoints = staminaPoints;

            GetLevel();
            SelectAvatarHero();
            SelectParametrHero();
            checkSkillPointsPlusButtons();
        }

        public void levelUP(int skillPoints, int expLast, int lvl)
        {
            if (this.exp < expLast)
            {
                labelLevelHero.Text = lvl + " lvl";
                labelExp.Text = exp.ToString() + "/" + expLast + " exp";
            }
            else
            {
                exp = 0;
                level++;
                this.skillPoints += skillPoints;
                labelSkillPoints.Text = "Очки навыков: " + this.skillPoints;
                checkSkillPointsPlusButtons();
                GetLevel();
            }
        }
        public void GetLevel()
        {
            expLast = level * level / 2 + 1;
            if ((level+1) % 5 != 0)
            {
                newSkillPoints = 1;
                levelUP(newSkillPoints, expLast, level);
            }
            else
            {
                newSkillPoints = 5;
                levelUP(newSkillPoints, expLast, level);
            }

        }
        private void SelectAvatarHero()
        {
            string wanted_path = Environment.CurrentDirectory.ToString(); 

            if (classHero == "W")
                pictureBoxHero.Image = Image.FromFile(wanted_path + "\\Images\\Heroes\\Warrior.png");
            else if (classHero == "A")
                pictureBoxHero.Image = Image.FromFile(wanted_path + "\\Images\\Heroes\\Archer.png");
            else if (classHero == "T")
                pictureBoxHero.Image = Image.FromFile(wanted_path + "\\Images\\Heroes\\Thief.png");
            else if (classHero == "M")
                pictureBoxHero.Image = Image.FromFile(wanted_path + "\\Images\\Heroes\\Mage.png");
        }
        private void SelectParametrHero()
        {
            labelNameHero.Text = nameHero;
            textBoxHealtsPoints.Text = healthPoints.ToString();
            textBoxManaPoints.Text = manaPoints.ToString();
            textBoxStaminaPoints.Text = staminaPoints.ToString();

            textBoxPower.Text = "Сила: " + powerPoints;
            textBoxProtection.Text = "Защита: " + protectionPoints;
            textBoxEndurance.Text = "Выносливость: " + endurancePoints;
            textBoxInntelligence.Text = "Интеллект: " + inntelligencePoints;
            textBoxLuck.Text = "Удача: " + luckPoints;
            textBoxCritChance.Text = "Шанс крит. удара: " + critChancePoints;

            labelSkillPoints.Text = "Очки навыков: " + this.skillPoints;
        }
        private void UpdateStatsHero()
        {
            GetLevel(); 
            SelectParametrHero();
        }

        private void buttonEquipment_Click(object sender, EventArgs e)
        {
            exp++;
            UpdateStatsHero();
        }

        private void firstSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slot = 1;
            saveHeroOptions(slot);
        }

        private void secondSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slot = 2;
            saveHeroOptions(slot);
        }

        private void thriesSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slot = 3;
            saveHeroOptions(slot);
        }

        private void fourthSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slot = 4;
            saveHeroOptions(slot);
        }

        private void saveHeroOptions(int slot)
        {
            string pathToSave = Environment.CurrentDirectory.ToString() + "\\Saves\\";

            var heroOptionsNode = new SaveOptionsDataBase.HeroOptionsNode
            {
                HeroOptions = new SaveOptionsDataBase.HeroOptions[]
                {
                    new SaveOptionsDataBase.HeroOptions
                    {
                        healthPoints = this.healthPoints,
                        manaPoints = this.manaPoints,
                        staminaPoints = this.staminaPoints,
                        exp = this.exp,
                        level = this.level,
                        skillPoints = this.skillPoints,
                        NameHero = this.nameHero,
                        classHero = this.classHero,
                        powerPoints = this.powerPoints,
                        protectionPoints = this.protectionPoints,
                        endurancePoints = this.endurancePoints,
                        inntelligencePoints = this.inntelligencePoints,
                        luckPoints = this.luckPoints,
                        critChancePoints = this.critChancePoints
                    }
                }
            };

            var json = JsonConvert.SerializeObject(heroOptionsNode, Formatting.Indented);
            File.WriteAllText(pathToSave + slot + "slot_" + this.nameHero.ToString() + ".json", json);
        }

        private void inMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void powerPointsPlusButton_Click(object sender, EventArgs e)
        {
            SpendSkillPoint();
            powerPoints++;
            UpdateStatsHero();
        }

        private void protectionPointsPlusButton_Click(object sender, EventArgs e)
        {
            SpendSkillPoint();
            protectionPoints++;
            UpdateStatsHero();
        }

        private void endurancePointsPlusButton_Click(object sender, EventArgs e)
        {
            SpendSkillPoint();
            endurancePoints++;
            UpdateStatsHero();
        }

        private void inntelligencePointsPlusButton_Click(object sender, EventArgs e)
        {
            SpendSkillPoint();
            inntelligencePoints++;
            UpdateStatsHero();
        }

        private void luckPointsPlusButton_Click(object sender, EventArgs e)
        {
            SpendSkillPoint();
            luckPoints++;
            UpdateStatsHero();
        }

        private void critChancePointsPlusButton_Click(object sender, EventArgs e)
        {
            SpendSkillPoint();
            critChancePoints++;
            UpdateStatsHero();
        }

        private void SpendSkillPoint()
        {
            skillPoints--;
            if (skillPoints == 0)
            {
                powerPointsPlusButton.Visible = false;
                protectionPointsPlusButton.Visible = false;
                endurancePointsPlusButton.Visible = false;
                inntelligencePointsPlusButton.Visible = false;
                luckPointsPlusButton.Visible = false;
                critChancePointsPlusButton.Visible = false;
            }
            labelSkillPoints.Text = "Очки навыков: " + skillPoints;
        }

        private void checkSkillPointsPlusButtons()
        {
            if (skillPoints != 0)
            {
                powerPointsPlusButton.Visible = true;
                protectionPointsPlusButton.Visible = true;
                endurancePointsPlusButton.Visible = true;
                inntelligencePointsPlusButton.Visible = true;
                luckPointsPlusButton.Visible = true;
                critChancePointsPlusButton.Visible = true;
            }
            else
            {
                powerPointsPlusButton.Visible = false;
                protectionPointsPlusButton.Visible = false;
                endurancePointsPlusButton.Visible = false;
                inntelligencePointsPlusButton.Visible = false;
                luckPointsPlusButton.Visible = false;
                critChancePointsPlusButton.Visible = false;
            }
        }
    }
}
