using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlliedAircraftSystem.Aircraft;
using AlliedAircraftSystem.Aircraft.Specs;

namespace ConsoleCockpit
{
    class Cockpit
    {
        static F16 f16;
        static uint interval = 100;
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 36);
            ConsoleArt.DrawUI();
            Go();
            Console.Read();
            
        }

        public static void Go()
        {
            f16 = new F16();
            ConsoleArt.PrintNavData(f16.Nav);
            System.Timers.Timer t = new System.Timers.Timer(interval);
            t.Elapsed += T_Elapsed;
            t.Start();
        }

        private static void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            f16.InternalSync(interval);
            ConsoleArt.PrintNavData(f16.Nav);
        }
    }
}
