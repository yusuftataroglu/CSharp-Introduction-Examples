/*
    ÖDEV 2:
	kullanıcı adı: admin
	şifre: 1234

	kullanıcıdan bir kullanıcı adı alın ardından şifre alın.
	Eğer kullanıcı adı ve şifre doğru ise

	kullanıcıdan vize notu alın (%30)
	kullanıcıdan final notu alın. (%70)
	harf notunu hesaplayın.
	0-44=> FF
	45-54=> DD
	55-69=> CC
	70-84=> BB
	85-100 => AA

	eğer rakamsal değer yerine metinsel değer girilirse kullanıcıya uyarı gösterin.
	kullanıcıdan eksi bir değer ve 100'ün üzerinde bir değer alınamasın. Kullanıcı duru durumu ihlal ettiğinde uyarı mesajı gösterin.

	Eğer kullanıcı adı doğru şifre yanlış ise "kullanıcı adı doğru şifre yanlış",
	Eğer kullanıcı adı yanlış ise "kullanıcı adı yanlış, şifreye bakmadım bile" uyarısını console'da gösterin.
*/

//değişkenlerin tanımlanması
string kullaniciAdi = "";
string sifre = "";
float vize = 0f;
float final = 0f;
float not = 0f;
string harfNotu = "";

Console.Write("Kullanici adi giriniz: ");
kullaniciAdi = Console.ReadLine();
//kullanıcı adı kontrolü
if (kullaniciAdi != "admin")
{
    Console.WriteLine("Kullanici adi yanlis. Sifreye bakmadim bile.");
}
else
{
    Console.Write("Sifreyi giriniz: ");
    sifre = Console.ReadLine();
    //şifre kontrolü
    if (sifre != "1234")
    {
        Console.WriteLine("Sifreyi yanlis girdiniz.");
    }
    else
    {
        Console.WriteLine("Hoş geldiniz!");
        Console.Write("Vize notunu giriniz: ");
        //vize notu için hata kontrolü
        
        try
        {
            vize = float.Parse(Console.ReadLine());

        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        //vize notu için sınır değerler kontrolü
        if (vize < 0 || vize > 100)
        {
            Console.WriteLine("Vize notu 0 ile 100 araliginda olmalidir.");
        }
        else
        {
            Console.Write("Final notunu giriniz: ");
            //final notu için hata kontrolü
            try
            {
                final = float.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //final notu için sınır değerler kontrolü
            if (final < 0 || final > 100)
            {
                Console.WriteLine("Final notu 0 ile 100 araliginda olmalidir.");
            }
            //notun hesaplanması ve harf notunun belirlenmesi
            else
            {
                not = vize * 0.3f + final * 0.7f;
                if (not >= 0 && not <= 44)
                {
                    harfNotu = "FF";
                }
                else if (not > 44 && not <= 54)
                {
                    harfNotu = "DD";
                }
                else if (not > 54 && not <= 69)
                {
                    harfNotu = "CC";
                }
                else if (not > 69 && not <= 84)
                {
                    harfNotu = "BB";
                }
                else
                {
                    harfNotu = "AA";
                }
                //kullanıcıya çıktı verilmesi
                Console.WriteLine("Ortalama: " + not + "\n" + "Harf notu: " + harfNotu);
            }
        }

    }
}