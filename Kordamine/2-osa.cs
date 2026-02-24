//1
Console.WriteLine("Tere tulemast!");
Console.Write("Sisesta eesnimi: ");
string eesnimi = Console.ReadLine();
Console.WriteLine("Tere, " + eesnimi);

if (eesnimi.ToLower() == "juku")
{
    Console.WriteLine("Lähme kinno!");
    Console.Write("Kui vana sa oled: ");
    int vanus = int.Parse(Console.ReadLine());
    if (vanus < 6)
    {
        Console.WriteLine("Pilet on tasuta!");
    }
    else if (vanus > 5 && vanus < 15)
    {
        Console.WriteLine("Peate ostma lastepileti.");
    }
    else if (vanus > 14 && vanus < 66)
    {
        Console.WriteLine("Peate ostma täispileti.");
    }
    else if (vanus > 65)
    {
        Console.WriteLine("Peate ostma sooduspileti");
    }
    else if (vanus < 0 && vanus > 100)
    {
        Console.WriteLine("Viga: sisesta kehtiv vanus.");
    }
    
}
    else
    {
        Console.WriteLine("Täna mind kodus pole!");
    }


//2
Console.Write("Sisesta esimese inimese eesnimi: ");
string? nimi1 = Console.ReadLine();
Console.Write("Sisesta teise inimese eesnimi: ");
string? nimi2 = Console.ReadLine();

nimi1 = string.IsNullOrWhiteSpace(nimi1) ? "Tundmatu" : nimi1.Trim();
nimi2 = string.IsNullOrWhiteSpace(nimi2) ? "Tundmatu" : nimi2.Trim();

Console.WriteLine($"{nimi1} ja {nimi2} on täna pinginaabrid.");


//3
Console.Write("Sisesta a seina pikkus.");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Sisesta b seina pikkus.");
int number2 = int.Parse(Console.ReadLine());
int rm = number1 * number2;
if (number1 == number2)
{
    Console.WriteLine("See on ruut");
}
else
{
    Console.WriteLine($"põrand on {rm} ruutmeetrit");
    Console.Write("Kas soovite oma põrandat renoveerida? (Y/N): ");
    string answer_ = Console.ReadLine();
    if (answer_ == "Y")
    {
        Console.WriteLine("Kui palju see ruutmeetri kohta maksab?");
        int price = int.Parse(Console.ReadLine());
        int totalCost = rm * price;
        Console.WriteLine($"See läheb maksma {totalCost} eurot");

    }
}


//4
Console.Write("Sisesta 30% soodustusega hind: ");
double soodusHind = double.Parse(Console.ReadLine());

if (soodusHind < 0)
{
    Console.WriteLine("Viga: hind ei saa olla negatiivne.");
}
else
{
    double algHind = soodusHind / 0.7;
    Console.WriteLine($"Algne hind enne 30% soodustust: {algHind}");
}


//5
Console.Write("Sisesta temperatuur kraadides (°C): ");
int temperatuur = int.Parse(Console.ReadLine());

if (temperatuur > 18)
{
    Console.WriteLine("Temperatuur on üle 18°C (soovitav toasoojus).");
}
else
{
    Console.WriteLine("Temperatuur ei ole üle 18°C.");
}


//6
Console.Write("Sisesta pikkus sentimeetrites: ");
int pikkusCm = int.Parse(Console.ReadLine());

    string kategooria;
    // Piirid: <160 lühike, 160-180 keskmine, >180 pikk
if (pikkusCm < 160)
{
    kategooria = "lühike";
}
else if (pikkusCm <= 180)
{
    kategooria = "keskmine";
}
else
{
    kategooria = "pikk";
}

Console.WriteLine($"Pikkus {pikkusCm} cm — kategooria: {kategooria}.");

   
//7
int naine = 10;

Console.Write("Sisesta pikkus sentimeetrites: ");
int pikkusCm1 = int.Parse(Console.ReadLine());

int pikkusCm2 = pikkusCm1 + naine;
string kategooria1 = "";

Console.Write("Sisesta sugu (M/N): ");
char sugu = Console.ReadLine()[0];
if (sugu == 'm')
{
    if (pikkusCm1 < 160)
    {
        kategooria1 = "lühike";
    }
    else if (pikkusCm1 <= 180)
    {
        kategooria1 = "keskmine";
    }
    else
    {
        kategooria1 = "pikk";
    }
}
else
{
    if (pikkusCm2 < 160)
    {
        kategooria1 = "lühike";
    }
    else if (pikkusCm2 <= 180)
    {
        kategooria1 = "keskmine";
    }
    else
    {
        kategooria1 = "pikk";
    }
}
Console.WriteLine($"Pikkus {pikkusCm1} cm — kategooria: {kategooria1}.");

//8
double piimprice = 2.5;
double leibprice = 1.5;
double saiprice = 1.0;
double kokku = 0.0;
Console.Write("Kas te tahate osta piima? (Y/N): ");
char answer = Console.ReadLine()[0];
if (answer == 'y')
{
    kokku = kokku + piimprice;
}
else
{
    Console.WriteLine("Te ei ostnud piima.");
}
Console.Write("Kas te tahate osta leiba? (Y/N): ");
answer = Console.ReadLine()[0];
if (answer == 'y')
{
    kokku = kokku + leibprice;
}
else
{
    Console.WriteLine("Te ei ostnud leiba.");
}
Console.Write("Kas te tahate osta saia? (Y/N): ");
answer = Console.ReadLine()[0];
if (answer == 'y')
{
    kokku = kokku + saiprice;
}
else
{
    Console.WriteLine("Te ei ostnud saia.");
}
Console.WriteLine($"Teie ostukorvi kogusumma on: {kokku} eurot.");