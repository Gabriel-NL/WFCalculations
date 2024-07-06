namespace WFCalculations
{
    public struct ModData
    {
        public required string Type { get; set; } //Example: Melee
        public string SubType = "None"; //Example: Daggers
        public string Exclusivity = "None"; //Example: Prime Fang
        public string Class { get; set; } //Example: Rare
        public string Polarity { get; set; } //Example: Madurai
        public required int Cost { get; set; } //Example: 13
        public string Restriction = "None"; //Example: Primed Pressure point
        public string Condition = "None"; //Example: Wall Latch
        public required Dictionary<string, float> mod_bonus;

        public ModData() { }
    }

    public static class ModList
    {
        public static readonly string BaseDmg = "Base Damage";
        public static readonly string BaseDmgOnFirstShot = "Base Damage On First Shot";
        public static readonly string BaseDmgPS = "Base Damage Per Status";

        public static readonly string[] physicalMods = new string[]
        {
            Constants.ImpactDmg,
            Constants.PunctureDmg,
            Constants.SlashDmg
        };

        public static readonly string HSMulti = "Headshot Multiplyer";

        public static readonly string AttackSpeed = "Attack Speed";
        public static readonly string StatusChance = "Status Chance";
        public static readonly string CritChance = "Critical Chance";
        public static readonly string CritDmg = "Critical Damage";
        public static readonly string AdditiveStatusChance = "Additive Status Chance";
        public static readonly string HeavyEfficiency = "Heavy Efficiency";

        public static readonly string ReloadSpeed = "Reload Speed";
        public static readonly string MagazineCapacity = "Magazine Capacity";
        public static readonly string ComboDuration = "Combo Duration";

        public static readonly Dictionary<string, ModData> MOD_DICTIONARY_PRIMARY = new Dictionary<
            string,
            ModData
        >()
        {
            {
                "Hellfire",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>() { { Constants.HeatDmg, 0.9f }, },
                }
            },
            {
                "Infected Clip",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>() { { Constants.ToxinDmg, 0.9f }, },
                }
            },
            {
                "Stormbringer",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { Constants.EletricityDmg, 0.9f },
                    },
                }
            },
            {
                "Cryo Rounds",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    Restriction = "Primed Cryo Rounds",
                    mod_bonus = new Dictionary<string, float>() { { Constants.ColdDmg, 0.9f }, },
                }
            },
            {
                "Primed Cryo Rounds",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    Restriction = "Cryo Rounds",
                    mod_bonus = new Dictionary<string, float>() { { Constants.ColdDmg, 1.65f }, },
                }
            },
            {
                "Serration",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 14,
                    mod_bonus = new Dictionary<string, float>() { { BaseDmg, 1.65f }, },
                }
            },
            {
                "Sawtooth Clip",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>() { { Constants.SlashDmg, 0.9f }, },
                }
            },
            {
                "Radiated Reload",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 7,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { Constants.RadiationDmg, 0.6f },
                        { ModList.ReloadSpeed, 0.4f }
                    },
                }
            },
            {
                "Hammer Shot",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { ModList.CritDmg, 0.6f },
                        { ModList.StatusChance, 0.8f }
                    },
                }
            },
            {
                "Point Strike",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>() { { ModList.CritChance, 1.5f } },
                }
            },
            {
                "Vital Sense",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>() { { ModList.CritChance, 1.2f } },
                }
            },
            {
                "Critical Delay",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { ModList.CritChance, 2.0f },
                        { ModList.AttackSpeed, -0.2f }
                    },
                }
            },
            {
                "Bane of Corrupted",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { Constants.orokin, 1.3f }
                    },
                }
            },
            {
                "Piercing Caliber",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { Constants.PunctureDmg, 1.2f }
                    },
                }
            },
            {
                "Fanged Fusillade",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { Constants.SlashDmg, 1.2f }
                    },
                }
            },
            {
                "Crash Course",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { Constants.ImpactDmg, 1.2f }
                    },
                }
            },

            //{ "", new ModData() },
        };

        public static readonly Dictionary<string, ModData> MOD_DICTIONARY_SHOTGUN = new Dictionary<
            string,
            ModData
        >()
        {
            };
        public static readonly Dictionary<string, ModData> MOD_DICTIONARY_SECONDARY =
            new Dictionary<string, ModData>() { };

        public static readonly Dictionary<string, ModData> MOD_DICTIONARY_MELEE = new Dictionary<
            string,
            ModData
        >()
        {
            {
                "Condition Overload",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 15,
                    mod_bonus = new Dictionary<string, float>() { { BaseDmgPS, 0.8f }, },
                }
            },
        };
        // You can define constants of various data types here
    }
}
