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
    public decimal RivenDisposition { get; set; }
    public string ReleaseDate { get; set; }
    public Dictionary<string, decimal> DamageTypes = new Dictionary<string, decimal>();
    public decimal CritChance,
        CritMultiplier,
        CritTier,
        StatusChance = 0;
    public decimal StatusDuration = 6;

    //Melee
    public decimal AtkSpeed,
        Reach = 1;

    //Gun
    public decimal ProjectileSpeed,
        FireRate,
        Multishot,
        Accuracy,
        AmmoMax,
        MagazineSize,
        ReloadSpeed = 1;

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

        DamageTypes = new Dictionary<string, decimal>(instance.DamageTypes); // Create a copy of the dictionary
        AtkSpeed = instance.AtkSpeed;
        Reach = instance.Reach;
        CritChance = instance.CritChance;
        CritMultiplier = instance.CritMultiplier;
        CritTier = instance.CritTier;
        StatusChance = instance.StatusChance;
        StatusDuration = instance.StatusDuration;
    }

    public decimal GetBaseDamage()
    {
        decimal totalDamage = DamageTypes.Sum(x => x.Value);
        return totalDamage;
    }

    public void GetAllDamages()
    {
        foreach (var dmg_type in DamageTypes)
        {
            Console.WriteLine($"{dmg_type.Key} = {dmg_type.Value}");
        }
    }

    public decimal GetQuantumBaseDmg(FactionWeakness enemy)
    {
        decimal Quantum = GetBaseDamage() / 16; //15.625
        decimal total_true_dmg = 0;

        // Perform the calculation, but if Quantum is 0, set the result to 0
        foreach (KeyValuePair<string, decimal> damage_type in DamageTypes)
        {
            //int Quantum_dmg = (kvp.Value != 0) ? (int)Math.Round(kvp.Value / Quantum) : 0;
            decimal Quantum_dmg = damage_type.Value / Quantum;
            decimal true_value = (int)Math.Round(Quantum_dmg) * Quantum;

            if (enemy.DmgMultipliers.ContainsKey(damage_type.Key))
            {
                decimal multiplier = enemy.DmgMultipliers[damage_type.Key];
                true_value *= multiplier;
            }
            total_true_dmg += true_value;
        }

        return (int)Math.Round(total_true_dmg);
    }

    public decimal CritAttack(decimal base_dmg, decimal tier)
    {
        decimal multiplier = CritMultiplier + ((CritMultiplier * tier) - 1 * tier);
        decimal crit_dmg = base_dmg * multiplier;
        return crit_dmg;
    }

    
}
