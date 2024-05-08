namespace WFCalculations
{
    public static class DummyEnemyTest
    {
        public static readonly Dictionary<string, HealthType> HEALTH_TYPES = new Dictionary<string, HealthType>()
        {
            { "Cloned Flesh", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {Constants.IMPACT, 0.75f},
                    {Constants.SLASH, 1.25f},
                    {Constants.HEAT, 1.25f},
                    {Constants.GAS, 0.5f},
                    {Constants.VIRAL, 1.75f}
                    }
                }
            },
            { "Machinery", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {Constants.IMPACT, 1.25f},
                    {Constants.ELETRICITY, 1.5f},
                    {Constants.TOXIN, 0.75f},
                    {Constants.BLAST, 1.75f},
                    {Constants.VIRAL, 0.75f}
                    }
                }
            },
            { "Flesh", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {Constants.IMPACT, 0.75f},
                    {Constants.SLASH, 1.25f},
                    {Constants.TOXIN, 1.5f},
                    {Constants.GAS, 0.75f},
                    {Constants.VIRAL, 1.5f}
                    }
                }
            },
            { "Robotic", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {Constants.PUNCTURE,  1.25f},
                    {Constants.SLASH, 0.75f},
                    {Constants.ELETRICITY, 1.5f},
                    {Constants.TOXIN, 0.75f},
                    {Constants.RADIATION, 1.25f}
                    }
                }
            },
            { "Infested", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {Constants.SLASH, 1.25f},
                    {Constants.HEAT, 1.25f},
                    {Constants.GAS, 1.75f},
                    {Constants.RADIATION, 0.5f},
                    {Constants.VIRAL, 0.5f}
                    }
                }
            },
            { "Infested Flesh", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {Constants.SLASH, 1.5f},
                    {Constants.COLD, 0.5f},
                    {Constants.HEAT, 1.5f},
                    {Constants.GAS, 1.5f},
                    }
                }
            },
            { "Fossilized", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {Constants.SLASH, 1.15f},
                    {Constants.COLD , 0.75f},
                    {Constants.TOXIN, 0.5f},
                    {Constants.BLAST, 1.5f},
                    {Constants.CORROSIVE, 1.75f},
                    {Constants.RADIATION, 0.25f}
                    }
                }
            },
            { "Indifferent Facade", new HealthType()
                {
                DmgMultipliers=new Dictionary<string, float>
                    {
                    {Constants.PUNCTURE, 1.25f},
                    {Constants.SLASH, 0.5f},
                    {Constants.ELETRICITY, 1.25f},
                    {Constants.RADIATION, 1.75f},
                    {Constants.VIRAL, 0.5f},
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