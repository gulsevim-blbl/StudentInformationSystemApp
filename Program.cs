bool kontrol = true;
Ogrenci ogrenci1 = new Ogrenci(1, "Gül", "Bülbül", 80, 90, 100, "Bilgisayar Mühendisligi Bölümü", "İstanbul Üniversitesi");

Console.WriteLine("Uygulamamıza Hoş Geldiniz... Yapmak İstediğiniz işlemi seçiniz");

while (kontrol)
{   
    islemleriGoster();
    string secim = Console.ReadLine();
    Console.WriteLine("-----------------------------");
    switch (secim)
    {
        case "1":
            ogrenci1.ogrenciBilgileriGoster();
            break;
        case "2":
            double ortalama = ogrenci1.ogrenciOrtalamasiBul();
            Console.WriteLine("Öğrenci Ortalaması: " + ortalama);
            break;
        case "3":
            ogrenci1.okulGetir();
            break;
        case "4":
            kontrol = false;
            Console.Clear();
            Console.WriteLine("Uygulamadan çıkılıyor...");
            break;
        default:
            Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
            break;
    }
}


static void islemleriGoster()
{
    Console.WriteLine("1. Öğrenci Bilgilerini Göster");
    Console.WriteLine("2. Öğrenci Ortalamasını Hesapla");
    Console.WriteLine("3. Okul Bilgilerini Göster");
    Console.WriteLine("4. Çıkış");
}
