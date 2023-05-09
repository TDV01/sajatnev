using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sajatnev
{
    internal class Program
    {
        static List<Vasarlo> vasarloList=new List<Vasarlo>();
        static Adatbazis db =new Adatbazis();
        static List<Konyv> konyvList = new List<Konyv>();

        static void Main(string[] args)
        {
            beolvasas();
            feladat1();
            feladat2();
            feladat3();
            Console.WriteLine("Program vége!");
            Console.ReadKey();
        }

        private static void feladat1()
        {
            Console.WriteLine($"1.feladat vásáró száma:{vasarloList.Count()}");

        }
        private static void feladat2()
        {
            Vasarlo vasarlo = vasarloList.Find(a => a.nev=="Dag Linne");
            Console.WriteLine($"2.feladat: Dag Linne email címe: {vasarlo.email_cim}");

        }

        private static void feladat3() 
        {
            Console.WriteLine("3.feladat: ");
            foreach (var item in konyvList.GroupBy(a => a.szerzo).Select(b =>new {szerzo=b.Key,db=b.Count()})) 
            {
                if (item.db>1)
                {
                    Console.WriteLine($"");
                }
            }

        }








        private static void beolvasas()
        {
            vasarloList = db.getvasarlok();
            konyvList = db.getkonyvek();

        }
    }
}
