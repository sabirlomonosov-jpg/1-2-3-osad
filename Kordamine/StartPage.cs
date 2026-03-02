using Kordamine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string[] args)

        {

            string[] opilased = { "Sabir", "Damian", "Juri", "Artjom" };
            Osa3_funktsioonid.Õpilastega_mängimine(opilased);



            List<Inimene> Inimesed = new List<Inimene>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Mis on {i + 1}. inimese nimi?");
                string nimi = Console.ReadLine();
                Console.WriteLine($"Mis on {i + 1}. inimese vanus?");
                int vanus = int.Parse(Console.ReadLine());
                Inimene inimene = new Inimene(nimi, vanus);
                Inimesed.Add(inimene);
            }
            var analüüs = Osa3_funktsioonid.Statistika(Inimesed);
            Console.WriteLine($"Vanuste arv: {analüüs.Item1}");
            Console.WriteLine($"Vanuste keskmine: {analüüs.Item2}");
            Console.WriteLine($"Noorim inimene: {analüüs.Item3.Nimi} ({analüüs.Item3.Vanus} aastat vana)");
            Console.WriteLine($"Vanim inimene: {analüüs.Item4.Nimi} ({analüüs.Item4.Vanus} aastat vana)");


            double[] arvud1 = Osa1_funktsioonid.Täida_massiiv_double(new double[5]);
            var tulemus = Osa3_funktsioonid.AnalüüsiArve(arvud1);
            Console.WriteLine($"Summa: {tulemus.Item1}, Keskmine: {tulemus.Item2}, Korrutis: {tulemus.Item3}");

            var (summa, keskmine, korrutis) = Osa3_funktsioonid.AnalüüsiArve1(arvud1);
            Console.WriteLine($"Summa: {summa}, Keskmine: {keskmine}, Korrutis: {korrutis}");



            Console.WriteLine("3. Osa. Kordused ja Listid, massivid");
            Console.WriteLine("For:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Tere, {i + 1}!");
            }
            Console.WriteLine("While:");
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"Tere, {j + 1}!");
                j++;
            }
            Console.WriteLine("Do:");
            do
            {
                Console.WriteLine($"Tere, {11 - j}!");
                j--;
            }
            while (j != 0);
            int[] arvud = new int[5];
            Console.WriteLine("Täisarvude massiiv:");
            arvud = Osa1_funktsioonid.Täida_massiiv(arvud);
            Osa1_funktsioonid.Massiivide_kuvamine(arvud);


            Osa1_funktsioonid.Muuda_element_massiivis(arvud);

            List<Isik> inimesed = new List<Isik>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sisesta nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                Isik uusIsik = new Isik();
                uusIsik.Nimi = nimi;
                uusIsik.Vanus = vanus;

                inimesed.Add(uusIsik);
            }

            Console.WriteLine("\nKõik inimesed tervitavad:\n");

            foreach (Isik isik in inimesed)
            {
                isik.Tervita();
            }

        }



    }
}