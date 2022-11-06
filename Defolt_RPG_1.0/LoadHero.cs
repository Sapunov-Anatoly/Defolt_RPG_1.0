using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing;

namespace Defolt_RPG_1._0
{
    public partial class LoadHero : Form
    {
        public string pathToSave = Environment.CurrentDirectory.ToString() + "\\Saves\\";
        public string saveName1;
        public string saveName2;
        public string saveName3;
        public string saveName4;

        public LoadHero()
        {
            InitializeComponent();
        }

        private void load(string saveName)
        {
            string configText = File.ReadAllText(pathToSave + saveName);
            JObject o = JObject.Parse(configText);
            string jsonText = o["heroOptions"].ToString().Replace("[", "").Replace("]", "");
            SaveOptionsDataBase.HeroOptions returnedConfig = JsonConvert.DeserializeObject<SaveOptionsDataBase.HeroOptions>(jsonText);

            GameProcess gameProcess = new GameProcess(returnedConfig.NameHero,
                                                          returnedConfig.classHero,
                                                          returnedConfig.powerPoints,
                                                          returnedConfig.protectionPoints,
                                                          returnedConfig.endurancePoints,
                                                          returnedConfig.inntelligencePoints,
                                                          returnedConfig.luckPoints,
                                                          returnedConfig.critChancePoints,
                                                          returnedConfig.healthPoints,
                                                          returnedConfig.manaPoints,
                                                          returnedConfig.staminaPoints,
                                                          returnedConfig.level,
                                                          returnedConfig.exp,
                                                          returnedConfig.skillPoints);
            this.Hide();
            gameProcess.ShowDialog();
        }

        private void LoadHero_Load(object sender, EventArgs e)
        {
            string[] sourceFolderFiles = Directory.GetFiles(pathToSave);
            foreach (string file in sourceFolderFiles)
            {
                string fileName = Path.GetFileName(file);
                if (fileName.Contains("1slot_"))
                {
                    saveName1 = fileName;
                    SaveOptionsDataBase.HeroOptions HeroOptions = readSaveFile(fileName);
                    string pathToIcon = PathToIconClass(HeroOptions.classHero);
                    string heroClassText = HeroClassOptions(HeroOptions.classHero);
                    pictureBoxLoadSave1.Image = Image.FromFile(pathToIcon);
                    labelName1.Text = HeroOptions.NameHero;
                    labelClass1.Text = heroClassText;
                    labelLvl1.Text = HeroOptions.level.ToString();
                }
                if (fileName.Contains("2slot_"))
                {
                    saveName2 = fileName;
                    SaveOptionsDataBase.HeroOptions HeroOptions = readSaveFile(fileName);
                    string pathToIcon = PathToIconClass(HeroOptions.classHero);
                    string heroClassText = HeroClassOptions(HeroOptions.classHero);
                    pictureBoxLoadSave2.Image = Image.FromFile(pathToIcon);
                    labelName2.Text = HeroOptions.NameHero;
                    labelClass2.Text = heroClassText;
                    labelLvl2.Text = HeroOptions.level.ToString();
                }
                if (fileName.Contains("3slot_"))
                {
                    saveName3 = fileName;
                    SaveOptionsDataBase.HeroOptions HeroOptions = readSaveFile(fileName);
                    string pathToIcon = PathToIconClass(HeroOptions.classHero);
                    string heroClassText = HeroClassOptions(HeroOptions.classHero);
                    pictureBoxLoadSave3.Image = Image.FromFile(pathToIcon);
                    labelName3.Text = HeroOptions.NameHero;
                    labelClass3.Text = heroClassText;
                    labelLvl3.Text = HeroOptions.level.ToString();
                }
                if (fileName.Contains("4slot_"))
                {
                    saveName4 = fileName;
                    SaveOptionsDataBase.HeroOptions HeroOptions = readSaveFile(fileName);
                    string pathToIcon = PathToIconClass(HeroOptions.classHero);
                    string heroClassText = HeroClassOptions(HeroOptions.classHero);
                    pictureBoxLoadSave4.Image = Image.FromFile(pathToIcon);
                    labelName4.Text = HeroOptions.NameHero;
                    labelClass4.Text = heroClassText;
                    labelLvl4.Text = HeroOptions.level.ToString();
                }
            }
        }

        private SaveOptionsDataBase.HeroOptions readSaveFile(string NameSaveFile)
        {
            string configText = File.ReadAllText(pathToSave + NameSaveFile);
            JObject o = JObject.Parse(configText);
            string jsonText = o["heroOptions"].ToString().Replace("[", "").Replace("]", "");
            SaveOptionsDataBase.HeroOptions returnedConfig = JsonConvert.DeserializeObject<SaveOptionsDataBase.HeroOptions>(jsonText);

            return returnedConfig;
        }

        private string PathToIconClass(string classHero)
        {
            string wanted_path = Environment.CurrentDirectory.ToString();

            if (classHero == "W")
                return (wanted_path + "\\Images\\Heroes\\Warrior.png");
            else if (classHero == "A")
                return (wanted_path + "\\Images\\Heroes\\Archer.png");
            else if (classHero == "T")
                return (wanted_path + "\\Images\\Heroes\\Thief.png");
            else if (classHero == "M")
                return (wanted_path + "\\Images\\Heroes\\Mage.png");
            else return "";
        }

        private string HeroClassOptions(string classHero)
        {
            string wanted_path = Environment.CurrentDirectory.ToString();

            if (classHero == "W")
                return "Воин";
            else if (classHero == "A")
                return "Лучник";
            else if (classHero == "T")
                return "Вор";
            else if (classHero == "M")
                return "Маг";
            else return "";
        }

        private void buttonLoadSave1_Click(object sender, EventArgs e)
        {
            try
            {
                string saveName = saveName1;
                load(saveName);
            }
            catch
            {
                MessageBox.Show("Сохранение игры не найдено");
            }
        }

        private void buttonLoadSave2_Click(object sender, EventArgs e)
        {
            try
            {
                string saveName = saveName2;
                load(saveName);
            }
            catch
            {
                MessageBox.Show("Сохранение игры не найдено");
            }
        }

        private void buttonLoadSave3_Click(object sender, EventArgs e)
        {
            try
            {
                string saveName = saveName3;
                load(saveName);
            }
            catch
            {
                MessageBox.Show("Сохранение игры не найдено");
            }
        }

        private void buttonLoadSave4_Click(object sender, EventArgs e)
        {
            try
            {
                string saveName = saveName4;
                load(saveName);
            }
            catch
            {
                MessageBox.Show("Сохранение игры не найдено");
            }
        }
    }
}
