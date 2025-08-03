public class Ogrenci
{
    private int ogrNo;
    private string isim;
    private string soyisim;
    private int vize1;
    private int vize2;
    private int final;
    private string bolum;
    private string okulIsmi;

    public Ogrenci(int _ogrNo, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _bolum, string _okulIsmi)
    {
        ogrNo = _ogrNo;
        isim = _isim;
        soyisim = _soyisim;
        vize1 = _vize1;
        vize2 = _vize2;
        final = _final;
        bolum = _bolum;
        okulIsmi = _okulIsmi;
    }
    
    public void ogrenciBilgileriGoster()
    {
        Console.WriteLine("Öğrenci Numarası: " + ogrNo);
        Console.WriteLine("İsim: " + isim);
        Console.WriteLine("Soyisim: " + soyisim);
        Console.WriteLine("Vize 1: " + vize1);
        Console.WriteLine("Vize 2: " + vize2);
        Console.WriteLine("Final: " + final);
        Console.WriteLine("Bölüm: " + bolum);
        Console.WriteLine("Okul İsmi: " + okulIsmi);
    }
    public double ogrenciOrtalamasiBul()
    {
        double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
        return ortalama;
    }

    public void okulGetir()
    {
        Console.WriteLine("bolum: " + bolum);
        Console.WriteLine("Okul İsmi: " + okulIsmi);
    }

}