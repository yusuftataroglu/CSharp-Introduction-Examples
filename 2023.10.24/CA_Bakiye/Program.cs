//değişkenlerin belirlenmesi
string kullaniciAdi = "admin";
string sifre = "1234";
string girilenKullaniciAdi = "";
string girilenSifre = "";
string secim = "";
decimal bakiye = 500;
decimal cekilmekIstenenTutar = 0;
decimal yatirilmakIstenenTutar = 0;

//kullanıcı bilgilerinin alınması
Console.WriteLine("Sisteme giris yapmak icin oturum aciniz.");
Console.Write("Kullanici adiniz: ");
girilenKullaniciAdi = Console.ReadLine();
Console.Write("Sifreniz: ");
girilenSifre = Console.ReadLine();

//kullanıcı bilgilerinin kontrolü
if (kullaniciAdi == girilenKullaniciAdi && sifre == girilenSifre)
{
    Console.WriteLine("MENU" + "\n" + "1-Bakiye Goruntule" + "\n" + "2-Para Cek" + "\n" + "3-Para Yatir");
    Console.WriteLine("Yapmak istediginiz islemi seciniz: ");
    //hata kontrolü
    try
    {
        secim = Console.ReadLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
    //yapılan seçimin kontrolü
    switch (secim)
    {
        case "1":
            Console.WriteLine("Bakiyeniz: " + bakiye);
            break;
        case "2":
            Console.Write("Cekmek istediginiz tutari giriniz: ");
            //hata kontrolü
            try
            {
                cekilmekIstenenTutar = decimal.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            //çekilmek istenen bakiyenin geçerliliğinin kontrolü
            if (bakiye >= cekilmekIstenenTutar && cekilmekIstenenTutar >= 0)
            {
                bakiye = bakiye - cekilmekIstenenTutar;
                Console.WriteLine("Guncel bakiyeniz: " + bakiye);
            }
            else if (bakiye < cekilmekIstenenTutar)
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
            else if (cekilmekIstenenTutar < 0)
            {
                Console.WriteLine("Lutfen pozitif bir tutar giriniz.");
            }
            break;
        case "3":
            Console.Write("Yatirmak istediginiz tutari giriniz: ");
            //hata kontrolü
            try
            {
                yatirilmakIstenenTutar = decimal.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            //yatırılmak istenen bakiyenin kontrolü
            if (yatirilmakIstenenTutar >= 1)
            {
                bakiye = bakiye + yatirilmakIstenenTutar;
                Console.WriteLine("Yeni bakiyeniz: " + bakiye);
            }
            else if (yatirilmakIstenenTutar >= 0 && yatirilmakIstenenTutar < 1)
            {
                Console.WriteLine("Minimum 1 TL yatirabilirsiniz.");
            }
            else if (yatirilmakIstenenTutar < 0)
            {
                Console.WriteLine("Lutfen pozitif bir tutar giriniz.");
            }
            break;
        default:
            Console.WriteLine("Gecerli bir secim yapmadiniz.");
            break;
    }
}
else
{
    Console.WriteLine("Yanlis kullanici adi veya sifre.");
}

//console'un okunması
Console.Read();



