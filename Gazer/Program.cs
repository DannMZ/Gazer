namespace Gazer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class gazer
    {
        List<building> buildings=new List<building>();
        public gazer() { }
        public void add_if_not_exist(building b){if (buildings.Contains(b)) { buildings.Remove(b); }else buildings.Add(b);}
        public void build() { 
            for(int o = 0; o < buildings.Count; o++)
            {
               buildings[o].build();
            }
        }
    }
    public class building
    {
        string name;
        public string whts_up() { if (builded != 0) return name + " було побудовано на " + builded + " га"; else return "Все ще нічого немає"; }
        public int builded { get; private set; }
        public building(string n ) { name = n;}
        public void build() { builded++; }
    }
}