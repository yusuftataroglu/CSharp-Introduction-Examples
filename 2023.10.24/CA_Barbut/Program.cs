//değişkenlerin belirlenmesi
string oyuncu1 = "";
string oyuncu2 = "";
int oyuncu1Puan = 500;
int oyuncu2Puan = 500;
int oyuncu1Zar = 0;
int oyuncu2Zar = 0;
int oyuncu1YatirilanPuan = 0;
int oyuncu2YatirilanPuan = 0;

//instance oluşturulması
Random rnd = new Random();

//kullanıcı isimlerinin alınması
Console.Write("1. oyuncu, isminizi giriniz: ");
oyuncu1 = Console.ReadLine();
Console.Write("2. oyuncu, isminizi giriniz: ");
oyuncu2 = Console.ReadLine();

//başlangıç bakiyelerinin gösterilmesi
Console.WriteLine("*****************************************************************************");
Console.WriteLine("Mevcut bakiyeler");
Console.WriteLine(oyuncu1 + " " + "bakiye: " + oyuncu1Puan);
Console.WriteLine(oyuncu2 + " " + "bakiye: " + oyuncu2Puan);
Console.WriteLine("*****************************************************************************");

//ortaya yatırılacak puanların belirlenmesi
Console.Write(oyuncu1 + " " + "isimli oyuncu lutfen yatirmak istediginiz puani giriniz: ");

//hata kontrolü
try
{
    oyuncu1YatirilanPuan = int.Parse(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//geçerli puan kontrolü
if (oyuncu1YatirilanPuan > oyuncu1Puan)
{
    Console.WriteLine("Yetersiz puan");
}
else if (oyuncu1YatirilanPuan <=0)
{
    Console.WriteLine("Lutfen 0'dan buyuk bir puan giriniz!");
}
else
{
    Console.Write(oyuncu2 + " " + "isimli oyuncu lutfen yatirmak istediginiz puani giriniz: ");

    //oyuncu1 puan güncellemesi
    oyuncu1Puan = oyuncu1Puan - oyuncu1YatirilanPuan;

    //hata kontrolü
    try
    {
        oyuncu2YatirilanPuan = int.Parse(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    //geçerli puan kontrolü
    if (oyuncu2YatirilanPuan > oyuncu2Puan)
    {
        Console.WriteLine("Yetersiz puan");
    }
    else if (oyuncu2YatirilanPuan < oyuncu1YatirilanPuan)
    {
        Console.WriteLine("Yatirdiginiz puan " + oyuncu1 + " " + "oyuncusunun yatirdigi puandan az olamaz!");
    }
    else if (oyuncu2YatirilanPuan <= 0)
    {
        Console.WriteLine("Lutfen 0'dan buyuk bir puan giriniz!");
    }
    else
    {

        //oyuncu2 puan güncellemesi
        oyuncu2Puan = oyuncu2Puan - oyuncu2YatirilanPuan;
        Console.WriteLine("*****************************************************************************");

        //zarların atılması
        Console.Write(oyuncu1 + " " + "isimli oyuncu, zar atiniz.");
        oyuncu1Zar = rnd.Next(1, 7);
        Console.ReadLine();
        Console.WriteLine(oyuncu1 + " oyuncusunun attigi zar: " + oyuncu1Zar);
        Console.Write(oyuncu2 + " " + "isimli oyuncu, zar atiniz.");
        oyuncu2Zar = rnd.Next(1, 7);
        Console.ReadLine();
        Console.WriteLine(oyuncu2 + " oyuncusunun attigi zar: " + oyuncu2Zar);
        Console.WriteLine("*****************************************************************************");

        //galibin belirlenmesi ve puanların güncellenmesi
        if (oyuncu1Zar > oyuncu2Zar)
        {
            Console.WriteLine("Oyunun kazanani: " + oyuncu1);
            oyuncu1Puan = oyuncu1Puan + oyuncu1YatirilanPuan + oyuncu2YatirilanPuan;
        }
        else if (oyuncu1Zar < oyuncu2Zar)
        {
            Console.WriteLine("Oyunun kazanani: " + oyuncu2);
            oyuncu2Puan = oyuncu2Puan + oyuncu1YatirilanPuan + oyuncu2YatirilanPuan;
        }
        else
        {
            Console.WriteLine("Oyun berabere.");
            oyuncu1Puan = oyuncu1Puan + oyuncu1YatirilanPuan;
            oyuncu2Puan = oyuncu2Puan + oyuncu2YatirilanPuan;
        }
        Console.WriteLine("*****************************************************************************");

        //özet
        Console.WriteLine(oyuncu1 + ": " + "Yatirilan puan: " + oyuncu1YatirilanPuan + ", " + "Atilan zar: " + oyuncu1Zar + ", " + "Guncel puan: " + oyuncu1Puan);
        Console.WriteLine(oyuncu2 + ": " + "Yatirilan puan: " + oyuncu2YatirilanPuan + ", " + "Atilan zar: " + oyuncu2Zar + ", " + "Guncel puan: " + oyuncu2Puan);
    }
}

//console'un okunması
Console.Read();