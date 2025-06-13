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

                uint sayi2 = 22; // 32 bit , 0 ...4 milyar , u unsigned
            Console.WriteLine($"sayi2:{sayi2}");// sayı 2 :22



            #endregion
          
        }
    }
}
