namespace WFCalculations
{

    public struct ModData
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string SubType = "None";
        public string Class { get; set; }
        public string Polarity { get; set; }
        public int Cost { get; set; }
        public string Restriction = "None";
        public string Condition = "None";

        public Dictionary<string, float> mod_bonus;
        public ModData(string name) : this()
        {
            this.Name = name;
        }

    }



    public struct Stance
    {

        public string StanceName;

        public Combo[] AllCombos { get; set; }


        public Stance(string StanceName) : this()
        {
            this.StanceName = StanceName;
        }

    }

    public struct Combo
    {
        public string ComboName { get; set; }
        public StanceHit[] AllHits { get; set; }
        public float ComboDuration { get; set; }
        public Combo(string combo_name) : this()
        {
            this.ComboName = combo_name;
        }
    }
    public struct StanceHit
    {

        public float multiplier { get; set; } = 1;
        public bool procImpact, procPuncture, procBleeding, procExplosion, procKnockdown, procLifted, procStagger, procRagdoll, procFinisher = false;
        public bool spin, ranged, thrust, slam = false;

        public float slamDmgMultiplier, slamRadialDmgMultiplier = 1f;


        public StanceHit()
        {

        }
        public readonly double HitDmg(double base_dmg)
        {
            return base_dmg * multiplier;
        }
        public readonly double GetMultiplier()
        {
            return multiplier;
        }
    }
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
}
