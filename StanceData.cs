namespace WFCalculations
{
    public class StanceData
    {
        private List<StanceHit> stance_damage_values;

        public StanceData(double base_dmg, string weapon_type, string stance_name)
        {

            switch (weapon_type)
            {
                case "Dagger":
                    stance_damage_values = DaggerStanceHits(base_dmg, stance_name);
                    break;
                default:
                    throw new ArgumentException("Weapon name not valid");

            }
        }

        public List<StanceHit> DaggerStanceHits(double base_dmg, string stance_name)
        {
            List<StanceHit> stance_damage_values = new List<StanceHit>();
            switch (stance_name)
            {
                case "Stanceless":
                    StanceHit hit1 = new StanceHit(base_dmg);
                    stance_damage_values.Add(hit1);

                    StanceHit hit2 = new StanceHit(base_dmg);
                    hit2.multiplier = 3;
                    stance_damage_values.Add(hit2);

                    StanceHit hit3 = new StanceHit(base_dmg);
                    stance_damage_values.Add(hit3);

                    StanceHit hit4 = new StanceHit(base_dmg);
                    hit4.multiplier = 2;
                    hit4.procBleeding = true;
                    stance_damage_values.Add(hit4);
                    return stance_damage_values;

                default:
                    return stance_damage_values;
            }


        }

        public double StanceDamage()
        {
            double total_dmg = 0;
            foreach (StanceHit hit in stance_damage_values)
            {
                total_dmg += hit.StanceDmg();
            }

            return total_dmg;
        }


    }



    public class StanceHit
    {
        public double base_dmg;
        public float multiplier = 1;
        public bool procImpact, procPuncture, procBleeding, procExplosion, procKnockdown, procLifted, procStagger, procRagdoll, procFinisher = false;
        public bool spin, ranged, thrust = false;
        public float slamDmgMultiplier, slamRadialDmgMultiplier = 1f;

        public StanceHit(double base_dmg)
        {
            this.base_dmg = base_dmg;
        }

        public double StanceDmg()
        {
            return base_dmg * multiplier;
        }

    }
}