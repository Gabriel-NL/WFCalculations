namespace WFCalculations
{

    public static class ModList
    {
        public static readonly ModData[] modlist =
        [

            new ModData("Condition Overload")
            {
                Type = "Melee",
                Cost = 15,

                bonus = new ModBonus()
                {
                    BaseDmgPerStatus=0.8f
                },
            },
            new ModData("Primed Pressure Point")
            {
                Type = "Melee",

                Cost = 14,

                bonus = new ModBonus()
                {
                    BaseDmg = 1.65f
                },
            },
            new ModData("Spoiled Strike")
            {
                Type = "Melee",

                Cost = 7,

                bonus = new ModBonus()
                {
                    BaseDmg=1,
                    AttackSpeed=-0.2f
                },
            },
            new ModData("Auger Strike")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    PunctureDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Carnis Mandible")
            {
                Type = "Melee",

                Cost = 9,

                bonus = new ModBonus()
                {
                    SlashDmg=0.9f,
                    StatusChance=0.6f
                },
            },
            new ModData("Collision Force")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    ImpactDmg=1.2f,
                },
            },
            new ModData("Primed Heavy Trauma")
            {
                Type = "Melee",

                Cost = 12,

                bonus = new ModBonus()
                {
                    SlashDmg=1.65f,
                },
            },
            new ModData("Jagged Edge")
            {
                Type = "Melee",

                Cost = 7,

                bonus = new ModBonus()
                {
                    SlashDmg=0.9f,
                },
            },
            new ModData("Jugulus Barbs")
            {
                Type = "Melee",

                Cost = 9,

                bonus = new ModBonus()
                {
                    PunctureDmg=0.9f,
                    StatusChance=0.6f
                },
            },
            new ModData("Rending Strike")
            {
                Type = "Melee",

                Cost = 9,

                bonus = new ModBonus()
                {
                    SlashDmg=0.6f,
                    PunctureDmg=0.8f
                },
            },
            new ModData("Saxum Thorax")
            {
                Type = "Melee",

                Cost = 9,

                bonus = new ModBonus()
                {
                    ImpactDmg=0.9f,
                    StatusChance=0.6f
                },
            },
            new ModData("Sundering Strike")
            {
                Type = "Melee",

                Cost = 7,

                bonus = new ModBonus()
                {
                    PunctureDmg=0.9f,
                },
            },
            new ModData("Primed Fever Strike")
            {
                Type = "Melee",
                Cost = 16,
                bonus = new ModBonus()
                {
                    ToxinDmg=1.65f,
                },
            },
            new ModData("Focus Energy")
            {
                Type = "Melee",

                Cost = 9,

                bonus = new ModBonus()
                {
                    HeavyEfficiency=0.4f,
                    EletricityDmg=0.6f
                },
            },
            new ModData("Molten Impact")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    HeatDmg=0.9f
                },
            },
            new ModData("North Wind")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    ColdDmg=0.9f,
                },
            },
            new ModData("Proton Snap")
            {
                Type = "Melee",
                Condition="Wall Latch",
                Cost = 9,
                bonus = new ModBonus()
                {
                    ToxinDmg=1.0f,
                    AdditiveStatusChance=0.5f
                },
            },
            new ModData("Shocking Touch")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    EletricityDmg=0.9f,
                },
            },
            new ModData("Vicious Frost")
            {
                Type = "Melee",

                Cost = 7,

                bonus = new ModBonus()
                {
                    StatusChance=0.6f,
                    ColdDmg=0.6f
                },
            },
            new ModData("Virulent Scourge")
            {
                Type = "Melee",

                Cost = 7,

                bonus = new ModBonus()
                {
                    StatusChance=0.6f,
                    ToxinDmg=0.6f
                },
            },
            new ModData("Volcanic Edge")
            {
                Type = "Melee",

                Cost = 7,

                bonus = new ModBonus()
                {
                    StatusChance=0.6f,
                    HeatDmg=0.6f
                },
            },
            new ModData("Voltaic Strike")
            {
                Type = "Melee",

                Cost = 7,

                bonus = new ModBonus()
                {
                    StatusChance=0.6f,
                    EletricityDmg=0.6f
                },
            },
            new ModData("Sacrificial Pressure")
            {
                Type = "Melee",
                Cost = 16,
                Restriction="Pressure Point",
                bonus = new ModBonus()
                {
                    BaseDmg=1.1f,
                    FactionDmg=("Sentient",1.3f),
                },
            },
            new ModData("Sacrificial Steel")
            {
                Type = "Melee",
                Cost = 16,
                Restriction="True Steel",
                bonus = new ModBonus()
                {
                    CriticalChance=2.2f,
                    CriticalChanceForHeavyAttack=4.4f
                },
            },
            new ModData("Gladiator Might")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },
            new ModData("Buzz Kill")
            {
                Type = "Melee",

                Cost = 11,

                bonus = new ModBonus()
                {
                    SlashDmg=1.2f,
                },
            },


        ];
        // You can define constants of various data types here
    }

}