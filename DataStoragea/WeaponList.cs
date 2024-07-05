namespace WFCalculations
{

    public static class WeaponList
    {

        public static WeaponDataModel RubicoPrime= new WeaponDataModel(){
            Name="Rubico Prime",
            Type="Rifle",
            SubType="Sniper",
            Trigger="Semi-Auto",
            Category="Primary",
            Series="Prime",
            DamageTypes=new Dictionary<string, decimal>(){
                {Constants.ImpactDmg, 149.6m},
                {Constants.PunctureDmg, 28.1m},
                {Constants.SlashDmg, 9.3m},
            },
            CritChance=38,
            CritMultiplier=3,
            StatusChance=16,
            AmmoMax=72,
            MagazineSize=5,
            FireRate=3.67m,
            RivenDisposition=0.65m,
            ReloadSpeed=2,
        };
            





        // You can define constants of various data types here
    }

}