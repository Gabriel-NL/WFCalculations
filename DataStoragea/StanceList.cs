namespace WFCalculations
{
    public struct Stance
    {
        public Dictionary<string, Combo> ComboDictionary;
    }

    public struct Combo
    {
        public StanceHit[] AllHits;
        public float ComboDuration;
    }

    public struct StanceHit
    {
        public float multiplier = 1;
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
        public float slamDmgMultiplier,
            slamRadialDmgMultiplier = 1f;

        public StanceHit() { }

        public readonly float HitDmg(float base_dmg)
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
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0f, procBleeding = true },
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
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0f, procBleeding = true },
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
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0f, procBleeding = true },
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
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0f, procBleeding = true },
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
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0f, procImpact = true },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit(),
                                    new StanceHit()
                                    {
                                        multiplier = 4.0f,
                                        procBleeding = true,
                                        procKnockdown = true
                                    }
                                ],
                                ComboDuration = 2.8f,
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
                                ComboDuration = 1.4f,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0f, procBleeding = true },
                                    new StanceHit() { spin = true },
                                    new StanceHit() { spin = true },
                                    new StanceHit() { spin = true },
                                    new StanceHit() { multiplier = 3.0f, procLifted = true }
                                ],
                                ComboDuration = 1.7f,
                            }
                        },
                        {
                            BlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0f, procBleeding = true },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0f, procImpact = true },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit(),
                                    new StanceHit()
                                    {
                                        multiplier = 4.0f,
                                        procBleeding = true,
                                        procKnockdown = true
                                    },
                                ],
                                ComboDuration = 2.8f,
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
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { procImpact = true },
                                    new StanceHit() { procBleeding = true },
                                    new StanceHit() { multiplier = 2.0f, procBleeding = true },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 2.0f, procBleeding = true },
                                    new StanceHit() { multiplier = 4.0f, procKnockdown = true }
                                ],
                                ComboDuration = 4.0f,
                            }
                        },
                        {
                            ForwardCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0f }
                                ],
                                ComboDuration = 1.8f,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 2.0f, procBleeding = true },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit()
                                    {
                                        multiplier = 1.0f,
                                        slam = true,
                                        procKnockdown = true
                                    },
                                ],
                                ComboDuration = 2.7f,
                            }
                        },
                        {
                            BlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 3.0f, procImpact = true },
                                    new StanceHit() { multiplier = 2.0f, procBleeding = true },
                                    new StanceHit() { multiplier = 4.0f, procRagdoll = true },
                                ],
                                ComboDuration = 2.4f,
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
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { spin = true, procBleeding = true },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 3.0f, procImpact = true },
                                ],
                                ComboDuration = 1.6f,
                            }
                        },
                        {
                            ForwardCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 2.0f, spin = true },
                                    new StanceHit() { multiplier = 1.0f }
                                ],
                                ComboDuration = 1.2f,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 2.0f, spin = true },
                                    new StanceHit() { multiplier = 1.0f }
                                ],
                                ComboDuration = 1.2f,
                            }
                        },
                        {
                            BlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { spin = true, procBleeding = true },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 3.0f, procImpact = true },
                                ],
                                ComboDuration = 1.6f,
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
                                    new StanceHit() { multiplier = 3.0f, procImpact = true },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 4.0f, procKnockdown = true },
                                ],
                                ComboDuration = 2.4f,
                            }
                        },
                        {
                            ForwardCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit(),
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 4.0f },
                                ],
                                ComboDuration = 1.9f,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0f, procImpact = true },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 3.0f, procKnockdown = true },
                                    new StanceHit() { slam = true, procImpact = true },
                                ],
                                ComboDuration = 2.0f,
                            }
                        },
                        {
                            BlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 3.0f, procImpact = true },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 4.0f, procKnockdown = true },
                                ],
                                ComboDuration = 2.4f,
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
                                    new StanceHit() { multiplier = 0.5f },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 4.0f, procKnockdown = true },
                                ],
                                ComboDuration = 1.9f,
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
                                    new StanceHit() { multiplier = 2.0f },
                                ],
                                ComboDuration = 2.0f,
                            }
                        },
                        {
                            ForwardAndBlockCombo,
                            new Combo()
                            {
                                AllHits =
                                [
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 3.0f, procRagdoll = true },
                                    new StanceHit() { multiplier = 3.0f, procRagdoll = true },
                                ],
                                ComboDuration = 2.1f,
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
                                    new StanceHit() { multiplier = 0.5f },
                                    new StanceHit() { multiplier = 3.0f },
                                    new StanceHit() { multiplier = 2.0f },
                                    new StanceHit() { multiplier = 4.0f, procKnockdown = true },
                                ],
                                ComboDuration = 1.9f,
                            }
                        },
                    },
                }
            },
        };

        // You can define constants of various data types here
    }
}
