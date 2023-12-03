/*
    ÖDEV:
    kullanıcı bir menü seçecek. Ardından ekstra seçimi gerçekleştirilecek (istemezse boş geçebilecek)
    seçim yapılan ekstraların toplam fiyata dahil edilecek ve sipariş özetinde gösterilecek.
*/


//değişkenlerin tanımlanması
char secim = 'Y';
char secimEkstra = 'Y';
char secim2 = 'Y';
char secimEkstra2 = 'Y';
string menu1 = "Whooper";
string menu2 = "BigMac";
string menu3 = "McChicken";
string menu4 = "TexasSmokeHouse";
string ekstra1 = "Ketcap";
string ekstra2 = "Mayonez";
string ekstra3 = "Balli Hardal";
string ekstra4 = "RanchSos";
string ekstra5 = "Buffalo";
string ekstra6 = "Truflu Mayonez";
decimal menu1Fiyat = 100;
decimal menu2Fiyat = 150;
decimal menu3Fiyat = 75;
decimal menu4Fiyat = 200;
decimal ekstra1Fiyat = 3.19M;
decimal ekstra2Fiyat =3.28M;
decimal ekstra3Fiyat =3.5M;
decimal ekstra4Fiyat =3M;
decimal ekstra5Fiyat =5M;
decimal ekstra6Fiyat =15.5M;
decimal sepetTutar = 0;
string sepet = "";

Console.WriteLine("Hos geldiniz.");
Console.WriteLine("***************************");

//menünün console'da gösterimi
do
{
    Console.WriteLine("MENULER");
    Console.WriteLine("***************************");
    Console.WriteLine("1- Whooper (100TL)");
    Console.WriteLine("2- BigMac (150TL)");
    Console.WriteLine("3- McChicken (75TL)");
    Console.WriteLine("4- TexasSmokeHouse (200TL)");
    Console.WriteLine("0- Cikis");
    Console.WriteLine("***************************"+"\n");
    Console.Write("Lutfen istediginiz menuyu seciniz: ");
    //kullanıcıdan menü seçiminin alınması
    try
    {
        secim = Convert.ToChar(Console.ReadLine());
    }
    catch (Exception ex)
    {
        secim = 'Y';
        Console.WriteLine(ex.Message);
    }
    //kullanıcının seçiminin ve başka bir menü isteğinin kontrolü
    switch (secim)
    {
        case '0':
            Console.WriteLine("Cikis yapiliyor.");
            return;
        case '1':
            sepetTutar += menu1Fiyat;
            sepet += menu1 + ", ";
            Console.WriteLine($"Secilen menu: {menu1}\nFiyat: {menu1Fiyat}\nSepetTutari: {sepetTutar}\n");
            do
            {
                Console.WriteLine("Baska bir menu daha secmek ister misiniz?");
                Console.WriteLine("1- Evet" + "\n" + "0- Hayir");
                try
                {
                    secimEkstra = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (secimEkstra)
                {
                    case '0':
                        Console.WriteLine("Ekstralar menusuna aktariliyorsunuz...");
                        Console.WriteLine("***************************");
                        break;
                    case '1':
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli bir secim yapiniz."+"\n");
                        break;
                }
            } while (secimEkstra != '0' && secimEkstra != '1');
            break;
        case '2':
            sepetTutar += menu2Fiyat;
            sepet += menu2 + ", ";
            Console.WriteLine($"Secilen menu: {menu2}\nFiyat: {menu2Fiyat}\nSepetTutari: {sepetTutar}\n");
            do
            {
                Console.WriteLine("Baska bir menu daha secmek ister misiniz?");
                Console.WriteLine("1- Evet" + "\n" + "0- Hayir");
                try
                {
                    secimEkstra = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (secimEkstra)
                {
                    case '0':
                        Console.WriteLine("Ekstralar menusuna aktariliyorsunuz...");
                        Console.WriteLine("***************************");
                        break;
                    case '1':
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli bir secim yapiniz." + "\n");
                        break;
                }
            } while (secimEkstra != '0' && secimEkstra != '1');
            break;
        case '3':
            sepetTutar += menu3Fiyat;
            sepet += menu3 + ", ";
            Console.WriteLine($"Secilen menu: {menu3}\nFiyat: {menu3Fiyat}\nSepetTutari: {sepetTutar}\n");
            do
            {
                Console.WriteLine("Baska bir menu daha secmek ister misiniz?");
                Console.WriteLine("1- Evet" + "\n" + "0- Hayir");
                try
                {
                    secimEkstra = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (secimEkstra)
                {
                    case '0':
                        Console.WriteLine("Ekstralar menusuna aktariliyorsunuz...");
                        Console.WriteLine("***************************");
                        break;
                    case '1':
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli bir secim yapiniz." + "\n");
                        break;
                }
            } while (secimEkstra != '0' && secimEkstra != '1');
            break;
        case '4':
            sepetTutar += menu4Fiyat;
            sepet += menu4+ ", ";
            Console.WriteLine($"Secilen menu: {menu4}\nFiyat: {menu4Fiyat}\nSepetTutari: {sepetTutar}\n");
            do
            {
                Console.WriteLine("Baska bir menu daha secmek ister misiniz?");
                Console.WriteLine("1- Evet" + "\n" + "0- Hayir");
                try
                {
                    secimEkstra = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (secimEkstra)
                {
                    case '0':
                        Console.WriteLine("Ekstralar menusuna aktariliyorsunuz...");
                        Console.WriteLine("***************************");
                        break;
                    case '1':
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli bir secim yapiniz." + "\n");
                        break;
                }
            } while (secimEkstra != '0' && secimEkstra != '1');
            break;
        default:
            Console.WriteLine("Boyle bir menu bulunmamaktadir. Lutfen gecerli bir secim yapiniz."+"\n");
            break;

    }
} while ((secim != '1' && secim != '2' && secim != '3' && secim != '4') || secimEkstra != '0');

sepet += "\n";

//ekstralar menüsünün console'da gösterimi
do
{
    Console.WriteLine("Extralar");
    Console.WriteLine("***************************");
    Console.WriteLine("1- Ketçap (3,19TL)");
    Console.WriteLine("2- Mayonez (3,28TL)");
    Console.WriteLine("3- Balli Hardal (3.5TL)");
    Console.WriteLine("4- Ranch Sos (3TL)");
    Console.WriteLine("5- Buffalo Sos (5TL)");
    Console.WriteLine("6- Truflu Mayonez (15.5TL)");
    Console.WriteLine("0- Cikis");
    Console.WriteLine("***************************" + "\n");
    Console.Write("Lutfen istediginiz ekstrayi seciniz: ");
    //kullanıcıdan ekstra seçiminin alınması
    try
    {
        secim2 = Convert.ToChar(Console.ReadLine());
    }
    catch (Exception ex)
    {
        secim2 = 'Y';
        Console.WriteLine(ex.Message);
    }
    //kullanıcının seçiminin ve başka bir ekstra isteğinin kontrolü
    switch (secim2)
    {
        case '0':
            Console.WriteLine("Cikis yapiliyor.");
            return;
        case '1':
            sepetTutar += ekstra1Fiyat;
            sepet += ekstra1 + ", ";
            Console.WriteLine($"Secilen menu: {ekstra1}\nFiyat: {ekstra1Fiyat}\nSepetTutari: {sepetTutar}\n");
            do
            {
                Console.WriteLine("Baska bir ekstra daha secmek ister misiniz?");
                Console.WriteLine("1- Evet" + "\n" + "0- Hayir");
                try
                {
                    secimEkstra2 = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (secimEkstra2)
                {
                    case '0':
                        Console.WriteLine("Sepete aktariliyorsunuz...");
                        break;
                    case '1':
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli bir secim yapiniz." + "\n");
                        break;
                }
            } while (secimEkstra2 != '0' && secimEkstra2 != '1');
            break;
        case '2':
            sepetTutar += ekstra2Fiyat;
            sepet += ekstra2 + ", ";
            Console.WriteLine($"Secilen menu: {ekstra2}\nFiyat: {ekstra2Fiyat}\nSepetTutari: {sepetTutar}\n");
            do
            {
                Console.WriteLine("Baska bir ekstra daha secmek ister misiniz?");
                Console.WriteLine("1- Evet" + "\n" + "0- Hayir");
                try
                {
                    secimEkstra2 = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (secimEkstra2)
                {
                    case '0':
                        Console.WriteLine("Sepete aktariliyorsunuz...");
                        break;
                    case '1':
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli bir secim yapiniz." + "\n");
                        break;
                }
            } while (secimEkstra2 != '0' && secimEkstra2 != '1');
            break;
        case '3':
            sepetTutar += ekstra3Fiyat;
            sepet += ekstra3 + ", ";
            Console.WriteLine($"Secilen menu: {ekstra3}\nFiyat: {ekstra3Fiyat}\nSepetTutari: {sepetTutar}\n");
            do
            {
                Console.WriteLine("Baska bir ekstra daha secmek ister misiniz?");
                Console.WriteLine("1- Evet" + "\n" + "0- Hayir");
                try
                {
                    secimEkstra2 = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (secimEkstra2)
                {
                    case '0':
                        Console.WriteLine("Sepete aktariliyorsunuz...");
                        break;
                    case '1':
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli bir secim yapiniz." + "\n");
                        break;
                }
            } while (secimEkstra2 != '0' && secimEkstra2 != '1');
            break;
        case '4':
            sepetTutar += ekstra4Fiyat;
            sepet += ekstra4 + ", ";
            Console.WriteLine($"Secilen menu: {ekstra4}\nFiyat: {ekstra4Fiyat}\nSepetTutari: {sepetTutar}\n");
            do
            {
                Console.WriteLine("Baska bir ekstra daha secmek ister misiniz?");
                Console.WriteLine("1- Evet" + "\n" + "0- Hayir");
                try
                {
                    secimEkstra2 = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (secimEkstra2)
                {
                    case '0':
                        Console.WriteLine("Sepete aktariliyorsunuz...");
                        break;
                    case '1':
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli bir secim yapiniz." + "\n");
                        break;
                }
            } while (secimEkstra2 != '0' && secimEkstra2 != '1');
            break;
        case '5':
            sepetTutar += ekstra5Fiyat;
            sepet += ekstra5 + ", ";
            Console.WriteLine($"Secilen menu: {ekstra5}\nFiyat: {ekstra5Fiyat}\nSepetTutari: {sepetTutar}\n");
            do
            {
                Console.WriteLine("Baska bir ekstra daha secmek ister misiniz?");
                Console.WriteLine("1- Evet" + "\n" + "0- Hayir");
                try
                {
                    secimEkstra2 = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (secimEkstra2)
                {
                    case '0':
                        Console.WriteLine("Sepete aktariliyorsunuz...");
                        break;
                    case '1':
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli bir secim yapiniz." + "\n");
                        break;
                }
            } while (secimEkstra2 != '0' && secimEkstra2 != '1');
            break;
        case '6':
            sepetTutar += ekstra6Fiyat;
            sepet += ekstra6 + ", ";
            Console.WriteLine($"Secilen menu: {ekstra6}\nFiyat: {ekstra6Fiyat}\nSepetTutari: {sepetTutar}\n");
            do
            {
                Console.WriteLine("Baska bir ekstra daha secmek ister misiniz?");
                Console.WriteLine("1- Evet" + "\n" + "0- Hayir");
                try
                {
                    secimEkstra2 = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (secimEkstra2)
                {
                    case '0':
                        Console.WriteLine("Sepete aktariliyorsunuz...");
                        break;
                    case '1':
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli bir secim yapiniz." + "\n");
                        break;
                }
            } while (secimEkstra2 != '0' && secimEkstra2 != '1');
            break;
        default:
            Console.WriteLine("Boyle bir ekstra bulunmamaktadir. Lutfen gecerli bir secim yapiniz." + "\n");
            break;

    }
} while ((secim2 != '1' && secim2 != '2' && secim2 != '3' && secim2 != '4' && secim2 != '5' && secim2 != '6') || secimEkstra2 != '0');

Console.WriteLine("***************************");
Console.WriteLine($"Siparis Ozeti\n{sepet}\nOdemeniz gereken tutar: {sepetTutar}TL");
Console.Read();



