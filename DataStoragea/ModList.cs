namespace WFCalculations
{
    public struct ModData
    {
        public string Name { get; set; } //Example: Covert Letality
        public string Type { get; set; } //Example: Melee
        public string SubType = "None"; //Example: Daggers
        public string Exclusivity = "None"; //Example: Prime Fang
        public string Class { get; set; } //Example: Rare
        public string Polarity { get; set; } //Example: Madurai
        public int Cost { get; set; } //Example: 13
        public string Restriction = "None"; //Example: Primed Pressure point
        public string Condition = "None"; //Example: Wall Latch
        public Dictionary<string, float> mod_bonus;

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
        public static readonly string[] elementalMods = new string[]
        {
            Constants.ToxinDmg,
            Constants.EletricityDmg,
            Constants.HeatDmg,
            Constants.ColdDmg,
            Constants.CorrosiveDmg,
            Constants.GasDmg,
            Constants.ViralDmg,
            Constants.RadiationDmg,
            Constants.MagneticDmg,
            Constants.BlastDmg
        };

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
                    mod_bonus = new Dictionary<string, float>() { { BaseDmgPS, 0.8f }, },
                }
            },
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
                "Stormbringer",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>() { { Constants.EletricityDmg, 0.9f }, },
                }
            },
            {
                "Cryo Rounds",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    Restriction="Primed Cryo Rounds",
                    mod_bonus = new Dictionary<string, float>() { { Constants.ColdDmg, 0.9f }, },
                }
            },
            {
                "Primed Cryo Rounds",
                new ModData()
                {
                    Type = "Rifle",
                    Cost = 11,
                    Restriction="Cryo Rounds",
                    mod_bonus = new Dictionary<string, float>() { { Constants.ColdDmg, 1.65f }, },
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
            { "", new ModData() },
        };

        // You can define constants of various data types here
    }
}
