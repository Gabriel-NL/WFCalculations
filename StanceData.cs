namespace WFCalculations
{
    public class StanceData{


        public StanceData(){

        }

        
    }

    public class StanceHit{
        public float multiplier=1;
        public bool procImpact,procPuncture,procSlash,procExplosion,procKnockdown,procLifted,procStagger,procRagdoll,procFinisher=false;
        public bool spin,ranged,thrust=false
        public float slamDmgMultiplier,slamRadialDmgMultiplier=1f;
        
        public StanceHit(){

        }
    }
}