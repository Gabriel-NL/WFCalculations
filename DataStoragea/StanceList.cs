namespace WFCalculations
{
    public struct Stance
    {
        public Dictionary<string, Combo> ComboDictionary;
    }

    public struct Combo
    {
        public StanceHit[] AllHits;
        public decimal ComboDuration;
    }

    public struct StanceHit
    {
        public decimal multiplier = 1;
        public bool procImpact,
            procPuncture,
            procBleeding,
            procExplosion,
            procKnockdown,
            procLifted,
            procStagger,
            procRagdoll,
            procFinisher = false;
        public bool spin,
            ranged,
            thrust,
            slam = false;
        public decimal slamDmgMultiplier,
            slamRadialDmgMultiplier = 1m;

        public StanceHit() { }

        public readonly decimal HitDmg(decimal base_dmg)
        {
            return base_dmg * multiplier;
        }

        public readonly double GetMultiplier()
        {
            return (double)multiplier;
        }
    }

    public static class StanceList
    {
        private const string NeutralCombo = "Neutral Combo";
        private const string ForwardCombo = "Forward Combo";
        private const string ForwardAndBlockCombo = "Forward And Block Combo";
        private const string BlockCombo = "Block Combo";

        public static Dictionary<string, Stance> DAGGER_STANCE_DICTIONARY = new Dictionary<
            string,
            Stance
        >()
        {
            {
                "Stanceless",
                new Stance()
                {
                    ComboDictionary = new Dictionary<string, Combo>()
                    {
                        {
                            NeutralCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0m, procBleeding = true },
                                ],
                                ComboDuration = 1,
                            }
                        },
                        {
                            ForwardCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0m, procBleeding = true },
                                ],
                                ComboDuration = 1,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0m, procBleeding = true },
                                ],
                                ComboDuration = 1,
                            }
                        },
                        {
                            BlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0m, procBleeding = true },
                                ],
                                ComboDuration = 1,
                            }
                        },
                    },
                }
            },
            {
                "Homing fang",
                new Stance()
                {
                    ComboDictionary = new Dictionary<string, Combo>()
                    {
                        {
                            NeutralCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0m, procImpact = true },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit(),
                                    new StanceHit()
                                    {
                                        multiplier = 4.0m,
                                        procBleeding = true,
                                        procKnockdown = true
                                    }
                                ],
                                ComboDuration = 2.8m,
                            }
                        },
                        {
                            ForwardCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit() { spin = true },
                                    new StanceHit() { spin = true }
                                ],
                                ComboDuration = 1.4m,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0m, procBleeding = true },
                                    new StanceHit() { spin = true },
                                    new StanceHit() { spin = true },
                                    new StanceHit() { spin = true },
                                    new StanceHit() { multiplier = 3.0m, procLifted = true }
                                ],
                                ComboDuration = 1.7m,
                            }
                        },
                        {
                            BlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0m, procBleeding = true },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0m, procImpact = true },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit(),
                                    new StanceHit()
                                    {
                                        multiplier = 4.0m,
                                        procBleeding = true,
                                        procKnockdown = true
                                    },
                                ],
                                ComboDuration = 2.8m,
                            }
                        }
                    },
                }
            },
            {
                "Stinging thorn",
                new Stance()
                {
                    ComboDictionary = new Dictionary<string, Combo>()
                    {
                        {
                            NeutralCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { procImpact = true },
                                    new StanceHit() { procBleeding = true },
                                    new StanceHit() { multiplier = 2.0m, procBleeding = true },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 2.0m, procBleeding = true },
                                    new StanceHit() { multiplier = 4.0m, procKnockdown = true }
                                ],
                                ComboDuration = 4.0m,
                            }
                        },
                        {
                            ForwardCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0m }
                                ],
                                ComboDuration = 1.8m,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 2.0m, procBleeding = true },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit()
                                    {
                                        multiplier = 1.0m,
                                        slam = true,
                                        procKnockdown = true
                                    },
                                ],
                                ComboDuration = 2.7m,
                            }
                        },
                        {
                            BlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 3.0m, procImpact = true },
                                    new StanceHit() { multiplier = 2.0m, procBleeding = true },
                                    new StanceHit() { multiplier = 4.0m, procRagdoll = true },
                                ],
                                ComboDuration = 2.4m,
                            }
                        },
                    },
                }
            },
            {
                "Pointed wind",
                new Stance()
                {
                    ComboDictionary = new Dictionary<string, Combo>()
                    {
                        {
                            NeutralCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { spin = true, procBleeding = true },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 3.0m, procImpact = true },
                                ],
                                ComboDuration = 1.6m,
                            }
                        },
                        {
                            ForwardCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 2.0m, spin = true },
                                    new StanceHit() { multiplier = 1.0m }
                                ],
                                ComboDuration = 1.2m,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 2.0m, spin = true },
                                    new StanceHit() { multiplier = 1.0m }
                                ],
                                ComboDuration = 1.2m,
                            }
                        },
                        {
                            BlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { spin = true, procBleeding = true },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 3.0m, procImpact = true },
                                ],
                                ComboDuration = 1.6m,
                            }
                        }
                    },
                }
            }
        };

        public static Dictionary<string, Stance> STAFF_STANCE_DICTIONARY = new Dictionary<
            string,
            Stance
        >()
        {
            {
                "Stanceless",
                new Stance()
                {
                    ComboDictionary = new Dictionary<string, Combo>()
                    {
                        {
                            NeutralCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit(),
                                ],
                                ComboDuration = 1,
                            }
                        },
                        {
                            ForwardCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit(),
                                ],
                                ComboDuration = 1,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit(),
                                ],
                                ComboDuration = 1,
                            }
                        },
                        {
                            BlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit(),
                                ],
                                ComboDuration = 1,
                            }
                        }
                    },
                }
            },
            {
                "Flailing Branch",
                new Stance()
                {
                    ComboDictionary = new Dictionary<string, Combo>()
                    {
                        {
                            NeutralCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 3.0m, procImpact = true },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 4.0m, procKnockdown = true },
                                ],
                                ComboDuration = 2.4m,
                            }
                        },
                        {
                            ForwardCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 4.0m },
                                ],
                                ComboDuration = 1.9m,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0m, procImpact = true },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 3.0m, procKnockdown = true },
                                    new StanceHit() { slam = true, procImpact = true },
                                ],
                                ComboDuration = 2.0m,
                            }
                        },
                        {
                            BlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 3.0m, procImpact = true },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 4.0m, procKnockdown = true },
                                ],
                                ComboDuration = 2.4m,
                            }
                        },
                    },
                }
            },
            {
                "Clashing Forest",
                new Stance()
                {
                    ComboDictionary = new Dictionary<string, Combo>()
                    {
                        {
                            NeutralCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { procLifted = true },
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 0.5m },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 4.0m, procKnockdown = true },
                                ],
                                ComboDuration = 1.9m,
                            }
                        },
                        {
                            ForwardCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0m },
                                ],
                                ComboDuration = 2.0m,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 3.0m, procRagdoll = true },
                                    new StanceHit() { multiplier = 3.0m, procRagdoll = true },
                                ],
                                ComboDuration = 2.1m,
                            }
                        },
                        {
                            BlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { procLifted = true },
                                    new StanceHit(),
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 0.5m },
                                    new StanceHit() { multiplier = 3.0m },
                                    new StanceHit() { multiplier = 2.0m },
                                    new StanceHit() { multiplier = 4.0m, procKnockdown = true },
                                ],
                                ComboDuration = 1.9m,
                            }
                        },
                    },
                }
            },
        };

        // You can define constants of various data types here
    }
}
