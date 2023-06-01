using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<dij> dijak = new List<dij>();

            StreamReader sr = new StreamReader("nobel.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');
                dijak.Add(new dij(int.Parse(adat[0]), adat[1], adat[2], adat[3]));
            }
            sr.Close();

            Console.WriteLine($"4. feladat: {dijak.Where(x => x.Evszam == 2017 && x.NobelTipus == "irodalmi").First().KeresztNev} {dijak.Where(x => x.Evszam == 2017 && x.NobelTipus == "irodalmi").First().VezetekNev}");

            Console.WriteLine("6. feladat:");
            dijak.Where(x => x.VezetekNev == "Curie").ToList().ForEach(x => Console.WriteLine($"{x.Evszam}: {x.KeresztNev} {x.VezetekNev}({x.NobelTipus})"));
            Console.WriteLine("7. feladat:");
            dijak.GroupBy(x => x.NobelTipus).ToList().ForEach(x => Console.WriteLine($"{x.Key} {x.Key.Count()}"));
        }

    }
}
