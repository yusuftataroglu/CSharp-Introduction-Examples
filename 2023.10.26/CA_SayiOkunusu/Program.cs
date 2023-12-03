/*
    Console'a girilen sayının okunuşunu yazdırın. (1'den 100'e kadar)
*/

//değişkenlerin tanımlanması
int girilenSayi = 0;
int yuzlerBasamagi = 0;
int onlarBasamagi = 0;
int birlerBasamagi = 0;
string sifir = "Sifir";
string bir = "Bir";
string iki = "Iki";
string uc = "Uc";
string dort = "Dort";
string bes = "Bes";
string alti = "Alti";
string yedi = "Yedi";
string sekiz = "Sekiz";
string dokuz = "Dokuz";
string on = "On";
string yirmi = "Yirmi";
string otuz = "Otuz";
string kirk = "Kirk";
string elli = "Elli";
string altmis = "Altmis";
string yetmis = "Yetmis";
string seksen = "Seksen";
string doksan = "Doksan";
string yuz = "Yuz";

//kullanıcıdan bir sayı istenmesi
do
{
    Console.Write($"\n\n0'dan 100'e kadar okunusunu gormek istediginiz bir sayi giriniz: ");
    //hata kontrolü
    try
    {
        girilenSayi = int.Parse(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine("Gecerli bir deger giriniz.");
        continue;
    }
    //sayı aralığı kontrolü
    if (girilenSayi < 0 || girilenSayi > 100)
    {
        Console.WriteLine("Gecerli bir deger giriniz.");
    }
    else
    {
        //sayının 0'a eşit olma durumu (özel durum)
        if (girilenSayi==0)
        {
            Console.WriteLine(sifir);
        }
        //girilen sayının basamak değerlerinin bulunması ve saklanması
        else
        {
            yuzlerBasamagi = girilenSayi / 100;
            onlarBasamagi = girilenSayi / 10;
            birlerBasamagi = girilenSayi % 10;
            //sayının yazılışının console'da gösterimi
            switch (yuzlerBasamagi)
            {
                case 1:
                    Console.Write(yuz);
                    break;
                default:
                    break;
            }
            switch (onlarBasamagi)
            {
                case 1:
                    Console.Write(on + " ");
                    break;
                case 2:
                    Console.Write(yirmi + " ");
                    break;
                case 3:
                    Console.Write(otuz + " ");
                    break;
                case 4:
                    Console.Write(kirk + " ");
                    break;
                case 5:
                    Console.Write(elli + " ");
                    break;
                case 6:
                    Console.Write(altmis + " ");
                    break;
                case 7:
                    Console.Write(yetmis + " ");
                    break;
                case 8:
                    Console.Write(seksen + " ");
                    break;
                case 9:
                    Console.Write(doksan + " ");
                    break;
                default:
                    break;
            }
            switch (birlerBasamagi)
            {
                case 1:
                    Console.Write(bir);
                    break;
                case 2:
                    Console.Write(iki);
                    break;
                case 3:
                    Console.Write(uc);
                    break;
                case 4:
                    Console.Write(dort);
                    break;
                case 5:
                    Console.Write(bes);
                    break;
                case 6:
                    Console.Write(alti);
                    break;
                case 7:
                    Console.Write(yedi);
                    break;
                case 8:
                    Console.Write(sekiz);
                    break;
                case 9:
                    Console.Write(dokuz);
                    break;
                default:
                    break;
            }
        }
    }
        
} while (true);

