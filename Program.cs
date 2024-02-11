namespace SayiKontrolUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            basadon:
            Console.WriteLine("Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {
                Console.Clear();
                goto basadon;
            }
            else
            {
                Console.WriteLine(sayi<0 ? "Sayı Negatif" : "Sayı Pozitif");
            }
        }
    }
}