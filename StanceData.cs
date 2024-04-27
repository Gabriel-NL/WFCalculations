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
                    StanceHit hit;
                    hit = new StanceHit(base_dmg);
                    stance_damage_values.Add(hit);

                    hit = new StanceHit(base_dmg);
                    hit.multiplier = 3;
                    stance_damage_values.Add(hit);

                    hit = new StanceHit(base_dmg);
                    stance_damage_values.Add(hit);

                    hit = new StanceHit(base_dmg);
                    hit.multiplier = 2;
                    hit.procBleeding = true;
                    stance_damage_values.Add(hit);

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
                total_dmg += hit.HitDmg();
            }

            return total_dmg;
        }


    }




}