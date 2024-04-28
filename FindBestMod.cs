using System.Security.Cryptography.X509Certificates;

namespace WFCalculations
{
    public class FindBestMod
    {
        ModData[] modlist;

        public FindBestMod(ZawBuildClass weapon)
        {

        }

        public void InitializeModList()
        {
            modlist = [
            new ModData("Primed Pressure Point"){
                Type="Melee",
                SubType="None",
                Cost=14,
                Restriction="None",
                bonus= new ModBonus()
                {
                    BaseDmg=165
                },


             },

            ];



        }

    }

    public struct ModData
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Class { get; set; }
        public string Polarity { get; set; }
        public int Cost { get; set; }
        public string Restriction { get; set; }

        public ModBonus bonus { get; set; }
        public ModData(string name) : this()
        {
            this.Name = name;
        }

    }

    public struct ModBonus
    {
        //RawDamage Section
        public int BaseDmg { get; set; }
        public int BaseDmgPerStatus { get; set; }
        public int HeavyAttackDmg { get; set; }
        public int PunctureDmg { get; set; }
        public int ImpactDmg { get; set; }
        public int SlashDmg { get; set; }
        public int ToxinDmg { get; set; }
        public int EletricityDmg { get; set; }
        public int HeatDmg { get; set; }
        public int ColdDmg { get; set; }
        public int CorrosiveDmg { get; set; }
        public int GasDmg { get; set; }
        public int ViralDmg { get; set; }
        public int RadiationDmg { get; set; }
        public int MagneticDmg { get; set; }
        public int BlastDmg { get; set; }
        public (string Faction, int FactionDmg) FDmg { get; set; }

        //Critical Section
        public (bool IsHeavy, int CriticalChance) CritChance { get; set; }
        public float ExtraCriticalChance { get; set; }
        public float CriticalChancePerCombo { get; set; }
        public float CriticalMultiplier { get; set; }

        //Status Section
        public float StatusChance { get; set; }
        public float StatusChancePerCombo { get; set; }
        public float StatusDuration { get; set; }

        //Combo
        public int InitialCombo { get; set; }
        public int ComboDuration { get; set; }
        public int AddComboChance { get; set; }
        public int HeavyEfficiency { get; set; }


        //Others
        public int AttackSpeed { get; set; }
        public int Range { get; set; }
        public int PunchThrough { get; set; }
        public int ThrowDmg { get; set; }
        public int Bounce { get; set; }
        public int BlastRadius { get; set; }
        public bool ExplodeOnBounce { get; set; }



        public ModBonus()
        {

        }
    }
}