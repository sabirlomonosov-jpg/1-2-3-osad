using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Kordamine
{
    public class StartPageOsa4
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Osa 4: Failitöötlus ===");
                Console.WriteLine("1 - Faili kirjutamine (StreamWriter)");
                Console.WriteLine("2 - Faili lugemine (StreamReader)");
                Console.WriteLine("3 - Ridade lugemine ja töötlemine (List<string>)");
                Console.WriteLine("4 - Käivita kõik (RunAll)");
                Console.WriteLine("5 - Itaalia toit");
                Console.WriteLine("0 - Välju");
                Console.Write("Valik: ");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        _4_osa.StreamWriter();
                        break;
                    case "2":
                        _4_osa.StreamReader();
                        break;
                    case "3":
                        _4_osa.RidadeLugemine();
                        break;
                    case "4":
                        _4_osa.RunAll();
                        break;
                    case "5":
                        _4_osa.ItaaliaToit();
                        break;
                    case "0":
                        Console.WriteLine("Väljun...");
                        return;
                    default:
                        Console.WriteLine("Tundmatu valik. Proovi uuesti.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Vajuta Enter, et naasta menüüsse...");
                Console.ReadLine();
            }
        }
    }
}
