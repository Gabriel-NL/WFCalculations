namespace WFCalculations
{
    public struct FactionWeakness
    {
        public Dictionary<string, float> DmgMultipliers;

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
            DmgMultipliers = new Dictionary<string, float>()
            {
                { Constants.ImpactDmg, 1.5f },
                { Constants.CorrosiveDmg, 1.5f },
            }
        };

        public static readonly FactionWeakness kuvaGrineer = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, float>()
            {
                { Constants.ImpactDmg, 1.5f },
                { Constants.CorrosiveDmg, 1.5f },
                { Constants.HeatDmg, 0.5f },
            }
        };

        public static readonly FactionWeakness corpus = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, float>()
            {
                { Constants.PunctureDmg, 1.5f },
                { Constants.MagneticDmg, 1.5f },
            }
        };

        public static readonly FactionWeakness corpusAmalgam = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, float>()
            {
                { Constants.EletricityDmg, 1.5f },
                { Constants.MagneticDmg, 1.5f },
                { Constants.BlastDmg, 0.5f },
            }
        };

        public static readonly FactionWeakness infested = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, float>()
            {
                { Constants.SlashDmg, 1.5f },
                { Constants.HeatDmg, 1.5f },
            }
        };

        public static readonly FactionWeakness infestedDeimos = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, float>()
            {
                { Constants.BlastDmg, 1.5f },
                { Constants.GasDmg, 1.5f },
                { Constants.ViralDmg, 0.5f },
            }
        };

        public static readonly FactionWeakness narmer = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, float>()
            {
                { Constants.SlashDmg, 1.5f },
                { Constants.ToxinDmg, 1.5f },
                { Constants.MagneticDmg, 0.5f },
            }
        };

        public static readonly FactionWeakness orokin = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, float>()
            {
                { Constants.PunctureDmg, 1.5f },
                { Constants.ViralDmg, 1.5f },
                { Constants.RadiationDmg, 0.5f },
            }
        };

        public static readonly FactionWeakness sentient = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, float>()
            {
                { Constants.ColdDmg, 1.5f },
                { Constants.RadiationDmg, 1.5f },
                { Constants.CorrosiveDmg, 0.5f },
            }
        };
        public static readonly FactionWeakness murmur = new FactionWeakness()
        {
            DmgMultipliers = new Dictionary<string, float>()
            {
                { Constants.EletricityDmg, 1.5f },
                { Constants.RadiationDmg, 1.5f },
                { Constants.ViralDmg, 0.5f },
            }
        };
    }
}
