using System;

namespace NajveciDjeljiviBroj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj:");
            int broj1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj:");
            int broj2 = Convert.ToInt32(Console.ReadLine());

            int najveciDjeljiviBroj = PronadjiNajveciDjeljiviBroj(broj1, broj2);

            Console.WriteLine("Najveći broj djeljiv s oba unesena broja je: " + najveciDjeljiviBroj);
        }

        static int PronadjiNajveciDjeljiviBroj(int broj1, int broj2)
        {
            int manjiBroj = Math.Min(broj1, broj2);

            for (int i = manjiBroj; i >= 1; i--)
            {
                if (broj1 % i == 0 && broj2 % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }
    }
}
