using System;
using System.Collections.Generic;
using System.Text;

namespace Kordamine
{
    public class StartPageOsa4
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
            using (StreamWriter sw = new StreamWriter(path))
                {
                sw.WriteLine("Midagi");
                }
        }
    }
}
