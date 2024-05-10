using Microsoft.VisualBasic;

namespace WFCalculations
{
    public class StanceCalculations
    {
        public Stance[] stances;
        public WeaponDataModel weapon;
        public EnemyData target;


        public StanceCalculations(WeaponDataModel weapon, EnemyData target)
        {
            this.weapon = weapon;
            this.target = target;
        }


        public void ShowAllStanceData(Stance[] stances)
        {
            Console.WriteLine($"The damage values for {weapon.Type} are:");

            Console.WriteLine(Constants.SEPARATOR);

            foreach (Stance stance in stances)
            {
                foreach (Combo combo in stance.AllCombos)
                {
                    Console.WriteLine($"Stance: {stance.StanceName}, Combo: {combo.ComboName}");
                    Console.WriteLine($"Combo damage: {CalculateDmg(combo.AllHits)} hit count: {combo.AllHits.Length} combo duration: {combo.ComboDuration}");
                    Console.WriteLine(Constants.SEPARATOR);
                }
            }

            //Console.WriteLine($"Neutral combo causes {CalculateDmg(stance.neutralCombo)} damage with {stance.neutralCombo.Length} hits");
        }

        public void ShowStrongestStanceForWeapon(Stance[] stances)
        {
            Console.WriteLine($"The best combo for {weapon.Type} is:");
            Console.WriteLine(Constants.SEPARATOR);

            Combo bestCombo = new Combo();
            String bestStanceName = "";
            foreach (Stance stance in stances)
            {
                foreach (Combo combo in stance.AllCombos)
                {

                    if (bestCombo.ComboName == null || (CalculateDmg(combo.AllHits)) > (CalculateDmg(bestCombo.AllHits)))
                    {
                        bestCombo = combo;
                        bestStanceName = stance.StanceName;
                    }
                }
            }
            Console.WriteLine($"The {bestCombo.ComboName} from {bestStanceName} has the most damage");
            Console.WriteLine($"TotalDmg: {CalculateDmg(bestCombo.AllHits)}");

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



        public void CalculateStanceData(double base_dmg)
        {
            switch (weapon.Type)
            {
                case "Dagger":

                    stances = StanceList.DAGGERSTANCES;
                    //ShowAllStanceData(stances);
                    ShowStrongestStanceForWeapon(stances);
                    break;

                case "Staff":

                    stances = StanceList.STAFFSTANCES;

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