namespace WFCalculations
{
    public class StanceComboStorage
    {

        public string weapon_type;
        public Stance[] stances;


        public StanceComboStorage(string weapon_type)
        {
            this.weapon_type = weapon_type;
        }

        public void CalculateStanceData(double base_dmg)
        {
            switch (weapon_type)
            {
                case "Dagger":

                    stances = [
                        new Stance("Stanceless")
                        {
                        neutralCombo =
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 2.0f, procBleeding = true },
                            ],
                        neutralComboDuration = 1,

                        forwardCombo =
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 2.0f, procBleeding = true },
                            ],
                        forwardComboDuration = 1,

                        forwardAndBlockCombo =
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 2.0f, procBleeding = true }
                            ],
                        forwardAndBlockComboDuration = 1
                        },

                        new Stance("Homing fang")
                        {
                        neutralCombo =
                            [
                            new StanceHit(base_dmg) { multiplier = 2.0f },
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 3.0f ,procImpact=true},

                            new StanceHit(base_dmg) { multiplier = 3.0f},

                            new StanceHit(base_dmg) { multiplier = 3.0f},
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 4.0f, procBleeding = true,procKnockdown= true }
                            ],
                        neutralComboDuration = 2.8,

                        forwardCombo =
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),

                            new StanceHit(base_dmg){spin=true},
                            new StanceHit(base_dmg){spin=true}
                            ],
                        forwardComboDuration = 1.4,

                        forwardAndBlockCombo =
                            [
                            new StanceHit(base_dmg){ multiplier = 2.0f ,procBleeding=true},

                            new StanceHit(base_dmg){spin=true},
                            new StanceHit(base_dmg){spin=true},
                            new StanceHit(base_dmg){spin=true},

                            new StanceHit(base_dmg){multiplier=3.0f,procLifted=true}

                            ],
                        forwardAndBlockComboDuration = 1.7,

                        blockCombo =
                            [
                            new StanceHit(base_dmg){ multiplier = 2.0f ,procBleeding=true},
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg){ multiplier = 3.0f ,procImpact=true},

                            new StanceHit(base_dmg){ multiplier = 3.0f},

                            new StanceHit(base_dmg){ multiplier = 3.0f},
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg){ multiplier = 4.0f,procBleeding=true,procKnockdown=true},

                            ],
                        blockComboDuration = 2.8
                        },

                        new Stance("Stinging thorn")
                        {
                        neutralCombo =
                            [
                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg) { procImpact=true},

                            new StanceHit(base_dmg) { procBleeding = true },
                            new StanceHit(base_dmg) { multiplier = 2.0f , procBleeding = true },
                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f },
                            new StanceHit(base_dmg) { multiplier = 2.0f , procBleeding = true},

                            new StanceHit(base_dmg) { multiplier = 4.0f , procKnockdown = true}

                            ],
                        neutralComboDuration = 4.0,

                        forwardCombo =
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 2.0f }
                            ],
                        forwardComboDuration = 1.8,

                        forwardAndBlockCombo =
                            [
                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f },
                            new StanceHit(base_dmg) { multiplier = 2.0f },
                            new StanceHit(base_dmg) { multiplier = 2.0f , procBleeding = true },

                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg) { multiplier = 1.0f , slam = true, procKnockdown=true },
                            ],
                        forwardAndBlockComboDuration = 2.7,

                        blockCombo =
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 2.0f },
                            new StanceHit(base_dmg) { multiplier = 3.0f, procImpact=true },

                            new StanceHit(base_dmg) { multiplier = 2.0f,procBleeding=true },

                            new StanceHit(base_dmg) { multiplier = 4.0f,procRagdoll=true },
                            ],
                        blockComboDuration = 2.4

                        },

                        new Stance("Pointed wind")
                        {
                        neutralCombo =
                            [
                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg){spin=true,procBleeding=true},
                            new StanceHit(base_dmg) { multiplier = 3.0f },

                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg) { multiplier = 3.0f,procImpact=true },

                            ],
                        neutralComboDuration = 1.6,

                        forwardCombo =
                            [
                            new StanceHit(base_dmg),

                            new StanceHit(base_dmg) { multiplier = 3.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f,spin=true },
                            new StanceHit(base_dmg) { multiplier = 1.0f }
                            ],
                        forwardComboDuration = 1.2,

                        forwardAndBlockCombo =
                            [
                            new StanceHit(base_dmg),

                            new StanceHit(base_dmg) { multiplier = 3.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f,spin=true },
                            new StanceHit(base_dmg) { multiplier = 1.0f }
                            ],
                        forwardAndBlockComboDuration = 1.2,

                        blockCombo =
                            [
                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg) { spin=true,procBleeding=true},
                            new StanceHit(base_dmg) { multiplier = 3.0f },

                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg) { multiplier = 3.0f, procImpact=true },


                            ],
                        blockComboDuration = 1.6

                        },

                    ];
                    ShowStanceData(stances);
                    break;

                case "Staff":
                    stances = [
                        new Stance("Stanceless")
                        {
                            neutralCombo=
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),
                            ],
                            neutralComboDuration=1,

                            forwardCombo=
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),
                            ],
                            forwardComboDuration=1,

                            forwardAndBlockCombo=
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),
                            ],
                            forwardAndBlockComboDuration=1,

                        },

                        new Stance("Flailing Branch")
                        {
                            neutralCombo=
                            [
                            new StanceHit(base_dmg){multiplier=3.0f,procImpact=true},
                            new StanceHit(base_dmg){multiplier=2.0f},

                            new StanceHit(base_dmg){multiplier=4.0f,procKnockdown=true},
                            ],
                            neutralComboDuration=2.4,

                            forwardCombo=
                            [
                            new StanceHit(base_dmg),

                            new StanceHit(base_dmg){multiplier=3.0f},

                            new StanceHit(base_dmg){multiplier=2.0f},
                            new StanceHit(base_dmg){multiplier=4.0f},
                            ],
                            forwardComboDuration=1.9,

                            forwardAndBlockCombo=
                            [
                            new StanceHit(base_dmg){multiplier=2.0f,procImpact=true},

                            new StanceHit(base_dmg){multiplier=3.0f},
                            new StanceHit(base_dmg){multiplier=3.0f,procKnockdown=true},
                            new StanceHit(base_dmg){slam=true,procImpact=true},
                            ],
                            forwardAndBlockComboDuration=2.0,

                            blockCombo=
                            [
                            new StanceHit(base_dmg){multiplier=3.0f,procImpact=true},
                            new StanceHit(base_dmg){multiplier=2.0f},

                            new StanceHit(base_dmg){multiplier=4.0f,procKnockdown=true},
                            ],
                            blockComboDuration=2.4,
                        },

                        new Stance("Clashing Forest")
                        {
                            neutralCombo=
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg){procLifted=true},
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg){multiplier=0.5f},

                            new StanceHit(base_dmg){multiplier=3.0f},

                            new StanceHit(base_dmg){multiplier=2.0f},
                            new StanceHit(base_dmg){ multiplier=4.0f,procKnockdown=true},
                            ],
                            neutralComboDuration=1.9,

                            forwardCombo=
                            [
                            new StanceHit(base_dmg),

                            new StanceHit(base_dmg),

                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg){multiplier=2.0f},
                            ],
                            forwardComboDuration=2.0,

                            forwardAndBlockCombo=
                            [
                            new StanceHit(base_dmg){multiplier=2.0f},
                            new StanceHit(base_dmg){multiplier=2.0f},

                            new StanceHit(base_dmg){multiplier=3.0f,procRagdoll=true},
                            new StanceHit(base_dmg){multiplier=3.0f,procRagdoll=true},
                            ],
                            forwardAndBlockComboDuration=2.1,

                            blockCombo=
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg){procLifted=true},
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg){multiplier=0.5f},

                            new StanceHit(base_dmg){multiplier=3.0f},

                            new StanceHit(base_dmg){multiplier=2.0f},
                            new StanceHit(base_dmg){multiplier=4.0f,procKnockdown=true},

                            ],
                            blockComboDuration=1.9,
                        },
                    ];
                    ShowStanceData(stances);
                    break;
                case "Machete":
                    break;
                case "Polearm":
                    break;
                case "Rapier":
                    break;
                case "Scythe":
                    break;
                case "Heavy Blade":
                    break;
                case "Sword":
                    break;
                case "Hammer":
                    break;
                case "Nikana":
                    break;

                default:
                    throw new ArgumentException("Weapon name not valid");

            }

        }

        public void ShowStanceData(Stance[] stances)
        {
            Console.WriteLine($"The damage values for {weapon_type} are:");


            Console.WriteLine(Constants.SEPARATOR);
            foreach (Stance stance in stances)
            {
                Console.WriteLine($"Combo: {stance.stance_name}");
                Console.WriteLine($"Neutral combo causes {CalculateDmg(stance.neutralCombo)} damage with {stance.neutralCombo.Length} hits");
                Console.WriteLine($"Forward combo causes {CalculateDmg(stance.forwardCombo)} damage with {stance.forwardCombo.Length} hits");
                Console.WriteLine($"Forward and Block combo causes {CalculateDmg(stance.forwardAndBlockCombo)} damage with {stance.forwardAndBlockCombo.Length} hits");
                if (stance.blockCombo is not null)
                {
                    Console.WriteLine($"Block combo causes {CalculateDmg(stance.blockCombo)} damage with {stance.blockCombo.Length} hits");
                }
                Console.WriteLine(Constants.SEPARATOR);


            }

        }

        public double CalculateDmg(StanceHit[] combo)
        {
            double total_dmg = 0;
            foreach (StanceHit hit in combo)
            {
                total_dmg += hit.HitDmg();
            }
            return total_dmg;
        }



    }

    public struct Stance
    {

        public string stance_name { get; set; }
        public StanceHit[] neutralCombo { get; set; }
        public double neutralComboDuration { get; set; }
        public StanceHit[] forwardCombo { get; set; }
        public double forwardComboDuration { get; set; }
        public StanceHit[] forwardAndBlockCombo { get; set; }
        public double forwardAndBlockComboDuration { get; set; }
        public StanceHit[] blockCombo { get; set; }
        public double blockComboDuration { get; set; }




        public Stance(string stance_name)
        {
            this.stance_name = stance_name;
        }

    }


    public struct StanceHit
    {

        public double base_dmg { get; set; } = 0;
        public float multiplier { get; set; } = 1;
        public bool procImpact, procPuncture, procBleeding, procExplosion, procKnockdown, procLifted, procStagger, procRagdoll, procFinisher = false;
        public bool spin, ranged, thrust, slam = false;

        public float slamDmgMultiplier, slamRadialDmgMultiplier = 1f;

        public StanceHit(double baseDamage)
        {
            base_dmg = baseDamage;
        }
        public double HitDmg()
        {
            return base_dmg * multiplier;
        }
    }
}