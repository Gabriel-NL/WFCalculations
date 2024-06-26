namespace WFCalculations
{

    public static class Constants
    {

        public static string SEPARATOR = string.Join("-", Enumerable.Repeat('-', 20));


        public const string VOID = "Void";

        public static readonly string[] ALLZAWSTRIKES = new string[]
        {"Balla","Cyath","Dehtat","Dokrahm","Kronsh","Mewan","Ooltha","Rabvee","Sepfahn","Plague Keewar","Plague Kripath"};
        public static readonly string[] ALLZAWGRIPS = new string[]
        {"Jayap","Korb","Kroostra","Kwath","Laka","Peye","Seekalla","Shtung","Plague Akwin","Plague Bokwin"};
        public static readonly string[] ALLZAWLINKS = new string[]
        {"Jai","Ruhang","Jai II","Ruhang II","Vargeet Jai","Vargeet Ruhang","Ekwana Jai","Ekwana Ruhang","Vargeet II Jai","Vargeet II Ruhang","Ekwana II Jai","Ekwana II Ruhang","Vargeet Jai II","Vargeet Ruhang II","Ekwana Jai II","Ekwana Ruhang II"};

        public static readonly string[] ALLWEAPONTYPES = new string[] { "Primary", "Secondary", "Melee" };
        public static readonly string[] ALLWEAPONSERIES = new string[]{
            "Incarnon","Kuva","Prime","Prisma","Tenet","Vandal","Wraith","Zaw"
        };

        // You can define constants of various data types here
    }

}