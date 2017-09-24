using System;

namespace _20170807_1Con_SayilariKarsilastir
{
    class Program
    {
        static void Main(string[] args)
        {
            // girilen iki sayıdan büyük olanı ve küçük olanı söyleyen uygulamayı yazınız

            int s1, s2;
            Console.Write("Birinci sayiyi giriniz : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayiyi giriniz : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            if (s1 > s2)
            {
                Console.WriteLine("{0} sayısı, {1} sayısından büyüktür.",s1,s2);
            }
            else if (s1 < s2)
            {
                Console.WriteLine("{0} sayısı, {1} sayısından büyüktür.",s2,s1);
            }
            else
            {
                Console.WriteLine("Sayılar birbirine eşittir.");
            }

            Console.Read();

        }
    }
}
