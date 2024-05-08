namespace WFCalculations
{

    public static class ModList
    {
        public static readonly string BaseDmg = "Base Damage";
        public static readonly string BaseDmgPS = "Base Damage Per Status";
        public static readonly string ImpactDmg = "Impact Damage";
        public static readonly string PunctureDmg = "Puncture Damage";
        public static readonly string SlashDmg = "Slash Damage";
        public static readonly string ToxinDmg = "Toxin Damage";
        public static readonly string EletricityDmg = "Eletricity Damage";
        public static readonly string ColdDmg = "Cold Damage";
        public static readonly string HeatDmg = "Heat Damage";
        public static readonly string AttackSpeed = "Attack Speed";
        public static readonly string StatusChance = "Status Chance";
        public static readonly string AdditiveStatusChance = "Additive Status Chance";
        public static readonly string HeavyEfficiency = "Heavy Efficiency";
        public static readonly string SentientFactionDmg = "Sentient Faction Dmg";


        public static readonly ModData[] MOD_LIST =
        [

            new ModData("Condition Overload")
            {
                Type = "Melee",
                Cost = 15,

                mod_bonus= new Dictionary<string, float>(){
                        {BaseDmgPS, 0.8f},
                    },

            },
            new ModData("Primed Pressure Point")
            {
                Type = "Melee",

                Cost = 14,
                mod_bonus= new Dictionary<string, float>(){
                        {BaseDmg, 1.65f},
                    },


            },
            new ModData("Spoiled Strike")
            {
                Type = "Melee",

                Cost = 7,

                mod_bonus= new Dictionary<string, float>(){
                        {BaseDmg, 1f},
                        {AttackSpeed, -0.2f},
                    },
            },
            new ModData("Auger Strike")
            {
                Type = "Melee",

                Cost = 11,
                mod_bonus= new Dictionary<string, float>(){
                        {PunctureDmg, 1.2f},
                    },


            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                mod_bonus= new Dictionary<string, float>(){
                        {SlashDmg, 1.2f},
                    },


            },
            new ModData("Carnis Mandible")
            {
                Type = "Melee",

                Cost = 9,
                mod_bonus= new Dictionary<string, float>(){
                        {SlashDmg, 0.9f},
                        {StatusChance,0.6f},
                    },

            },
            new ModData("Collision Force")
            {
                Type = "Melee",

                Cost = 11,
                mod_bonus= new Dictionary<string, float>(){
                        {ImpactDmg, 1.2f},
                    },

            },
            new ModData("Primed Heavy Trauma")
            {
                Type = "Melee",

                Cost = 12,
                mod_bonus= new Dictionary<string, float>(){
                        {ImpactDmg, 1.65f},
                    },

            },
            new ModData("Jagged Edge")
            {
                Type = "Melee",

                Cost = 7,
                mod_bonus= new Dictionary<string, float>(){
                        {SlashDmg, 0.9f},
                    },

            },
            new ModData("Jugulus Barbs")
            {
                Type = "Melee",

                Cost = 9,
                mod_bonus= new Dictionary<string, float>(){
                        {PunctureDmg, 0.9f},
                        {StatusChance,0.6f},
                    },

            },
            new ModData("Rending Strike")
            {
                Type = "Melee",

                Cost = 9,
                mod_bonus= new Dictionary<string, float>(){
                        {SlashDmg, 0.6f},
                        {PunctureDmg, 0.8f},
                    },

            },
            new ModData("Saxum Thorax")
            {
                Type = "Melee",

                Cost = 9,

                mod_bonus= new Dictionary<string, float>(){
                        {ImpactDmg, 0.9f},
                        {StatusChance,0.6f},
                    },
            },
            new ModData("Sundering Strike")
            {
                Type = "Melee",

                Cost = 7,
                mod_bonus= new Dictionary<string, float>(){
                        {PunctureDmg, 0.9f},
                    },

            },
            new ModData("Primed Fever Strike")
            {
                Type = "Melee",
                Cost = 16,
                mod_bonus= new Dictionary<string, float>(){
                        {ToxinDmg, 1.65f},
                    },

            },
            new ModData("Focus Energy")
            {
                Type = "Melee",

                Cost = 9,
                mod_bonus= new Dictionary<string, float>(){
                        {EletricityDmg, 0.6f},
                        {HeavyEfficiency, 0.4f},
                    },

            },
            new ModData("Molten Impact")
            {
                Type = "Melee",

                Cost = 11,
                mod_bonus= new Dictionary<string, float>(){
                        {HeatDmg, 0.9f},
                    },

            },
            new ModData("North Wind")
            {
                Type = "Melee",

                Cost = 11,
                mod_bonus= new Dictionary<string, float>(){
                        {ColdDmg, 0.9f},
                    },

            },
            new ModData("Proton Snap")
            {
                Type = "Melee",
                Condition="Wall Latch",
                Cost = 9,
                mod_bonus= new Dictionary<string, float>(){
                        {ToxinDmg,1.0f},
                        {HeatDmg,0.5f},

                    },

            },
            new ModData("Shocking Touch")
            {
                Type = "Melee",

                Cost = 11,
                mod_bonus= new Dictionary<string, float>(){
                        {EletricityDmg, 0.9f},
                    },
            },
            new ModData("Vicious Frost")
            {
                Type = "Melee",

                Cost = 7,
                mod_bonus= new Dictionary<string, float>(){
                        {ColdDmg, 0.6f},
                        {StatusChance,0.6f},
                    },


            },
            new ModData("Virulent Scourge")
            {
                Type = "Melee",

                Cost = 7,
                mod_bonus= new Dictionary<string, float>(){
                        {ToxinDmg, 0.6f},
                        {StatusChance,0.6f},
                    },


            },
            new ModData("Volcanic Edge")
            {
                Type = "Melee",

                Cost = 7,
                mod_bonus= new Dictionary<string, float>(){
                        {HeatDmg, 0.6f},
                        {StatusChance,0.6f},
                    },

            },
            new ModData("Voltaic Strike")
            {
                Type = "Melee",

                Cost = 7,
                mod_bonus= new Dictionary<string, float>(){
                        {EletricityDmg, 0.6f},
                        {StatusChance,0.6f},
                    },

            },
            new ModData("Sacrificial Pressure")
            {
                Type = "Melee",
                Cost = 16,
                Restriction="Pressure Point",
                mod_bonus= new Dictionary<string, float>(){
                        {BaseDmg, 1.1f},
                        {SentientFactionDmg,1.3f},
                    },

            },
            new ModData("Sacrificial Steel")
            {
                Type = "Melee",
                Cost = 16,
                Restriction="True Steel",
                mod_bonus= new Dictionary<string, float>(){
                        {"Critical Chance", 2.2f},
                        {"Critical Chance For Heavy Attack", 4.4f},
                        {SentientFactionDmg,1.3f},
                    },

            },


        ];
        // You can define constants of various data types here
    }

}