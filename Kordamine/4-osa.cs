using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Kordamine
{
    internal class _4_osa
    {
        public static void StreamWriter()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");

                if (!File.Exists(path))
                    File.WriteAllLines(path, new string[] { "Jaanuar", "Veebruar", "Märts", "Aprill", "Mai", "Juuni", "Juuli", "August", "September", "Oktoober", "November", "Detsember" });

                using var text = new StreamWriter(path, true, Encoding.UTF8);
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }

        public static void StreamReader()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                using var text = new StreamReader(path, Encoding.UTF8);
                string laused = text.ReadToEnd();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }

        public static void RidadeLugemine()
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");

                if (!File.Exists(path))
                    File.WriteAllLines(path, new string[] { "Jaanuar", "Veebruar", "Märts", "Aprill", "Mai", "Juuni", "Juuli", "August", "September", "Oktoober", "November", "Detsember" });

                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
                return;
            }

            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            kuude_list.Remove("Juuni");

            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine("--------------Kustutasime juuni-----------");

            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav = Console.ReadLine();

            if (!string.IsNullOrEmpty(otsitav))
            {
                if (kuude_list.Contains(otsitav))
                    Console.WriteLine("Kuu " + otsitav + " on olemas.");
                else
                    Console.WriteLine("Sellist kuud pole.");
            }
            else
            {
                Console.WriteLine("Otsitav nimi on tühi.");
            }

            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                File.WriteAllLines(path, kuude_list);
                Console.WriteLine("Andmed on salvestatud.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ei saanud salvestada faili.");
            }
        }

        
        public static void ShowMenu()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Menuu.txt");

            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new[]
                {
                    "Margherita pitsa;San Marzano tomatid, värske mozzarella, basiilik;8.50",
                    "Pasta Carbonara;Spagetid, guanciale, pecorino juust, muna;12.00",
                    "Tiramisu;Mascarpone, espresso, savoiardi küpsised;6.50"
                }, Encoding.UTF8);
            }

            var menyyList = new List<Tuple<string, string, double>>();

            string[] lines;
            try
            {
                lines = File.ReadAllLines(path, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Не удалось прочитать файл меню: " + ex.Message);
                return;
            }

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var osad = line.Split(';');
                if (osad.Length < 3) continue;

                string name = osad[0].Trim();
                string ingredients = osad[1].Trim();
                string priceText = osad[2].Trim();

                
                if (!double.TryParse(priceText, NumberStyles.Any, CultureInfo.InvariantCulture, out double price))
                {
                    if (!double.TryParse(priceText.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out price))
                    {
                        if (!double.TryParse(priceText, NumberStyles.Any, CultureInfo.CurrentCulture, out price))
                        {
                            
                            continue;
                        }
                    }
                }

                menyyList.Add(Tuple.Create(name, ingredients, price));
            }

            
            Console.WriteLine("--------- MENÜÜ ---------");
            foreach (var item in menyyList)
            {
                string name = item.Item1;
                string ingredients = item.Item2;
                double price = item.Item3;

                Console.WriteLine($"{name.PadRight(35)} {price.ToString("F2", CultureInfo.InvariantCulture)} €");
                Console.WriteLine($"    {ingredients}");
                Console.WriteLine();
            }
        }

        public static void RunMenu() => ShowMenu();

        
        public static void RunAll()
        {
            StreamWriter();
            StreamReader();
            RidadeLugemine();
                   
        }
    }
}
