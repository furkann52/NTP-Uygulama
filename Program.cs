using EvlerLib;

namespace EmlakciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ac = true;

            do
            {
                Console.WriteLine("Seçiminizi Yapınız: ");
                Console.WriteLine("1-Satılık Ev");
                Console.WriteLine("2-Kiralık Ev");
                string scm = Console.ReadLine();
                ForSaleHomes satev = new ForSaleHomes();
                RentalHomes kiraev = new RentalHomes();
                bool kontrol = true;

                if (scm == "1")
                {
                    Console.WriteLine("1- Satılık Ev Bilgileri");
                    Console.WriteLine("2- Yeni Satılık Ev Kayıtı");
                    string satiliksecim = Console.ReadLine();


                    if (satiliksecim == "1")
                    {
                        Console.WriteLine(satev.EvBilgileriGetir());
                    }
                    else if (satiliksecim == "2")
                    {
                        List<string> satilikkayit = new List<string>();
                        do
                        {
                            Console.WriteLine("Yeni Kayıtları Giriniz : ");
                            Console.WriteLine("Semt: ");
                            satev.Semt = Console.ReadLine();
                            Console.WriteLine("Satış Fiyatını Giriniz: ");
                            satev.Satisfiyat = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Oda Sayısını Giriniz: ");
                            satev.Odasayisi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kat Numarasını Giriniz: ");
                            satev.Katno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Metrekaresini Giriniz: ");
                            satev.Alan = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Kayıta devam etmek istiyor musunuz ? E/H");
                            string sor = Console.ReadLine().ToUpper();
                            if (sor == "H") { kontrol = false; }

                            satilikkayit.Add(satev.EvBilgileri());

                        } while (kontrol);
                        Console.WriteLine("Girilen Evlerin Bilgileri Dosyaya Kayıt Edildi. ");
                        satev.EvKayit(satilikkayit);


                    }
                }
                else if (scm == "2")
                {
                    Console.WriteLine("1-Kiralık Evleri Görüntüle");
                    Console.WriteLine("2-Yeni Kiralık Ev Kayıtı");
                    string kiraliksecim = Console.ReadLine();
                    if (kiraliksecim == "1")
                    {
                        Console.WriteLine(kiraev.EvBilgileriGetir());
                    }
                    else if (kiraliksecim == "2")
                    {
                        List<string> kiralikkayit = new List<string>();
                        do
                        {
                            Console.WriteLine("Yeni Kayıtları Giriniz : ");
                            Console.WriteLine("Semt : ");
                            kiraev.Semt = Console.ReadLine();
                            Console.WriteLine("Kira Fiyati : ");
                            kiraev.Kira = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Depozito Ücreti : ");
                            kiraev.Depozito = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Oda Sayisi : ");
                            kiraev.Odasayisi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kat Numarası: ");
                            kiraev.Katno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Metrekaresi: ");
                            kiraev.Alan = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Kayıta devam etmek istiyor musunuz ? E/H");
                            string sor = Console.ReadLine().ToUpper();
                            if (sor == "H") { kontrol = false; }

                            kiralikkayit.Add(kiraev.EvBilgileri());

                        } while (kontrol);
                        Console.WriteLine("Girilen Evlerin Bilgileri Dosyaya Kayıt Edildi. ");
                        kiraev.EvKayit(kiralikkayit);

                    }
                }

                else
                {
                    Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                }

                Console.WriteLine("Başka İşlem Yapmak İster misiniz ? E/H");
                string tch = Console.ReadLine().ToUpper();

                if (tch== "H")
                {
                    ac = false;
                }

            } while (ac);

           

        }
    }
}