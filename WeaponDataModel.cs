public class WeaponDataModel
{
    //Theorical Details
    public required string Name { get; set; }
    public required string Category { get; set; }
    public required string Series { get; set; }
    public required string Type { get; set; }
    public required string SubType { get; set; }
    public required string[] IsComponentFor { get; set; }
    public required string MasteryRankRequirement { get; set; }
    public required string RivenDisposition { get; set; }
    public required string ReleaseDate { get; set; }

    //Pratical details
    public int Impact { get; set; }
    public int Puncture { get; set; }
    public int Slash { get; set; }
    public int CritChance { get; set; }
    public int CritMultiplier { get; set; }
    public int Status { get; set; }
    public int StatusDuration { get; set; }
    public double BaseDamageBonus { get; set; }
    public double FactionMultiplier { get; set; }

    //public WeaponDataModel(){   }

    public double CalculateBaseDamage()
    {
        return Impact + Puncture + Slash;
    }

    public double CalculateModifiedBaseDamage()
    {
        return CalculateBaseDamage() * (1 + BaseDamageBonus) * (1 + FactionMultiplier);
    }
}
