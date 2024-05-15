namespace WFCalculations
{

    public static class WeaponList
    {

        public static WeaponDataModel RubicoPrime= new WeaponDataModel(){
            Name="Rubico Prime",
            Type="Sniper Rifle",
            SubType="Semi-Auto",
            Category="Primary",
            Series="Prime",
            DamageTypes=new Dictionary<string, float>(){
                {ModList.ImpactDmg, 149.6f},
                {ModList.PunctureDmg, 28.1f},
                {ModList.SlashDmg, 9.3f},
            },
            CritChance=38,
            CritMultiplier=3,
            StatusChance=16,
            AmmoMax=72,
            MagazineSize=5,
            FireRate=3.67f,
            RivenDisposition=0.65f,
            ReloadSpeed=2,
        };




        // You can define constants of various data types here
    }

}