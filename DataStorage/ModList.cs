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
        public static readonly string CorrosiveDmg = "Corrosive Damage";
        public static readonly string ViralDmg = "Viral Damage";
        public static readonly string GasDmg = "Gas Damage";
        public static readonly string MagneticDmg = "Magnetic Damage";
        public static readonly string RadiationDmg = "Radiation Damage";
        public static readonly string BlastDmg = "Blast Damage";
        public static readonly string[] elementalMods = new string[]{
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

        public static readonly Dictionary<string, ModData> MOD_DICTIONARY = new Dictionary<string, ModData>()
        {

            {"Condition Overload", new ModData()
                {
                Type = "Melee",
                Cost = 15,
                mod_bonus= new Dictionary<string, float>()
                    {
                        {BaseDmgPS, 0.8f},
                    },
                }
            },
            { "Primed Pressure Point", new ModData()
                {
                    Type = "Melee",
                    Cost = 14,
                    mod_bonus= new Dictionary<string, float>()
                    {
                        {BaseDmg, 1.65f},
                    },
                }
            },
            {"Spoiled Strike", new ModData()
                {
                    Type = "Melee",
                    Cost = 7,
                    mod_bonus= new Dictionary<string, float>()
                    {
                        {BaseDmg, 1f},
                        {AttackSpeed, -0.2f},
                    },
                }
            },
            { "Auger Strike", new ModData()
                {
                    Type = "Melee",
                    Cost = 11,
                    mod_bonus= new Dictionary<string, float>()
                    {
                        {PunctureDmg, 1.2f},
                    },
                }
            },

            { "Buzz Kill", new ModData()
                {
                    Type = "Melee",
                    Cost = 11,
                    mod_bonus= new Dictionary<string, float>()
                    {
                        {SlashDmg, 1.2f},
                    },
                }
            },
            { "Carnis Mandible", new ModData()
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
            { "Collision Force", new ModData()
                {
                    Type = "Melee",
                    Cost = 11,
                    mod_bonus = new Dictionary<string, float>()
        {
            { ImpactDmg, 1.2f },
        },
    }
},
{ "Primed Heavy Trauma", new ModData()
    {
        Type = "Melee",
        Cost = 12,
        mod_bonus = new Dictionary<string, float>()
        {
            { ImpactDmg, 1.65f },
        },
    }
},
{ "Jagged Edge", new ModData()
    {
        Type = "Melee",
        Cost = 7,
        mod_bonus = new Dictionary<string, float>()
        {
            { SlashDmg, 0.9f },
        },
    }
},
{ "Jugulus Barbs", new ModData()
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
{ "Rending Strike", new ModData()
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
{ "Saxum Thorax", new ModData()
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
{ "Sundering Strike", new ModData()
    {
        Type = "Melee",
        Cost = 7,
        mod_bonus = new Dictionary<string, float>()
        {
            { PunctureDmg, 0.9f },
        },
    }
},
{ "Primed Fever Strike", new ModData()
    {
        Type = "Melee",
        Cost = 16,
        mod_bonus = new Dictionary<string, float>()
        {
            { ToxinDmg, 1.65f },
        },
    }
},
{ "Focus Energy", new ModData()
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
{ "Molten Impact", new ModData()
    {
        Type = "Melee",
        Cost = 11,
        mod_bonus = new Dictionary<string, float>()
        {
            { HeatDmg, 0.9f },
        },
    }
},
{ "North Wind", new ModData()
    {
        Type = "Melee",
        Cost = 11,
        mod_bonus = new Dictionary<string, float>()
        {
            { ColdDmg, 0.9f },
        },
    }
},
{ "Proton Snap", new ModData()
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
{ "Shocking Touch", new ModData()
    {
        Type = "Melee",
        Cost = 11,
        mod_bonus = new Dictionary<string, float>()
        {
            { EletricityDmg, 0.9f },
        },
    }
},
{ "Vicious Frost", new ModData()
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
{ "Virulent Scourge", new ModData()
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
{ "Volcanic Edge", new ModData()
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
{ "Voltaic Strike", new ModData()
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
{ "Sacrificial Pressure", new ModData()
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
{ "Sacrificial Steel", new ModData()
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

            { "", new ModData()
            },

        };

        // You can define constants of various data types here
    }

}