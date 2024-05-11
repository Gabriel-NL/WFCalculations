namespace WFCalculations
{
    public struct EnemyData
    {

        public string faction;
        public HealthType health_type;

        public EnemyData(string faction, HealthType health_type)
        {

            this.faction = faction;
            this.health_type = health_type;
        }

    }

    public struct HealthType
    {
        public Dictionary<string, float> DmgMultipliers;
        public HealthType() { }
    }
    public static class DummyEnemyTest
    {
        public static readonly Dictionary<string, HealthType> HEALTH_TYPES = new Dictionary<string, HealthType>()
        {
            { "Cloned Flesh", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {ModList.ImpactDmg, 0.75f},
                    {ModList.SlashDmg, 1.25f},
                    {ModList.HeatDmg, 1.25f},
                    {ModList.GasDmg, 0.5f},
                    {ModList.ViralDmg, 1.75f}
                    }
                }
            },
            { "Machinery", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {ModList.ImpactDmg, 1.25f},
                    {ModList.EletricityDmg, 1.5f},
                    {ModList.ToxinDmg, 0.75f},
                    {ModList.BlastDmg, 1.75f},
                    {ModList.ViralDmg, 0.75f}
                    }
                }
            },
            { "Flesh", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {ModList.ImpactDmg, 0.75f},
                    {ModList.SlashDmg, 1.25f},
                    {ModList.ToxinDmg, 1.5f},
                    {ModList.GasDmg, 0.75f},
                    {ModList.ViralDmg, 1.5f}
                    }
                }
            },
            { "Robotic", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {ModList.PunctureDmg,  1.25f},
                    {ModList.SlashDmg, 0.75f},
                    {ModList.EletricityDmg, 1.5f},
                    {ModList.ToxinDmg, 0.75f},
                    {ModList.RadiationDmg, 1.25f}
                    }
                }
            },
            { "Infested", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {ModList.SlashDmg, 1.25f},
                    {ModList.HeatDmg, 1.25f},
                    {ModList.GasDmg, 1.75f},
                    {ModList.RadiationDmg, 0.5f},
                    {ModList.ViralDmg, 0.5f}
                    }
                }
            },
            { "Infested Flesh", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {ModList.SlashDmg, 1.5f},
                    {ModList.ColdDmg, 0.5f},
                    {ModList.HeatDmg, 1.5f},
                    {ModList.GasDmg, 1.5f},
                    }
                }
            },
            { "Fossilized", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {ModList.SlashDmg, 1.15f},
                    {ModList.ColdDmg , 0.75f},
                    {ModList.ToxinDmg, 0.5f},
                    {ModList.BlastDmg, 1.5f},
                    {ModList.CorrosiveDmg, 1.75f},
                    {ModList.RadiationDmg, 0.25f}
                    }
                }
            },
            { "Indifferent Facade", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {ModList.PunctureDmg, 1.25f},
                    {ModList.SlashDmg, 0.5f},
                    {ModList.EletricityDmg, 1.25f},
                    {ModList.RadiationDmg, 1.75f},
                    {ModList.ViralDmg, 0.5f},
                    {Constants.VOID, 1.25f},
                    }
                }
            },
            { "Overguard", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {Constants.VOID, 1.5f},

                    }
                }
            },

        };


        public static readonly Dictionary<string, EnemyData> ENEMIES = new Dictionary<string, EnemyData>(){
            {"Charger", new EnemyData()
                {
                    health_type= HEALTH_TYPES["Infested"]
                }
            },
        };



    }
}