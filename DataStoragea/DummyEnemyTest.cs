namespace WFCalculations
{
    public struct FactionWeakness
    {
        public Dictionary<string, float> DmgMultipliers;

        public FactionWeakness() { }
    }

    public class DummyEnemyTest
    {


        public static readonly Dictionary<string, FactionWeakness> ALL_ENEMIES = new Dictionary<
            string,
            FactionWeakness
        >()
        {
            {
                Constants.grineer,
                new FactionWeakness()
                {
                    DmgMultipliers = new Dictionary<string, float>()
                    {
                        { Constants.ImpactDmg, 1.5f },
                        { Constants.CorrosiveDmg, 1.5f },
                    }
                }
            },
            {
                Constants.kuvaGrineer,
                new FactionWeakness()
                {
                    DmgMultipliers = new Dictionary<string, float>()
                    {
                        { Constants.ImpactDmg, 1.5f },
                        { Constants.CorrosiveDmg, 1.5f },
                        { Constants.HeatDmg, 0.5f },
                    }
                }
            },
            {
                Constants.corpus,
                new FactionWeakness()
                {
                    DmgMultipliers = new Dictionary<string, float>()
                    {
                        { Constants.PunctureDmg, 1.5f },
                        { Constants.MagneticDmg, 1.5f },
                    }
                }
            },
            {
                Constants.corpusAmalgam,
                new FactionWeakness()
                {
                    DmgMultipliers = new Dictionary<string, float>()
                    {
                        { Constants.EletricityDmg, 1.5f },
                        { Constants.MagneticDmg, 1.5f },
                        { Constants.BlastDmg, 0.5f },
                    }
                }
            },
            {
                Constants.infested,
                new FactionWeakness()
                {
                    DmgMultipliers = new Dictionary<string, float>()
                    {
                        { Constants.SlashDmg, 1.5f },
                        { Constants.HeatDmg, 1.5f },
                    }
                }
            },
            {
                Constants.infestedDeimos,
                new FactionWeakness()
                {
                    DmgMultipliers = new Dictionary<string, float>()
                    {
                        { Constants.BlastDmg, 1.5f },
                        { Constants.GasDmg, 1.5f },
                        { Constants.ViralDmg, 0.5f },
                    }
                }
            },
            {
                Constants.narmer,
                new FactionWeakness()
                {
                    DmgMultipliers = new Dictionary<string, float>()
                    {
                        { Constants.SlashDmg, 1.5f },
                        { Constants.ToxinDmg, 1.5f },
                        { Constants.MagneticDmg, 0.5f },
                    }
                }
            },
            {
                Constants.orokin,
                new FactionWeakness()
                {
                    DmgMultipliers = new Dictionary<string, float>()
                    {
                        { Constants.PunctureDmg, 1.5f },
                        { Constants.ViralDmg, 1.5f },
                        { Constants.RadiationDmg, 0.5f },
                    }
                }
            },
            {
                Constants.sentient,
                new FactionWeakness()
                {
                    DmgMultipliers = new Dictionary<string, float>()
                    {
                        { Constants.ColdDmg, 1.5f },
                        { Constants.RadiationDmg, 1.5f },
                        { Constants.CorrosiveDmg, 0.5f },
                    }
                }
            },
            {
                Constants.murmur,
                new FactionWeakness()
                {
                    DmgMultipliers = new Dictionary<string, float>()
                    {
                        { Constants.EletricityDmg, 1.5f },
                        { Constants.RadiationDmg, 1.5f },
                        { Constants.ViralDmg, 0.5f },
                    }
                }
            }
        };
    }
}
