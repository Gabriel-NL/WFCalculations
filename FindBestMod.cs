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

}