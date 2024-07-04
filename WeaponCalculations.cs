using Microsoft.VisualBasic;

namespace WFCalculations
{
    public class WeaponCalculations
    {
        public Dictionary<string, Stance> stances;
        public WeaponDataModel weapon;
        public FactionWeakness target;


        public WeaponCalculations(WeaponDataModel weapon, FactionWeakness target)
        {
            this.weapon = weapon;
            this.target = target;
        }


        public void ShowAllStanceData(Dictionary<string, Stance> stances)
        {
            Console.WriteLine($"The damage values for {weapon.Type} are:");

            Console.WriteLine(Constants.SEPARATOR);
            foreach (var currentStance in stances)
            {
                foreach (var currentCombo in currentStance.Value.ComboDictionary)
                {
                    Console.WriteLine($"Stance: {currentStance.Key}, Combo: {currentCombo.Key}");
                    Console.WriteLine($"Combo damage: {CalculateDmg(currentCombo.Value.AllHits)} hit count: {currentCombo.Value.AllHits.Length} combo duration: {currentCombo.Value.ComboDuration}");
                    Console.WriteLine(Constants.SEPARATOR);
                }
            }


            //Console.WriteLine($"Neutral combo causes {CalculateDmg(stance.neutralCombo)} damage with {stance.neutralCombo.Length} hits");
        }

        public void ShowStrongestStanceForWeapon(Dictionary<string, Stance> weapon_stances)
        {
            Console.WriteLine($"The best combo for {weapon.Type} is:");
            Console.WriteLine(Constants.SEPARATOR);

            string bestComboName = "";
            string bestStanceName = "";
            double bestTotalDmg = 0f;
            Combo bestCombo = weapon_stances[bestStanceName].ComboDictionary[bestComboName];


            foreach (var currentStance in weapon_stances)
            {
                foreach (var currentCombo in currentStance.Value.ComboDictionary)
                {
                    if (bestCombo.AllHits == null || CalculateDmg(currentCombo.Value.AllHits) > CalculateDmg(bestCombo.AllHits))
                    {
                        bestComboName = currentCombo.Key;
                        bestStanceName = currentStance.Key;
                        bestTotalDmg = CalculateDmg(currentCombo.Value.AllHits);
                    }
                }
            }

            Console.WriteLine($"The {bestComboName} from {bestStanceName} has the most damage");
            Console.WriteLine($"TotalDmg: {bestTotalDmg}");

        }

        public double CalculateDmg(StanceHit[] combo)
        {
            double total_dmg = 0;
            foreach (StanceHit hit in combo)
            {

                total_dmg += hit.GetMultiplier() * weapon.GetQuantumBaseDmg(target);
            }
            return total_dmg;
        }

        public void CalculateAverageDPS()
        {

        }

        public void CalculateStanceData(double base_dmg)
        {
            switch (weapon.Type)
            {
                case "Dagger":

                    stances = StanceList.DAGGER_STANCE_DICTIONARY;
                    //ShowAllStanceData(stances);
                    ShowStrongestStanceForWeapon(stances);
                    break;

                case "Staff":

                    stances = StanceList.STAFF_STANCE_DICTIONARY;
                    ShowStrongestStanceForWeapon(stances);
                    break;
                case "Machete":
                    break;
                case "Polearm":
                    break;
                case "Rapier":
                    break;
                case "Scythe":
                    break;
                case "Heavy Blade":
                    break;
                case "Sword":
                    break;
                case "Hammer":
                    break;
                case "Nikana":
                    break;

                default:
                    throw new ArgumentException("Weapon name not valid");

            }

        }



    }


}