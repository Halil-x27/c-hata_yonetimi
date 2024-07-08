using System;

namespace hata_yonetimi
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("girmiş olduğunuz sayi : " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("hata :" + ex.Message.ToString());
            }
            finally{
                Console.WriteLine("işlem tamamlandı.");
            }


            try
            {
                int a = int.Parse(null);

                int b = int.Parse("test");
            }
            catch (ArgumentNullException ex)
            {
                 Console.WriteLine("Bos deger girdiniz");
                 Console.WriteLine(ex);
            }
            catch (FormatException ex){
                 Console.WriteLine("Girilen değer tipi uygun değil....");
                 Console.WriteLine(ex);
            }
            }
        }
    }
}