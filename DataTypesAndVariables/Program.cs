namespace DataTypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)  
        {
            Console.WriteLine("Hello, World!");
            #region Value Types
            int sayi1 ; // declaration, 32bit -2 milyar...2 milyar
            sayi1 = 11; // assigment
            Console.WriteLine("sayi1:" + sayi1); // Sayı 1 : 11

            Console.WriteLine("Max:{0}, Min{1}", int.MaxValue, int.MinValue);
            Console.WriteLine ($"Max:{Int32.MaxValue},Min: {int.MinValue}");

                uint sayi2 = 22; // 32 bit , 0 ...4 milyar , u unsigned
            Console.WriteLine($"sayi2:{sayi2}");// sayı 2 :22

            long sayi3 = 3000000000; // int64 , 64 bit, -9 kenttrilyon...9 kenttrilyon
            Console.WriteLine("sayi3 :" + sayi3 + "."); // Sayı 3: 3000000000

            ulong sayi4 = 3000000000000; // 64 bit ,0 ....18 kenttrilyon
            Console.WriteLine($" Sayı 4 : { sayi4}.");

            #endregion
          
        }
    }
}
