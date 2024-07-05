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
        public required Dictionary<string, decimal> mod_bonus;

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
        public static readonly string AdditiveStatusChance = "Additive Status Chance";
        public static readonly string HeavyEfficiency = "Heavy Efficiency";
        public static readonly string SentientFactionDmg = "Sentient Faction Dmg";

        public static readonly string ReloadSpeed = "Reload Speed";
        public static readonly string MagazineCapacity = "Magazine Capacity";
        public static readonly string ComboDuration = "Combo Duration";

        public static readonly Dictionary<string, ModData> MOD_DICTIONARY = new Dictionary<
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
                    mod_bonus = new Dictionary<string, decimal>() { { BaseDmgPS, 0.8m }, },
                }
            },
            {
                "Hellfire",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, decimal>() { { Constants.HeatDmg, 0.9m }, },
                }
            },
            {
                "Infected Clip",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, decimal>() { { Constants.ToxinDmg, 0.9m }, },
                }
            },
            {
                "Stormbringer",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, decimal>()
                    {
                        { Constants.EletricityDmg, 0.9m },
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
                    mod_bonus = new Dictionary<string, decimal>() { { Constants.ColdDmg, 0.9m }, },
                }
            },
            {
                "Primed Cryo Rounds",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    Restriction = "Cryo Rounds",
                    mod_bonus = new Dictionary<string, decimal>() { { Constants.ColdDmg, 1.65m }, },
                }
            },
            {
                "Serration",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 14,
                    mod_bonus = new Dictionary<string, decimal>() { { BaseDmg, 1.65m }, },
                }
            },
            {
                "Sawtooth Clip",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, decimal>() { { Constants.SlashDmg, 0.9m }, },
                }
            },
            {
                "Radiated Reload",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 7,
                    mod_bonus = new Dictionary<string, decimal>()
                    {
                        { Constants.RadiationDmg, 0.6m },
                        { ModList.ReloadSpeed, 0.4m }
                    },
                }
            },
                        {
                "Primed Pressure Point",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 14,
                    mod_bonus = new Dictionary<string, float>() { { BaseDmg, 1.65f }, },
                }
            },
            {
                "Spoiled Strike",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 7,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { BaseDmg, 1f },
                        { AttackSpeed, -0.2f },
                    },
                }
            },
            {
                "Auger Strike",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>() { { PunctureDmg, 1.2f }, },
                }
            },
            {
                "Buzz Kill",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>() { { SlashDmg, 1.2f }, },
                }
            },
            {
                "Carnis Mandible",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { SlashDmg, 0.9f },
                        { StatusChance, 0.6f },
                    },
                }
            },
            {
                "Collision Force",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>() { { ImpactDmg, 1.2f }, },
                }
            },
            {
                "Primed Heavy Trauma",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 12,
                    mod_bonus = new Dictionary<string, float>() { { ImpactDmg, 1.65f }, },
                }
            },
            {
                "Jagged Edge",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 7,
                    mod_bonus = new Dictionary<string, float>() { { SlashDmg, 0.9f }, },
                }
            },
            {
                "Jugulus Barbs",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { PunctureDmg, 0.9f },
                        { StatusChance, 0.6f },
                    },
                }
            },
            {
                "Rending Strike",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { SlashDmg, 0.6f },
                        { PunctureDmg, 0.8f },
                    },
                }
            },
            {
                "Saxum Thorax",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { ImpactDmg, 0.9f },
                        { StatusChance, 0.6f },
                    },
                }
            },
            {
                "Sundering Strike",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 7,
                    mod_bonus = new Dictionary<string, float>() { { PunctureDmg, 0.9f }, },
                }
            },
            {
                "Primed Fever Strike",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 16,
                    mod_bonus = new Dictionary<string, float>() { { ToxinDmg, 1.65f }, },
                }
            },
            {
                "Focus Energy",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { EletricityDmg, 0.6f },
                        { HeavyEfficiency, 0.4f },
                    },
                }
            },
            {
                "Molten Impact",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>() { { HeatDmg, 0.9f }, },
                }
            },
            {
                "North Wind",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>() { { ColdDmg, 0.9f }, },
                }
            },
            {
                "Proton Snap",
                new ModData()
                {
                    Type = "Melee",
                    Condition = "Wall Latch", // Assuming Condition is a property of ModData
                    Cost = 9,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { ToxinDmg, 1.0f },
                        { HeatDmg, 0.5f },
                    },
                }
            },

{
                "Shocking Touch",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>() { { EletricityDmg, 0.9f }, },
                }
            },
            {
                "Vicious Frost",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 7,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { ColdDmg, 0.6f },
                        { StatusChance, 0.6f },
                    },
                }
            },
            {
                "Virulent Scourge",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 7,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { ToxinDmg, 0.6f },
                        { StatusChance, 0.6f },
                    },
                }
            },
            {
                "Volcanic Edge",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 7,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { HeatDmg, 0.6f },
                        { StatusChance, 0.6f },
                    },
                }
            },
            {
                "Voltaic Strike",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 7,
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { EletricityDmg, 0.6f },
                        { StatusChance, 0.6f },
                    },
                }
            },
            {
                "Sacrificial Pressure",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 16,
                    Restriction = "Pressure Point", // Assuming Restriction is a property of ModData
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { BaseDmg, 1.1f },
                        { SentientFactionDmg, 1.3f },
                    },
                }
            },
            {
                "Sacrificial Steel",
                new ModData()
                {
                    Type = "Melee",
                    Cost = 16,
                    Restriction = "True Steel",
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { "Critical Chance", 2.2f }, // Note the quotes for clarity
                        { "Critical Chance For Heavy Attack", 4.4f },
                        { SentientFactionDmg, 1.3f },
                    },
                }
            },
            {
                "Charged Chamber",
                new ModData()
                {
                    Type = "Sniper",
                    Cost = 9,
                    Restriction = "Primed Chamber", // Assuming Restriction is a property of ModData
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { BaseDmgOnFirstShot, 0.4f },

                    },
                }
            },
            {
                "Primed Chamber",
                new ModData()
                {
                    Type = "Sniper",
                    Cost = 7,
                    Restriction = "Charged Chamber", // Assuming Restriction is a property of ModData
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { BaseDmgOnFirstShot, 0.4f },

                    },
                }
            },
            {
                "Depleted Reload",
                new ModData()
                {
                    Type = "Sniper",
                    Cost = 7,
                    Restriction = "None", // Assuming Restriction is a property of ModData
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { ReloadSpeed, 0.48f },
                        { MagazineCapacity, -0.6f },
                    },
                }
            },
            {
                "Harkonar Scope",
                new ModData()
                {
                    Type = "Sniper",
                    Cost = 9,
                    Condition = "Aiming",
                    Restriction = "None", // Assuming Restriction is a property of ModData
                    mod_bonus = new Dictionary<string, float>()
                    {
                        { ComboDuration, 12f },
                    },
                }
            },
            {
                "Target Acquired",
                new ModData()
                {
                    Type = "Sniper",
                    Cost = 11,

                    mod_bonus = new Dictionary<string, float>()
                    {
                        { HSMulti, 0.6f },
                    },
                }
            },
            //{ "", new ModData() },
        };

        // You can define constants of various data types here
    }
}
