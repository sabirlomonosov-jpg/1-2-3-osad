using System;

class Startclass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Tere tulemast!");
        Console.Write("Sisesta eesnimi: ");
        string eesnimi = Console.ReadLine();
        Console.WriteLine("Tere, " + eesnimi);

        int arv1 = ReadInt("Sisesta esimene arv: ");
        int arv2 = ReadInt("Sisesta teine arv: ");
        Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);

        Console.WriteLine("Vajuta Enter, et lõpetada...");
        Console.ReadLine();
    }

    static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int value))
                return value;
            Console.WriteLine("Viga: sisesta kehtiv täisarv.");
        }
    }
}
