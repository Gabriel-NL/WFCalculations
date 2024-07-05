namespace WFCalculations
{
    public struct FactionWeakness
    {
        public Dictionary<string, decimal> DmgMultipliers;

        public FactionWeakness() { }
    }

    public class DummyEnemyTest
    {
        public static readonly FactionWeakness[] ALLENEMIES =
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
        public static readonly FactionWeakness grineer = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, decimal>()
            {
                { Constants.ImpactDmg, 1.5m },
                { Constants.CorrosiveDmg, 1.5m },
            }
        };

        public static readonly FactionWeakness kuvaGrineer = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, decimal>()
            {
                { Constants.ImpactDmg, 1.5m },
                { Constants.CorrosiveDmg, 1.5m },
                { Constants.HeatDmg, 0.5m },
            }
        };

        public static readonly FactionWeakness corpus = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, decimal>()
            {
                { Constants.PunctureDmg, 1.5m },
                { Constants.MagneticDmg, 1.5m },
            }
        };

        public static readonly FactionWeakness corpusAmalgam = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, decimal>()
            {
                { Constants.EletricityDmg, 1.5m },
                { Constants.MagneticDmg, 1.5m },
                { Constants.BlastDmg, 0.5m },
            }
        };

        public static readonly FactionWeakness infested = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, decimal>()
            {
                { Constants.SlashDmg, 1.5m },
                { Constants.HeatDmg, 1.5m },
            }
        };

        public static readonly FactionWeakness infestedDeimos = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, decimal>()
            {
                { Constants.BlastDmg, 1.5m },
                { Constants.GasDmg, 1.5m },
                { Constants.ViralDmg, 0.5m },
            }
        };

        public static readonly FactionWeakness narmer = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, decimal>()
            {
                { Constants.SlashDmg, 1.5m },
                { Constants.ToxinDmg, 1.5m },
                { Constants.MagneticDmg, 0.5m },
            }
        };

        public static readonly FactionWeakness orokin = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, decimal>()
            {
                { Constants.PunctureDmg, 1.5m },
                { Constants.ViralDmg, 1.5m },
                { Constants.RadiationDmg, 0.5m },
            }
        };

        public static readonly FactionWeakness sentient = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, decimal>()
            {
                { Constants.ColdDmg, 1.5m },
                { Constants.RadiationDmg, 1.5m },
                { Constants.CorrosiveDmg, 0.5m },
            }
        };
        public static readonly FactionWeakness murmur = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, decimal>()
            {
                { Constants.EletricityDmg, 1.5m },
                { Constants.RadiationDmg, 1.5m },
                { Constants.ViralDmg, 0.5m },
            }
        };
    }
}
