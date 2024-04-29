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

        public ModBonus bonus { get; set; }
        public ModData(string name) : this()
        {
            this.Name = name;
        }

    }

    public struct ModBonus
    {
        public float BaseDmg, BaseDmgPerStatus, HeavyAttackDmg = 0;
        public float PunctureDmg, ImpactDmg, SlashDmg, ToxinDmg, EletricityDmg, HeatDmg, ColdDmg = 0;
        public (string Faction, float FDmg) FactionDmg = ("", 0);

        public float CriticalChance = 0;
        public float CriticalChanceForHeavyAttack = 0;

        public float ExtraCriticalChance, CriticalChancePerCombo, CriticalMultiplier = 0;

        public float StatusChance, StatusChancePerCombo, AdditiveStatusChance, StatusDuration = 0;

        public float InitialCombo, ComboDuration, AddComboChance, HeavyEfficiency = 0;

        public float AttackSpeed, Range, PunchThrough, ThrowDmg, Bounce, BlastRadius = 0;
        public bool ExplodeOnBounce = false;



        public ModBonus()
        {

        }

    }

    public struct Stance
    {

        public string stance_name { get; set; }
        public StanceHit[] neutralCombo { get; set; }
        public double neutralComboDuration { get; set; }
        public StanceHit[] forwardCombo { get; set; }
        public double forwardComboDuration { get; set; }
        public StanceHit[] forwardAndBlockCombo { get; set; }
        public double forwardAndBlockComboDuration { get; set; }
        public StanceHit[] blockCombo { get; set; }
        public double blockComboDuration { get; set; }




        public Stance(string stance_name) : this()
        {
            this.stance_name = stance_name;
        }

    }


    public struct StanceHit
    {

        public double base_dmg { get; set; } = 0;
        public float multiplier { get; set; } = 1;
        public bool procImpact, procPuncture, procBleeding, procExplosion, procKnockdown, procLifted, procStagger, procRagdoll, procFinisher = false;
        public bool spin, ranged, thrust, slam = false;

        public float slamDmgMultiplier, slamRadialDmgMultiplier = 1f;

        public StanceHit(double baseDamage) : this()
        {
            base_dmg = baseDamage;
        }
        public double HitDmg()
        {
            return base_dmg * multiplier;
        }
    }
}
