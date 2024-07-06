namespace WFCalculations
{
    public static class Constants
    {
        public static string SEPARATOR = string.Join("-", Enumerable.Repeat('-', 20));
        public static readonly string[] ALLZAWSTRIKES = new string[]
        {
            "Balla",
            "Cyath",
            "Dehtat",
            "Dokrahm",
            "Kronsh",
            "Mewan",
            "Ooltha",
            "Rabvee",
            "Sepfahn",
            "Plague Keewar",
            "Plague Kripath"
        };
        public static readonly string[] ALLZAWGRIPS = new string[]
        {
            "Jayap",
            "Korb",
            "Kroostra",
            "Kwath",
            "Laka",
            "Peye",
            "Seekalla",
            "Shtung",
            "Plague Akwin",
            "Plague Bokwin"
        };
        public static readonly string[] ALLZAWLINKS = new string[]
        {
            "Jai",
            "Ruhang",
            "Jai II",
            "Ruhang II",
            "Vargeet Jai",
            "Vargeet Ruhang",
            "Ekwana Jai",
            "Ekwana Ruhang",
            "Vargeet II Jai",
            "Vargeet II Ruhang",
            "Ekwana II Jai",
            "Ekwana II Ruhang",
            "Vargeet Jai II",
            "Vargeet Ruhang II",
            "Ekwana Jai II",
            "Ekwana Ruhang II"
        };
        public static readonly string[] ALLWEAPONTYPES = new string[]
        {
            "Primary",
            "Secondary",
            "Melee"
        };
        public static readonly string[] ALLWEAPONSERIES = new string[]
        {
            "Incarnon",
            "Kuva",
            "Prime",
            "Prisma",
            "Tenet",
            "Vandal",
            "Wraith",
            "Zaw"
        };

        public const string ImpactDmg = "Impact Damage";
        public const string PunctureDmg = "Puncture Damage";
        public const string SlashDmg = "Slash Damage";
        public const string ToxinDmg = "Toxin Damage";
        public const string EletricityDmg = "Eletricity Damage";
        public const string ColdDmg = "Cold Damage";
        public const string HeatDmg = "Heat Damage";
        public const string CorrosiveDmg = "Corrosive Damage";
        public const string ViralDmg = "Viral Damage";
        public const string GasDmg = "Gas Damage";
        public const string MagneticDmg = "Magnetic Damage";
        public const string RadiationDmg = "Radiation Damage";
        public const string BlastDmg = "Blast Damage";
        public const string VoidDmg = "Void Damage";

        public static readonly string[] baseElementalMods = new string[]
        {
            Constants.ToxinDmg,
            Constants.EletricityDmg,
            Constants.HeatDmg,
            Constants.ColdDmg,
        };
        public static readonly string[] complexElementalMods = new string[]
        {
            Constants.CorrosiveDmg,
            Constants.GasDmg,
            Constants.ViralDmg,
            Constants.RadiationDmg,
            Constants.MagneticDmg,
            Constants.BlastDmg
        };
        public static readonly Dictionary<string, (string, string)> Combinations = new Dictionary<
            string,
            (string, string)
        >
        {
            { Constants.CorrosiveDmg, (Constants.ToxinDmg, Constants.EletricityDmg) },
            { Constants.ViralDmg, (Constants.ToxinDmg, Constants.ColdDmg) },
            { Constants.GasDmg, (Constants.ToxinDmg, Constants.HeatDmg) },
            { Constants.MagneticDmg, (Constants.EletricityDmg, Constants.ColdDmg) },
            { Constants.RadiationDmg, (Constants.EletricityDmg, Constants.HeatDmg) },
            { Constants.BlastDmg, (Constants.HeatDmg, Constants.ColdDmg) }
        };

        public const string grineer = "grineer";
        public const string kuvaGrineer = "kuva grineer";
        public const string corpus = "corpus";
        public const string corpusAmalgam = "corpus amalgam";
        public const string infested = "infested";
        public const string infestedDeimos = "infested deimos";
        public const string narmer = "narmer";
        public const string orokin = "orokin";
        public const string sentient = "sentient";
        public const string murmur = "murmur";

        public static readonly string[] ALL_ENEMY_NAMES =
        [
            grineer,
            kuvaGrineer,
            corpus,
            corpusAmalgam,
            infested,
            infestedDeimos,
            narmer,
            orokin,
            sentient,
            murmur
        ];
    }
}
