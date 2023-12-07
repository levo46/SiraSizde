using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraSizde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranIslem ei = new EkranIslem();
            ei.EkranaYaz(0,2);
            Console.WriteLine("=======================");
            ei.EkranaYaz();
        }
    }
    class EkranIslem
    {
        public void EkranaYaz(params int[] sayilar)
        {
            if (sayilar.Length == 0)
            {
                Console.WriteLine("Parametre olmadığı için metottan çıkılıyor.");
                return;
            }
            Console.WriteLine("Parametreden gelen değerler:");
            foreach (var s in sayilar)
            {
                if (s == 0)
                {
                    return;
                }
                Console.WriteLine(s);
            }
        }
    }
}
