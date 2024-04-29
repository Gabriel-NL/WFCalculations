namespace WFCalculations
{

    public static class StanceList
    {


        public static readonly Stance[] DAGGERSTANCES = [
            new Stance("Stanceless")
            {
                AllCombos=[
                    new Combo("Neutral Combo"){
                        AllHits=[
                            new StanceHit(),
                            new StanceHit() { multiplier = 3.0f },
                            new StanceHit(),
                            new StanceHit() { multiplier = 2.0f, procBleeding = true },
                        ],
                        ComboDuration=1,
                    },
                    new Combo("Forward Combo"){
                        AllHits=[
                            new StanceHit(),
                            new StanceHit() { multiplier = 3.0f },
                            new StanceHit(),
                            new StanceHit() { multiplier = 2.0f, procBleeding = true },
                        ],
                        ComboDuration=1,
                    },
                    new Combo("Forward And Block Combo"){
                        AllHits=[
                            new StanceHit(),
                            new StanceHit() { multiplier = 3.0f },
                            new StanceHit(),
                            new StanceHit() { multiplier = 2.0f, procBleeding = true },
                        ],
                        ComboDuration=1,
                    },
                    new Combo("Block Combo"){
                        AllHits=[
                            new StanceHit(),
                            new StanceHit() { multiplier = 3.0f },
                            new StanceHit(),
                            new StanceHit() { multiplier = 2.0f, procBleeding = true },
                        ],
                        ComboDuration=1,
                    },

                ],

            },

            new Stance("Homing fang")
            {
                AllCombos=[
                    new Combo("Neutral Combo"){
                        AllHits=[
                            new StanceHit() { multiplier = 2.0f },
                            new StanceHit(),
                            new StanceHit() { multiplier = 3.0f ,procImpact=true},

                            new StanceHit() { multiplier = 3.0f},

                            new StanceHit() { multiplier = 3.0f},
                            new StanceHit(),
                            new StanceHit() { multiplier = 4.0f, procBleeding = true,procKnockdown= true }
                        ],
                        ComboDuration=2.8f,
                    },
                    new Combo("Forward Combo"){
                        AllHits=[
                            new StanceHit(),
                            new StanceHit(),

                            new StanceHit(){spin=true},
                            new StanceHit(){spin=true}
                        ],
                        ComboDuration=1.4f,
                    },
                    new Combo("Forward And Block Combo"){
                        AllHits=[
                            new StanceHit(){ multiplier = 2.0f ,procBleeding=true},

                            new StanceHit(){spin=true},
                            new StanceHit(){spin=true},
                            new StanceHit(){spin=true},

                            new StanceHit(){multiplier=3.0f,procLifted=true}
                        ],
                        ComboDuration=1.7f,
                    },
                    new Combo("Block Combo"){
                        AllHits=[
                            new StanceHit(){ multiplier = 2.0f ,procBleeding=true},
                            new StanceHit(),
                            new StanceHit(){ multiplier = 3.0f ,procImpact=true},

                            new StanceHit(){ multiplier = 3.0f},

                            new StanceHit(){ multiplier = 3.0f},
                            new StanceHit(),
                            new StanceHit(){ multiplier = 4.0f,procBleeding=true,procKnockdown=true},
                        ],
                        ComboDuration=2.8f,
                    },
                ],
            },

            new Stance("Stinging thorn")
            {

                AllCombos=[
                    new Combo("Neutral Combo"){
                        AllHits=[
                            new StanceHit() { multiplier = 3.0f },
                            new StanceHit() { procImpact=true},

                            new StanceHit() { procBleeding = true },
                            new StanceHit() { multiplier = 2.0f , procBleeding = true },
                            new StanceHit() { multiplier = 2.0f },

                            new StanceHit() { multiplier = 3.0f },
                            new StanceHit() { multiplier = 2.0f },

                            new StanceHit() { multiplier = 2.0f },
                            new StanceHit() { multiplier = 2.0f , procBleeding = true},

                            new StanceHit() { multiplier = 4.0f , procKnockdown = true}
                        ],
                        ComboDuration=4.0f,
                    },
                    new Combo("Forward Combo"){
                        AllHits=[
                            new StanceHit(),
                            new StanceHit() { multiplier = 2.0f },

                            new StanceHit() { multiplier = 2.0f },

                            new StanceHit(),
                            new StanceHit() { multiplier = 2.0f }
                        ],
                        ComboDuration=1.8f,
                    },
                    new Combo("Forward And Block Combo"){
                        AllHits=[
                            new StanceHit() { multiplier = 2.0f },

                            new StanceHit() { multiplier = 2.0f },
                            new StanceHit() { multiplier = 2.0f },
                            new StanceHit() { multiplier = 2.0f , procBleeding = true },

                            new StanceHit() { multiplier = 3.0f },
                            new StanceHit() { multiplier = 1.0f , slam = true, procKnockdown=true },
                        ],
                        ComboDuration= 2.7f,
                    },
                    new Combo("Block Combo"){
                        AllHits=[
                            new StanceHit(),
                            new StanceHit() { multiplier = 2.0f },
                            new StanceHit() { multiplier = 3.0f, procImpact=true },

                            new StanceHit() { multiplier = 2.0f,procBleeding=true },

                            new StanceHit() { multiplier = 4.0f,procRagdoll=true },
                        ],
                        ComboDuration=2.4f,
                    },
                ],


            },

            new Stance("Pointed wind")
            {
                AllCombos=[
                    new Combo("Neutral Combo"){
                        AllHits=[
                            new StanceHit() { multiplier = 2.0f },

                            new StanceHit(){spin=true,procBleeding=true},
                            new StanceHit() { multiplier = 3.0f },

                            new StanceHit() { multiplier = 3.0f },
                            new StanceHit() { multiplier = 3.0f,procImpact=true },
                        ],
                        ComboDuration=1.6f,
                    },
                    new Combo("Forward Combo"){
                        AllHits=[
                            new StanceHit(),

                            new StanceHit() { multiplier = 3.0f },

                            new StanceHit() { multiplier = 2.0f },

                            new StanceHit() { multiplier = 2.0f,spin=true },
                            new StanceHit() { multiplier = 1.0f }
                        ],
                        ComboDuration=1.2f,
                    },
                    new Combo("Forward And Block Combo"){
                        AllHits=[
                            new StanceHit(),

                            new StanceHit() { multiplier = 3.0f },

                            new StanceHit() { multiplier = 2.0f },

                            new StanceHit() { multiplier = 2.0f,spin=true },
                            new StanceHit() { multiplier = 1.0f }
                        ],
                        ComboDuration= 1.2f,
                    },
                    new Combo("Block Combo"){
                        AllHits=[
                            new StanceHit() { multiplier = 2.0f },

                            new StanceHit() { spin=true,procBleeding=true},
                            new StanceHit() { multiplier = 3.0f },

                            new StanceHit() { multiplier = 3.0f },
                            new StanceHit() { multiplier = 3.0f, procImpact=true },
                        ],
                        ComboDuration=1.6f,
                    },
                ],
            },

        ];
        public static readonly Stance[] STAFFSTANCES = [
            new Stance("Stanceless"){
                AllCombos=[
                    new Combo("Neutral Combo"){
                        AllHits=[

                            new StanceHit(),
                            new StanceHit(),
                            new StanceHit(),
                            new StanceHit(),
                        ],
                        ComboDuration=1,
                    },
                    new Combo("Forward Combo") {
                    AllHits = [
                        new StanceHit(),
                        new StanceHit(),
                        new StanceHit(),
                        new StanceHit(),
                        ],
                    ComboDuration = 1,
                    },
                    new Combo("Forward And Block Combo") {
                    AllHits = [
                        new StanceHit(),
                        new StanceHit(),
                        new StanceHit(),
                        new StanceHit(),
                        ],
                    ComboDuration = 1,
                    },
                    new Combo("Block Combo") {
                    AllHits = [
                        new StanceHit(),
                        new StanceHit(),
                        new StanceHit(),
                        new StanceHit(),
                        ],
                    ComboDuration = 1,
                    },
                ]
            },
            new Stance("Flailing Branch"){
                AllCombos=[
                    new Combo("Neutral Combo"){
                        AllHits=[

                            new StanceHit(){multiplier=3.0f,procImpact=true},
                            new StanceHit(){multiplier=2.0f},

                            new StanceHit(){multiplier=4.0f,procKnockdown=true},
                        ],
                        ComboDuration=2.4f,
                    },
                    new Combo("Forward Combo") {
                    AllHits = [
                        new StanceHit(),

                            new StanceHit(){multiplier=3.0f},

                            new StanceHit(){multiplier=2.0f},
                            new StanceHit(){multiplier=4.0f},
                        ],
                    ComboDuration = 1.9f,
                    },
                    new Combo("Forward And Block Combo") {
                    AllHits = [
                        new StanceHit(){multiplier=2.0f,procImpact=true},

                        new StanceHit(){multiplier=3.0f},
                        new StanceHit(){multiplier=3.0f,procKnockdown=true},
                        new StanceHit(){slam=true,procImpact=true},
                        ],
                    ComboDuration = 2.0f,
                    },
                    new Combo("Block Combo") {
                    AllHits = [
                        new StanceHit(){multiplier=3.0f,procImpact=true},
                        new StanceHit(){multiplier=2.0f},

                        new StanceHit(){multiplier=4.0f,procKnockdown=true},
                        ],
                    ComboDuration = 2.4f,
                    },
                ]
            },
            new Stance("Clashing Forest"){
                AllCombos=[
                    new Combo("Neutral Combo"){
                        AllHits=[
                            new StanceHit(),
                            new StanceHit(){procLifted=true},
                            new StanceHit(),
                            new StanceHit(),
                            new StanceHit(){multiplier=0.5f},

                            new StanceHit(){multiplier=3.0f},

                            new StanceHit(){multiplier=2.0f},
                            new StanceHit(){ multiplier=4.0f,procKnockdown=true},
                        ],
                        ComboDuration=1.9f,
                    },
                    new Combo("Forward Combo") {
                    AllHits = [
                            new StanceHit(),

                            new StanceHit(),

                            new StanceHit(),
                            new StanceHit(){multiplier=2.0f},
                        ],
                    ComboDuration = 2.0f,
                    },
                    new Combo("Forward And Block Combo") {
                    AllHits = [
                        new StanceHit(){multiplier=2.0f},
                        new StanceHit(){multiplier=2.0f},

                        new StanceHit(){multiplier=3.0f,procRagdoll=true},
                        new StanceHit(){multiplier=3.0f,procRagdoll=true},
                        ],
                    ComboDuration = 2.1f,
                    },
                    new Combo("Block Combo") {
                    AllHits = [
                        new StanceHit(),
                        new StanceHit(){procLifted=true},
                        new StanceHit(),
                        new StanceHit(),
                        new StanceHit(){multiplier=0.5f},

                        new StanceHit(){multiplier=3.0f},

                        new StanceHit(){multiplier=2.0f},
                        new StanceHit(){multiplier=4.0f,procKnockdown=true},
                        ],
                    ComboDuration = 1.9f,
                    },
                ]
            },
        ];

        // You can define constants of various data types here
    }

}