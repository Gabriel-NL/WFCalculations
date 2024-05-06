public class WeaponDataModel
{
    //Display vars
    public string Name, Category, Series, Type, SubType = "";

    public Dictionary<string, string> Components;
    public string[] IsComponentFor { get; set; }
    public int MasteryRankRequirement { get; set; }
    public float RivenDisposition { get; set; }
    public string ReleaseDate { get; set; }

    //Pratical vars
    public float AtkSpeed, Reach = 1;
    public Dictionary<string, float> DamageTypes;
    public float CritChance, CritMultiplier, CritTier, StatusChance = 0;
    public float StatusDuration = 6;

    //Advanced vars




    public WeaponDataModel()
    {

    }

    public float BaseDamage()
    {
        float totalDamage = DamageTypes.Sum(x => x.Value);
        if (CritChance > 100)
        {
            CritTier = (int)(CritChance / 100f);
            CritChance %= 100f;
            totalDamage = CritAttack(totalDamage, CritTier - 1);
            return totalDamage;
        }
        else
        {
            return totalDamage;
        }

    }

    public float QuantumBaseDmg()
    {
        float Quantum = BaseDamage() / 16;
        float total_true_dmg = 0;

        // Perform the calculation, but if Quantum is 0, set the result to 0
        foreach (KeyValuePair<string, float> kvp in DamageTypes)
        {

            int Quantum_dmg = (kvp.Value != 0) ? (int)Math.Round(kvp.Value / Quantum) : 0;
            float true_value = Quantum_dmg * Quantum;
            total_true_dmg += true_value;
        }

        return total_true_dmg;
    }


    public float CritAttack(float base_dmg, float tier)
    {
        float multiplier = CritMultiplier + ((CritMultiplier * tier) - 1 * tier);
        float crit_dmg = base_dmg * multiplier;
        return crit_dmg;
    }
}
