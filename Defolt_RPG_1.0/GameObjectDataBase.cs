

using System.Threading;

namespace Defolt_RPG_1._0
{
    public class Heroes
    {
        public class ClassStats
        {
            public  string classHero;
            public int power;
            public int protection;
            public int endurance;
            public int inntelligence;
            public int luck;
            public int critChance;
            public int healthPoints;
            public int manaPoints;
            public int staminaPoints;
        }
        public static ClassStats GetWarriorStats()
        {
            ClassStats warrior = new ClassStats();

            warrior.classHero = "W";    // Воин
            warrior.power = 13;         // Сила  воина
            warrior.protection = 13;    // Защита воина
            warrior.endurance = 10;     // Выносливость воина
            warrior.inntelligence = 5;  // Интеллект воина
            warrior.luck = 5;           // Удача воина
            warrior.critChance = 5;     // Шанс крит. урона воина
            warrior.healthPoints = 150;
            warrior.manaPoints = 50;
            warrior.staminaPoints = 100;


            return warrior;
        }
        public static ClassStats GetMageStats()
        {
            ClassStats mage = new ClassStats();

            mage.classHero = "M";        // Маг
            mage.power = 6;              // Сила  мана
            mage.protection = 6;         // Защита мага
            mage.endurance = 6;          // Выносливость мага
            mage.inntelligence = 16;     // Интеллект мага
            mage.luck = 10;              // Удача мага
            mage.critChance = 5;         // Шанс крит. урона мага
            mage.healthPoints = 50;
            mage.manaPoints = 200;
            mage.staminaPoints = 50;

            return mage;
        }
        public static ClassStats GetArcherStats()
        {
            ClassStats archer = new ClassStats();

            archer.classHero = "A";      // Лучник
            archer.power = 11;           // Сила лучника
            archer.protection = 6;       // Защита лучника
            archer.endurance = 15;       // Выносливость лучника
            archer.inntelligence = 5;    // Интеллект лучника
            archer.luck = 6;             // Удача лучника
            archer.critChance = 7;       // Шанс крит. урона лучника
            archer.healthPoints = 100;
            archer.manaPoints = 60;
            archer.staminaPoints = 150;

            return archer;
        }
        public static ClassStats GetThiefStats()
        {
            ClassStats thief = new ClassStats();

            thief.classHero = "T";   // Вор
            thief.power = 10;            // Сила вора
            thief.protection = 8;        // Защита вора
            thief.endurance = 8;         // Выносливость вора
            thief.inntelligence = 5;     // Интеллект вора
            thief.luck = 7;              // Удача вора
            thief.critChance = 15;       // Шанс крит. урона вора
            thief.healthPoints = 150;
            thief.manaPoints = 50;
            thief.staminaPoints = 150;

            return thief;
        }
    }
    public class Enemies
    {

    }
}
