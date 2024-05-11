using WFCalculations;

public class WeaponDataModel
{
    //Display vars
    public string Name, Category, Series, Type, SubType = "";
    public Dictionary<string, string> Components = new Dictionary<string, string>();
    public string[] IsComponentFor = new string[3];
    public int MasteryRankRequirement { get; set; }
    public float RivenDisposition { get; set; }
    public string ReleaseDate { get; set; }


    public Dictionary<string, float> DamageTypes = new Dictionary<string, float>();
    public float AtkSpeed, Reach = 1;
    public float CritChance, CritMultiplier, CritTier, StatusChance = 0;
    public float StatusDuration = 6;





    public WeaponDataModel()
    {

    }
    public WeaponDataModel(WeaponDataModel instance)
    {
        Name = instance.Name;
        Category = instance.Category;
        Series = instance.Series;
        Type = instance.Type;
        SubType = instance.SubType;

        MasteryRankRequirement = instance.MasteryRankRequirement;
        RivenDisposition = instance.RivenDisposition;
        ReleaseDate = instance.ReleaseDate;
        Components = new Dictionary<string, string>(instance.Components); // Create a copy of the dictionary
        IsComponentFor = instance.IsComponentFor.ToArray(); // Create a new array from the existing array

        DamageTypes = new Dictionary<string, float>(instance.DamageTypes); // Create a copy of the dictionary
        AtkSpeed = instance.AtkSpeed;
        Reach = instance.Reach;
        CritChance = instance.CritChance;
        CritMultiplier = instance.CritMultiplier;
        CritTier = instance.CritTier;
        StatusChance = instance.StatusChance;
        StatusDuration = instance.StatusDuration;

    }

    public float GetBaseDamage()
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

    public void GetAllDamages()
    {
        foreach (var dmg_type in DamageTypes)
        {
            Console.WriteLine($"{dmg_type.Key} = {dmg_type.Value}");
        }
    }

    public float GetQuantumBaseDmg(EnemyData enemy)
    {
        float Quantum = GetBaseDamage() / 16; //15.625
        float total_true_dmg = 0;


        // Perform the calculation, but if Quantum is 0, set the result to 0
        foreach (KeyValuePair<string, float> kvp in DamageTypes)
        {
            //int Quantum_dmg = (kvp.Value != 0) ? (int)Math.Round(kvp.Value / Quantum) : 0;
            float Quantum_dmg = kvp.Value / Quantum;
            float true_value = (int)Math.Round(Quantum_dmg) * Quantum;

            if (enemy.health_type.DmgMultipliers.ContainsKey(kvp.Key))
            {

                float multiplier = enemy.health_type.DmgMultipliers[kvp.Key];
                true_value *= 1.25f;
            }
            total_true_dmg += true_value;
        }

        return (int)Math.Round(total_true_dmg);

    }


    public float CritAttack(float base_dmg, float tier)
    {
        float multiplier = CritMultiplier + ((CritMultiplier * tier) - 1 * tier);
        float crit_dmg = base_dmg * multiplier;
        return crit_dmg;
    }
}
