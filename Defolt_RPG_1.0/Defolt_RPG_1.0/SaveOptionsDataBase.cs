using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Defolt_RPG_1._0
{
    public class SaveOptionsDataBase
    {
        public class HeroOptionsNode
        {
            [JsonProperty("heroOptions")]
            public HeroOptions[] HeroOptions { get; set; }
        }

        public class HeroOptions
        {
            [JsonProperty("healthPoints")]
            public int healthPoints { get; set; }

            [JsonProperty("manaPoints")]
            public int manaPoints { get; set; }
            
            [JsonProperty("staminaPoints")]
            public int staminaPoints { get; set; }
            
            [JsonProperty("exp")]
            public int exp { get; set; }

            [JsonProperty("level")]
            public int level { get; set; }

            [JsonProperty("skillPoints")]
            public int skillPoints { get; set; }

            [JsonProperty("NameHero")]
            public string NameHero { get; set; }

            [JsonProperty("classHero")]
            public string classHero { get; set; }

            [JsonProperty("powerPoints")]
            public int powerPoints { get; set; }

            [JsonProperty("protectionPoints")]
            public int protectionPoints { get; set; }

            [JsonProperty("endurancePoints")]
            public int endurancePoints { get; set; }

            [JsonProperty("inntelligencePoints")]
            public int inntelligencePoints { get; set; }

            [JsonProperty("luckPoints")]
            public int luckPoints { get; set; }

            [JsonProperty("critChancePoints")]
            public int critChancePoints { get; set; }
        }

        public class loadOptionsNode
        {
            [JsonProperty("savesNames")]
            public HeroOptions[] savesNames { get; set; }
        }

        public class loadOptions
        {
            [JsonProperty("firstSaveSlot")]
            public HeroOptions[] firstSaveSlot { get; set; }

            [JsonProperty("secondSaveSlot")]
            public HeroOptions[] secondSaveSlot { get; set; }

            [JsonProperty("thirdSaveSlot")]
            public HeroOptions[] thirdSaveSlot { get; set; }

            [JsonProperty("fourthSaveSlot")]
            public HeroOptions[] fourthSaveSlot { get; set; }
        }


    }
}
