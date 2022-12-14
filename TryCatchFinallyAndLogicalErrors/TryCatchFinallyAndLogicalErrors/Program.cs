internal class Program
{
    private static void Main(string[] args)
    {
        //Try catch blokları sayesinde uygulama içerisinde bir hata oluştuğunda belirtilen işlemler yaptırılabilir.
        //try { Hataya sebebiyet verme ihtimali olan kod }

        //catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }

        //finally { Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }
        /*  try
          {
              Console.WriteLine("Bir Sayı Giriniz: ");
              int sayi = int.Parse(Console.ReadLine());
              Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
              Console.ReadKey();
          }


          catch (Exception ex)
          {
              Console.WriteLine("Hata: " + ex.Message.ToString());
          }

          finally
          {
              Console.WriteLine("İşlem Tamamlandı.");
              Console.ReadKey();
          }
            //bu blokta sayı girilirse sıkıntı yok ama harf girildiği zaman hata alınacaktır.
          */


        /*try
        //değerin noş olamaması durumu
        {
            int a = int.Parse(null);

        }


        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş Değer Girdiniz.");
            Console.WriteLine(ex);
        }
        Console.ReadKey();

        */




        /*try   //bu blokta farklı bir veri tipi girildiği için sistem hatası alındı
        {
            int a = int.Parse("test");

        }


        catch (FormatException ex)
        {
            Console.WriteLine("Veri Tipi Uygun Değil.");
            Console.WriteLine(ex);
        }
        Console.ReadKey();
        */




        try   
        {
            int a = int.Parse("-2000000000000000");

        }


        catch (OverflowException ex)
        {
            Console.WriteLine("Çok Küçük Veya Çok Büyük Bir Değer Girdiniz.");
            Console.WriteLine(ex);
        }
        Console.ReadKey();

        finally
        {
            Console.WriteLine("İŞLEM BAŞARIYLA TAMAMLANDI");
        }





    }
}