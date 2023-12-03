/*
    ÖDEV 1:
    kullanıcıdan bir kategori alın.
    kullanıcının girdiği ürün kategorisi 
    Eğer telefon, tablet, bilgisayar ise "Teknoloji reyonumuz 1. Kattadır"
    Eğer Domates, biber, patlıcan ise "Sebze reyonumuz zemin kattadır"
    Eğer Parfüm, ruj, eyeliner ise "Kozmetik reyonumuz 2. kattadır",
    Eğer Pantolon, şapka, tişört ise "Giyim reyonumuz 3. kattadır".
    Eğer bu değerlerden hariç bir değer girilmiş ise "Yan mağazaya bakın" uyarısını kullanıcıya gösterin.
*/

//Değişkenleri tanımlama
string urunAdi = "";

//Kullanıcıdan veri alma
Console.Write("Satın almak istediğiniz ürünü giriniz: ");
urunAdi = Console.ReadLine().ToLower();

//Alınan veriyi sorgulama ve çıktı verme
if (urunAdi == "telefon" || urunAdi == "tablet" || urunAdi == "bilgisayar")
{
    Console.WriteLine("Teknoloji reyonumuz 1. kattadır.");
}
else if (urunAdi == "domates" || urunAdi == "biber" || urunAdi == "patlican")
{
    Console.WriteLine("Sebze reyonunumuz zemin kattadır.");
}
else if (urunAdi == "parfum" || urunAdi == "ruj" || urunAdi == "eyeliner")
{
    Console.WriteLine("Kozmetik reyonumuz 2. kattadır.");
}
else if (urunAdi == "pantolon" || urunAdi == "sapka" || urunAdi == "tshirt")
{
    Console.WriteLine("Giyim reyonumuz 3. kattadır.");
}
else
    Console.WriteLine("Yan mağazaya bakın.");


