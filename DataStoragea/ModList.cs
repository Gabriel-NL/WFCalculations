namespace WFCalculations
{
    public struct ModData
    {
        public string Name { get; set; } //Example: Covert Letality
        public string Type { get; set; } //Example: Melee
        public string SubType = "None"; //Example: Daggers
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
        public static readonly string ImpactDmg = "Impact Damage";
        public static readonly string PunctureDmg = "Puncture Damage";
        public static readonly string SlashDmg = "Slash Damage";
        public static readonly string[] physicalMods = new string[]
        {
            ImpactDmg,
            PunctureDmg,
            SlashDmg
        };
        public static readonly string ToxinDmg = "Toxin Damage";
        public static readonly string EletricityDmg = "Eletricity Damage";
        public static readonly string ColdDmg = "Cold Damage";
        public static readonly string HeatDmg = "Heat Damage";
        public static readonly string CorrosiveDmg = "Corrosive Damage";
        public static readonly string ViralDmg = "Viral Damage";
        public static readonly string GasDmg = "Gas Damage";
        public static readonly string MagneticDmg = "Magnetic Damage";
        public static readonly string RadiationDmg = "Radiation Damage";
        public static readonly string BlastDmg = "Blast Damage";
        public static readonly string HSMulti= "Headshot Multiplyer";
        public static readonly string[] elementalMods = new string[]
        {
            ModList.ToxinDmg,
            ModList.EletricityDmg,
            ModList.HeatDmg,
            ModList.ColdDmg,
            ModList.CorrosiveDmg,
            ModList.GasDmg,
            ModList.ViralDmg,
            ModList.RadiationDmg,
            ModList.MagneticDmg,
            ModList.BlastDmg
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
            
            { "", new ModData() },
        };

        // You can define constants of various data types here
    }
}
