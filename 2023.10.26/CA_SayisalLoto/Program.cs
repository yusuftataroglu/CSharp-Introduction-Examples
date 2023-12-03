/*
    Uygulama çalıştırıldığında  1 ile 49 arasında 6'şar adet sayıdan meydana gelen, birbirini tekrar etmeyen 8 adet kolon dahilinde oluşturun.
*/

//değişkenlerin tanımlanması
Random rnd = new Random();
int[] sansliSayilar = new int[48];
int gecici = 0;
int kolonAdi = 1;

//dizi boyutu kadar süren bir döngü oluşturulması
for (int i = 0; i < 48; i++)
{
    //rastgele oluşturulan sayıların bir diziye eklenmesi
    sansliSayilar[i] = rnd.Next(1, 50);
    if (i == 47)
    {
        i++; //dizinin son indeksine ulaşıldığında döngünün sonlanmaması ve son 6'lık kısmın kontrol edilebilmesi için i'nin 48 yapılması
    }
    //her 6 sayıda bir tekrarlayan sayı kontrolü ve tekrarlanan sayı varsa tekrarlanan sayılardan birinin değiştirilmesi
    if (i % 6 == 0 && i != 0)
    {
        for (int j = i-6; j <= i-2; j++)
        {
            for (int k = j+1; k %6 != 0  ; k++)
            {
                if (sansliSayilar[j] == sansliSayilar[k])
                {
                    sansliSayilar[k] = rnd.Next(1, 50);
                    k--;
                }
            }
        }
    }  
}

//her kolondaki sayıların küçükten büyüğe doğru sıralanması
for (int i = 0; i < 48; i++)
{
    if (i == 47)
    {
        i++;
    }
    if (i % 6 == 0 && i != 0)
    {
        for (int j = i - 6; j <= i - 2; j++)
        {
            for (int k = j + 1; k % 6 != 0; k++)
            {
                if (sansliSayilar[j] > sansliSayilar[k])
                {
                    gecici = sansliSayilar[j];
                    sansliSayilar[j] = sansliSayilar[k];
                    sansliSayilar[k] = gecici;
                }
            }
        }
    }
}

//kolonların console'a yazdırılması
for (int i = 0; i < 6; i++)
{
    if (i == 0)
    {
        Console.WriteLine($"Kolon{kolonAdi}\t\tKolon{kolonAdi+1}\t\tKolon{kolonAdi+2}\t\tKolon{kolonAdi+3}\t\tKolon{kolonAdi+4}\t\tKolon{kolonAdi+5}\t\tKolon{kolonAdi+6}\t\tKolon{kolonAdi+7}");
        Console.WriteLine($"------\t\t------\t\t------\t\t------\t\t------\t\t------\t\t------\t\t------");
    }
    if (i % 6 == 0 && i != 0)
    {
        Console.WriteLine("");
        Console.WriteLine("Kolon" + kolonAdi);
        Console.WriteLine("------");
    }
    Console.WriteLine($"{sansliSayilar[i]}\t\t{sansliSayilar[i + 6]}\t\t{sansliSayilar[i + 12]}\t\t{sansliSayilar[i + 18]}\t\t{sansliSayilar[i + 24]}\t\t{sansliSayilar[i + 30]}\t\t{sansliSayilar[i + 36]}\t\t{sansliSayilar[i+42]}");
}

Console.Read();

