using WFCalculations;

public class WeaponDataModel
{
    //Display vars
    public string Name,
        Category,
        Series,
        Type,
        SubType,
        Trigger = "";
    public Dictionary<string, string> Components = new Dictionary<string, string>();
    public string[] IsComponentFor = new string[3];
    public int MasteryRankRequirement { get; set; }
    public float RivenDisposition { get; set; }
    public string ReleaseDate { get; set; }
    public Dictionary<string, float> DamageTypes = new Dictionary<string, float>();
    public float CritChance,
        CritMultiplier,
        CritTier,
        StatusChance = 0;
    public float StatusDuration = 6;

    //Melee
    public float AtkSpeed,
        Reach = 1;

    //Gun
    public float ProjectileSpeed,
        FireRate,
        Multishot=1,
        Accuracy,
        AmmoMax,
        MagazineSize,
        ReloadSpeed = 1,
        totalCritDMG;

    public WeaponDataModel() { }

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

        // Create a copy of the dictionary
        foreach (var dmg in instance.DamageTypes)
        {
            DamageTypes.Add(dmg.Key, dmg.Value);
        }

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
        float totalDamage = 0;
        foreach (var dmg in DamageTypes)
        {
            totalDamage += dmg.Value;
        }

        return (float)Math.Round(totalDamage, 3);
    }

    public void GetAllDamages()
    {
        foreach (var dmg_type in DamageTypes)
        {
            Console.WriteLine($"{dmg_type.Key} = {Math.Round(dmg_type.Value)}");
        }
    }

    public void SetTargetEffectiveness(FactionWeakness factionWeakness)
    {
        foreach (KeyValuePair<string, float> damage_type in DamageTypes)
        {
            if (factionWeakness.DmgMultipliers.ContainsKey(damage_type.Key))
            {
                DamageTypes[damage_type.Key] *= factionWeakness.DmgMultipliers[damage_type.Key];
            }
        }
    }

    public float GetQuantumDmg()
    {
        float Quantum = GetBaseDamage() / 16; //15.625
        float total_true_dmg = 0;

        // Perform the calculation, but if Quantum is 0, set the result to 0
        foreach (KeyValuePair<string, float> damage_type in DamageTypes)
        {
            //int Quantum_dmg = (kvp.Value != 0) ? (int)Math.Round(kvp.Value / Quantum) : 0;
            float Quantum_dmg = damage_type.Value / Quantum;
            float true_value = (int)Math.Round(Quantum_dmg) * Quantum;

            if (true)
            {
                
            }
            total_true_dmg += true_value;
        }

        if (CritChance > 100)
        {
            CritTier = (int)(CritChance / 100f);
            CritChance %= 100f;
            totalCritDMG=(int)Math.Round(CritAttack(total_true_dmg, CritTier));

            total_true_dmg = CritAttack(total_true_dmg, CritTier - 1);
        }
        total_true_dmg = (int)Math.Round(total_true_dmg);
        return total_true_dmg;
    }

    public float CritAttack(float base_dmg, float tier)
    {
        float multiplier = CritMultiplier + ((CritMultiplier * tier) - 1 * tier);
        float crit_dmg = base_dmg * multiplier;
        return crit_dmg;
    }
}
