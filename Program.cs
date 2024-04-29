namespace WFCalculations
{
    using WFCalculations;
    using System;
    using System.Runtime.InteropServices;
    using System.Linq;


    public class Program  // Add the class name "Program"
    {
        static void Main(string[] args)
        {
            Console.Clear();

            ZawBuildClass BestZaw = new ZawBuildClass("Sample", "Sample", "Sample");


            var combinations = from strike in Constants.ALLZAWSTRIKES
                               from grip in Constants.ALLZAWGRIPS
                               from link in Constants.ALLZAWLINKS
                               select new { strike, grip, link };

            foreach (var combination in combinations)
            {
                // Access properties using dot notation
                Console.WriteLine($"Strike: {combination.strike}, Grip: {combination.grip}, Link: {combination.link}");
                ZawBuildClass zaw = new ZawBuildClass(combination.strike, combination.grip, combination.link);

                if ((zaw.GetFinalDmg() > BestZaw.GetFinalDmg()) || (zaw.GetFinalDmg() == 0))
                {
                    if (zaw.weapon_type == "Dagger")
                    {
                        BestZaw = zaw;

                    }
                }
            }
            BestZaw.ShowStats();
            StanceComboStorage stanceData = new StanceComboStorage(BestZaw.weapon_type);
            stanceData.CalculateStanceData(BestZaw.GetFinalDmg());



        }

    }
}