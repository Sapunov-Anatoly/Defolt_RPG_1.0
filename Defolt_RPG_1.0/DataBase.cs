using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defolt_RPG_1._0
{
    public class Heroes
    {
        public class ClassStats
        {
            public string classHero;
            public int Power;
            public int Protection;
            public int Endurance;
            public int Inntelligence;
            public int Luck;
            public int CritChance;
        }
        public static ClassStats GetWarriorStats()
        {
            ClassStats warrior = new ClassStats();

            warrior.classHero = "W";    // Воин
            warrior.Power = 13;         // Сила  воина
            warrior.Protection = 13;    // Защита воина
            warrior.Endurance = 10;     // Выносливость воина
            warrior.Inntelligence = 5;  // Интеллект воина
            warrior.Luck = 5;           // Удача воина
            warrior.CritChance = 5;     // Шанс крит. урона воина

            return warrior;
        }
        public static ClassStats GetMageStats()
        {
            ClassStats mage = new ClassStats();

            mage.classHero = "M";        // Маг
            mage.Power = 6;              // Сила  мана
            mage.Protection = 6;         // Защита мага
            mage.Endurance = 6;          // Выносливость мага
            mage.Inntelligence = 16;     // Интеллект мага
            mage.Luck = 10;              // Удача мага
            mage.CritChance = 5;         // Шанс крит. урона мага

            return mage;
        }
        public static ClassStats GetArcherStats()
        {
            ClassStats archer = new ClassStats();

            archer.classHero = "A";      // Лучник
            archer.Power = 11;           // Сила лучника
            archer.Protection = 6;       // Защита лучника
            archer.Endurance = 15;       // Выносливость лучника
            archer.Inntelligence = 5;    // Интеллект лучника
            archer.Luck = 6;             // Удача лучника
            archer.CritChance = 7;       // Шанс крит. урона лучника

            return archer;
        }
        public static ClassStats GetThiefStats()
        {
            ClassStats thief = new ClassStats();

            thief.classHero = "T";   // Вор
            thief.Power = 10;            // Сила вора
            thief.Protection = 8;        // Защита вора
            thief.Endurance = 8;         // Выносливость вора
            thief.Inntelligence = 5;     // Интеллект вора
            thief.Luck = 7;              // Удача вора
            thief.CritChance = 15;       // Шанс крит. урона вора

            return thief;
        }
    }
}
