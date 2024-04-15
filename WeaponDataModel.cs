public class WeaponDataModel
{
    public int Impact { get; set; }
    public int Puncture { get; set; }
    public int Slash { get; set; }
    public int CritChance { get; set; }
    public int CritMultiplier { get; set; }
    public int Status { get; set; }
    public int StatusDuration { get; set; }

    public double BaseDamageBonus { get; set; }
    public double FactionMultiplier { get; set; }

    public WeaponDataModel()
    {
        // You can set default values here if needed
        // This constructor is optional
    }

    public double CalculateBaseDamage()
    {
        return Impact + Puncture + Slash;
    }

    public double CalculateModifiedBaseDamage()
    {
        return CalculateBaseDamage() * (1 + BaseDamageBonus) * (1 + FactionMultiplier);
    }
}
