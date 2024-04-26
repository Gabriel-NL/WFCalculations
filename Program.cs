namespace WFCalculations
{
    using WFCalculations;
    using System;
    using System.Runtime.InteropServices;


    public class Program  // Add the class name "Program"
    {
        static void Main(string[] args)
        {
            Console.Clear();

            ZawBuildClass BestZaw = new ZawBuildClass("Sample", "Sample", "Sample");


            foreach (var strike in PossibleStrikes())
            {
                foreach (var grip in PossibleGrips())
                {
                    foreach (var link in PossibleLinks())
                    {

                        ZawBuildClass zaw = new ZawBuildClass(strike, grip, link);

                        if ((zaw.GetFinalDmg() > BestZaw.GetFinalDmg()) || (zaw.GetFinalDmg() == 0))
                        {
                            if (zaw.weapon_type == "Dagger")
                            {
                                BestZaw = zaw;

                            }

                        }

                    }
                }
            }
            BestZaw.ShowAdvancedStats();
            StanceData stanceData = new StanceData(BestZaw.GetFinalDmg(), BestZaw.weapon_type, "Stanceless");
            Console.WriteLine($"This zaw in full combo causes {stanceData.StanceDamage()} damage");


        }
        public static List<string> PossibleStrikes()
        {
            // Strike list
            List<string> strikes = new List<string>
        {
        "Balla",
        "Cyath",
        "Dehtat",
        "Dokrahm",
        "Kronsh",
        "Mewan",
        "Ooltha",
        "Rabvee",
        "Sepfahn",
        "Plague Keewar",
        "Plague Kripath"
        };
            return strikes;
        }
        public static List<string> PossibleGrips()
        {

            List<string> grips = new List<string>
        {
        "Jayap",
        "Korb",
        "Kroostra",
        "Kwath",
        "Laka",
        "Peye",
        "Seekalla",
        "Shtung",
        "Plague Akwin",
        "Plague Bokwin"
        };
            return grips;
        }
        public static List<string> PossibleLinks()
        {
            // Link list
            List<string> links = new List<string>
        {
        "Jai",
        "Ruhang",
        "Jai II",
        "Ruhang II",
        "Vargeet Jai",
        "Vargeet Ruhang",
        "Ekwana Jai",
        "Ekwana Ruhang",
        "Vargeet II Jai",
        "Vargeet II Ruhang",
        "Ekwana II Jai",
        "Ekwana II Ruhang",
        "Vargeet Jai II",
        "Vargeet Ruhang II",
        "Ekwana Jai II",
        "Ekwana Ruhang II"
        };
            return links;
        }
    }
}