using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlliedAircraftSystem.Aircraft.Systems;
namespace ConsoleCockpit
{
    class ConsoleArt
    {

        public static void DrawUI()
        {
            DrawCrosshair();
            DrawNavTable();
        }

        public static void DrawCrosshair()
        {
            Console.SetCursorPosition(37, 15);
            Console.Write("  ==  ");

            Console.SetCursorPosition(37, 16);
            Console.Write("  ==  ");
            
            Console.SetCursorPosition(37, 17);
            Console.Write("======");

            Console.SetCursorPosition(37, 18);
            Console.Write("======");
            
            Console.SetCursorPosition(37, 19);
            Console.Write("  ==  ");

            Console.SetCursorPosition(37, 20);
            Console.Write("  ==  ");
        }

        public static void DrawNavTable()
        {
            Console.SetCursorPosition(0, 26);
            Console.Write("==============================");
            Console.SetCursorPosition(0, 27);
            Console.Write("=          Nav Data          =");
            Console.SetCursorPosition(0, 28);
            Console.Write("=                            =");
            Console.SetCursorPosition(0, 29);
            Console.Write("= Alt:                       =");
            Console.SetCursorPosition(0, 30);
            Console.Write("= Brg:                       =");
            Console.SetCursorPosition(0, 31);
            Console.Write("= Vel:                       =");
            Console.SetCursorPosition(0, 32);
            Console.Write("= Pit:                       =");
            Console.SetCursorPosition(0, 33);
            Console.Write("= Lat:                       =");
            Console.SetCursorPosition(0, 34);
            Console.Write("= Lon:                       =");
            Console.SetCursorPosition(0, 35);
            Console.Write("==============================");
            
        }

        public static void PrintNavData(NavPackage navData)
        {
            string alt = navData.Alt.ToString().PadRight(21);
            string b = navData.B.ToString().PadRight(21);
            string v = navData.V.ToString().PadRight(21);
            string pitch = navData.Pitch.ToString().PadRight(21);
            string lat = navData.Lat.ToString().PadRight(21);
            string lon = navData.Lon.ToString().PadRight(21);

            Console.SetCursorPosition(7, 29);
            Console.Write(alt);
            Console.SetCursorPosition(7, 30);
            Console.Write(b);
            Console.SetCursorPosition(7, 31);
            Console.Write(v);
            Console.SetCursorPosition(7, 32);
            Console.Write(pitch);
            Console.SetCursorPosition(7, 33);
            Console.Write(lat);
            Console.SetCursorPosition(7, 34);
            Console.Write(lon);
        }
    }
}
