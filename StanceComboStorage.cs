namespace WFCalculations
{
    public class StanceComboStorage
    {

        public string weapon_type;


        public StanceComboStorage(double base_dmg, string weapon_type)
        {
            this.weapon_type = weapon_type;
            switch (weapon_type)
            {
                case "Dagger":
                    Stance stanceless = new Stance("Stanceless")
                    {
                        neutral =
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 2.0f, procBleeding = true },
                            ],
                        neutralDuration = 1,

                        forward =
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 2.0f, procBleeding = true },
                            ],
                        forwardDuration = 1,

                        forwardBlock =
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 2.0f, procBleeding = true }
                            ],
                        forwardBlockDuration = 1
                    };

                    Stance homing_fang = new Stance("homing_fang")
                    {
                        neutral =
                            [
                            new StanceHit(base_dmg) { multiplier = 2.0f },
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 3.0f ,procImpact=true},

                            new StanceHit(base_dmg) { multiplier = 3.0f},

                            new StanceHit(base_dmg) { multiplier = 3.0f},
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 4.0f, procBleeding = true,procKnockdown= true }
                            ],
                        neutralDuration = 2.8,

                        forward =
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg),

                            new StanceHit(base_dmg){spin=true},
                            new StanceHit(base_dmg){spin=true}
                            ],
                        forwardDuration = 1.4,

                        forwardBlock =
                            [
                            new StanceHit(base_dmg){ multiplier = 2.0f ,procBleeding=true},

                            new StanceHit(base_dmg){spin=true},
                            new StanceHit(base_dmg){spin=true},
                            new StanceHit(base_dmg){spin=true},

                            new StanceHit(base_dmg){multiplier=3.0f,procLifted=true}

                            ],
                        forwardBlockDuration = 1.7
                    };
                    Stance stinging_thorn = new Stance("stinging_thorn")
                    {
                        neutral =
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
                        neutralDuration = 4.0,

                        forward =
                            [
                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg),
                            new StanceHit(base_dmg) { multiplier = 2.0f }
                            ],
                        forwardDuration = 1.8,

                        forwardBlock =
                            [
                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f },
                            new StanceHit(base_dmg) { multiplier = 2.0f },
                            new StanceHit(base_dmg) { multiplier = 2.0f , procBleeding = true },

                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg) { multiplier = 1.0f , slam = true, procKnockdown=true },
                            ],
                        forwardBlockDuration = 2.7

                    };
                    Stance pointed_wind = new Stance("pointed_wind")
                    {
                        neutral =
                            [
                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg){spin=true,procBleeding=true},
                            new StanceHit(base_dmg) { multiplier = 3.0f },

                            new StanceHit(base_dmg) { multiplier = 3.0f },
                            new StanceHit(base_dmg) { multiplier = 3.0f,procImpact=true },

                            ],
                        neutralDuration = 1.6,

                        forward =
                            [
                            new StanceHit(base_dmg),

                            new StanceHit(base_dmg) { multiplier = 3.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f,spin=true },
                            new StanceHit(base_dmg) { multiplier = 1.0f }
                            ],
                        forwardDuration = 1.2,

                        forwardBlock =
                            [
                            new StanceHit(base_dmg),

                            new StanceHit(base_dmg) { multiplier = 3.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f },

                            new StanceHit(base_dmg) { multiplier = 2.0f,spin=true },
                            new StanceHit(base_dmg) { multiplier = 1.0f }
                            ],
                        forwardBlockDuration = 1.2

                    };

                    break;
                default:
                    throw new ArgumentException("Weapon name not valid");

            }
        }

        public void ShowStanceData(string stance_name, List<StanceHit> stance_damage_values)
        {
            double total_dmg = 0;
            foreach (StanceHit hit in stance_damage_values)
            {
                total_dmg += hit.HitDmg();
            }

            Console.WriteLine($"The given {weapon_type} with the stance {stance_name} have the following information");
            Console.WriteLine($"Number of hits: {stance_damage_values.Count()}");
            Console.WriteLine($"Total damage: {total_dmg}");
        }



    }

    public struct Stance
    {

        public string stance_name { get; set; }
        public StanceHit[] neutral { get; set; }
        public double neutralDuration { get; set; }
        public StanceHit[] forward { get; set; }
        public double forwardDuration { get; set; }
        public StanceHit[] forwardBlock { get; set; }
        public double forwardBlockDuration { get; set; }


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