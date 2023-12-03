/*
Tahmin ET

Uygulama çalıştırıldığında 1 ile 10 arasında rastgele bir sayı tutulsun.
kullanıcının 5 adet deneme hakkı bulunsun.
kullanıcı arka planda tutulan sayıyı tahmin etsin.
eğer kullanıcı sayıyı doğru tahmin ederse  2'e geçilsin.  2'de arkaplanda 1 ile 20 arasında sayı tutulsun. Deneme hakkı tekrar 5 olarak güncellenecek.
eğer tahmin edilen tutulan sayıdan küçük ise "lütfen daha büyük bir sayı girin" uyarısını yazdırın. deneme hakkını bir kez düşürün.
eğer tahmin edilen tutulan sayıdan büyük ise "lütfen daha küçük bir sayı girin" uyarısını yazdırın. deneme hakkını bir kez düşürün.
deneme hakkı 0 olduğunda "hakkın doldu" puan yükleyin.
 10 kadar.
*/




//instance oluşturulması
Random rnd = new Random();

//değişkenlerin belirlenmesi
int maksimumSayi = 10;
int tahmin = 0;
int denemeHakki = 5;
int rastgeleSayi = 0;

//programın durmaması için sonsuz döngü oluşturulması
while (true)
{
    //rastgele sayı belirlenmesi
    rastgeleSayi = rnd.Next(1, maksimumSayi);
    //her bir seviye geçişinde ve oyuna tekrar başlanıldığında deneme hakkının yenilenmesi

    denemeHakki = 5;
    //kullanıcıdan sayı tahmininin alınması
    Console.Write("1 ile " + maksimumSayi + " arasinda secilen sayiyi tahmin edin: ");
    //deneme hakkı bitene kadar tahmin yapılabilmesi için döngü oluşturulması
    while (denemeHakki>0)
    {
        //kullanıcı tahmininin alınması
        tahmin = int.Parse(Console.ReadLine());
        //deneme hakkının azaltılması
        denemeHakki--;
        //tahminin doğruluğunun kontrolü
        if (tahmin < rastgeleSayi)
        {
            //kalan deneme hakkının kontrolü
            if (denemeHakki>0)
            {
                Console.WriteLine("Kalan hakkiniz: " + denemeHakki);
                Console.Write("Lutfen daha buyuk bir sayi giriniz: ");
            }
            else
            {
                maksimumSayi = 10;
                Console.WriteLine("Sayiyi bulamadiniz. Oyun yeniden baslatiliyor.");
                Console.WriteLine("*********************************************************************************");
            }
        }
        else if (tahmin > rastgeleSayi)
        {
            if (denemeHakki > 0)
            {
                Console.WriteLine("Kalan hakkiniz: " + denemeHakki);
                Console.Write("Lutfen daha kucuk bir sayi giriniz: ");
            }
            else
            {
                maksimumSayi = 10;
                Console.WriteLine("Sayiyi bulamadiniz. Oyun yeniden baslatiliyor.");
                Console.WriteLine("*********************************************************************************");
            }
        }
        else
        {
            Console.WriteLine("Tebrikler kazandiniz. Bir sonraki seviyeye geciliyor.");
            maksimumSayi += 10;
            break;
        }
    }
    
}








