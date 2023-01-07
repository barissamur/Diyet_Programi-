using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetisyenProje.PL.Entities
{
    public static class DiyetDbContextSeed
    {
        public static void Seed(DiyetDbContext db)
        {
            if (db.Besinler.Any() && db.Kullanicilar.Any() && db.Adminler.Any()) return;

            var besinler = new Besin[]
            {
                new Besin()
                {
                    Ad = "Balık",
                    Kalori = 205.8,
                    BesinKategoriId = 12
                },

                new Besin()
                {
                    Ad = "Tavuk",
                    Kalori = 239.0,
                    BesinKategoriId = 2
                },

                new Besin()
                {
                    Ad = "Yumurta",
                    Kalori = 155.0,
                    BesinKategoriId = 2
                },

                new Besin()
                {
                    Ad = "Süt",
                    Kalori = 42.3,
                    BesinKategoriId = 5
                },

                new Besin()
                {
                    Ad = "Yulaf",
                    Kalori = 67.6,
                    BesinKategoriId = 4
                },

                new Besin()
                {
                    Ad = "Beyaz Peynir",
                    Kalori = 402.0,
                    BesinKategoriId = 5
                },

                   new Besin()
                {
                    Ad = "Siyah Üzüm",
                    Kalori = 71,
                    BesinKategoriId = 3
                },

                   new Besin()
                {
                    Ad = "Yeşil Üzüm",
                    Kalori =68,
                    BesinKategoriId = 3
                },

                   new Besin()
                {
                    Ad = "Çilek",
                    Kalori = 32,
                    BesinKategoriId = 3
                },

                   new Besin()
                {
                    Ad = "Erik",
                    Kalori =47,
                    BesinKategoriId = 3
                },

                   new Besin()
                {
                    Ad = "Armut",
                    Kalori = 58,
                    BesinKategoriId = 3
                },

                   new Besin()
                {
                    Ad = "Şeftali",
                    Kalori = 39,
                    BesinKategoriId = 3
                },

                   new Besin()
                {
                    Ad = "Kavun",
                    Kalori = 33,
                    BesinKategoriId = 3
                },

                   new Besin()
                {
                    Ad = "İncir",
                    Kalori = 74,
                    BesinKategoriId = 3
                },

                   new Besin()
                {
                    Ad = "Karpuz",
                    Kalori = 26,
                    BesinKategoriId = 3
                },

                   new Besin()
                {
                    Ad = "Biber",
                    Kalori = 22,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Brokoli",
                    Kalori = 34,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Domates",
                    Kalori = 22,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Havuç",
                    Kalori = 45,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Kabak",
                    Kalori = 26,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Ispanak",
                    Kalori = 26,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Mantar",
                    Kalori = 28,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Patates",
                    Kalori = 76,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Patlıcan",
                    Kalori = 25,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Pırasa",
                    Kalori = 52,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Salatalık",
                    Kalori = 15,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Sarımsak",
                    Kalori = 123,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Limon",
                    Kalori = 56,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Mısır",
                    Kalori = 91,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Marul",
                    Kalori = 14,
                    BesinKategoriId = 1
                },

                   new Besin()
                {
                    Ad = "Sade poğaça",
                    Kalori = 263,
                    BesinKategoriId = 6
                },

                   new Besin()
                {
                    Ad = "Tam Buğday Ekmeği",
                    Kalori = 55,
                    BesinKategoriId = 6
                },

                   new Besin()
                {
                    Ad = "Çavdar Ekmeği",
                    Kalori = 61,
                    BesinKategoriId = 6
                },

                   new Besin()
                {
                    Ad = "Beyaz Ekmek",
                    Kalori = 85,
                    BesinKategoriId = 6
                },

                   new Besin()
                {
                    Ad = "Kuru Fasülye",
                    Kalori = 179,
                    BesinKategoriId = 4
                },

                   new Besin()
                {
                    Ad = "Nohut",
                    Kalori = 360,
                    BesinKategoriId = 4
                },

                   new Besin()
                {
                    Ad = "Buğday",
                    Kalori = 100,
                    BesinKategoriId = 6
                },

                   new Besin()
                {
                    Ad = "Bulgur",
                    Kalori = 342,
                    BesinKategoriId = 4
                },

                   new Besin()
                {
                    Ad = "Hindi But",
                    Kalori = 208,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Hindi Göğüs",
                    Kalori = 162,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Tavuk But",
                    Kalori = 221,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Tavuk Kalça Şiş",
                    Kalori = 177,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Tavuk Göğüs",
                    Kalori = 165,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Dana Sucuk",
                    Kalori = 445,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Kuzu Pirzola",
                    Kalori = 343,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Kuzu But",
                    Kalori = 231,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Dana Pirzola",
                    Kalori = 188,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Dana kıyma",
                    Kalori = 155,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Dana biftek",
                    Kalori = 185,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Dana Antrikot",
                    Kalori = 168,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Ton Balığı",
                    Kalori = 184,
                    BesinKategoriId = 12
                },

                   new Besin()
                {
                    Ad = "Somon",
                    Kalori = 183,
                    BesinKategoriId = 12
                },

                   new Besin()
                {
                    Ad = "Mezgit",
                    Kalori = 180,
                    BesinKategoriId = 12
                },

                   new Besin()
                {
                    Ad = "Levrek",
                    Kalori = 279,
                    BesinKategoriId = 12
                },

                   new Besin()
                {
                    Ad = "Kalamar",
                    Kalori = 188,
                    BesinKategoriId = 12
                },

                   new Besin()
                {
                    Ad = "Hamsi",
                    Kalori = 45,
                    BesinKategoriId = 12
                },

                   new Besin()
                {
                    Ad = "Light Yoğurt",
                    Kalori = 47,
                    BesinKategoriId = 5
                },

                   new Besin()
                {
                    Ad = "Yağlı Yoğurt",
                    Kalori = 84,
                    BesinKategoriId = 5
                },

                   new Besin()
                {
                    Ad = "Laktozsuz Süt",
                    Kalori = 62.5,
                    BesinKategoriId = 5
                },

                   new Besin()
                {
                    Ad = "Kefir",
                    Kalori = 41,
                    BesinKategoriId = 5
                },

                   new Besin()
                {
                    Ad = "Kaşar Peynir",
                    Kalori = 101,
                    BesinKategoriId = 5
                },

                   new Besin()
                {
                    Ad = "Mozarella",
                    Kalori = 70,
                    BesinKategoriId = 5
                },

                   new Besin()
                {
                    Ad = "Otlu Peynir",
                    Kalori = 82,
                    BesinKategoriId = 5
                },

                   new Besin()
                {
                    Ad = "Tulum Peynir",
                    Kalori = 89,
                    BesinKategoriId = 5
                },

                   new Besin()
                {
                    Ad = "Lor Peynir",
                    Kalori = 21,
                    BesinKategoriId = 5
                },

                   new Besin()
                {
                    Ad = "Kabak Çekirdeği",
                    Kalori = 610,
                    BesinKategoriId = 10
                },

                   new Besin()
                {
                    Ad = "Ay Çekirdeği",
                    Kalori = 560,
                    BesinKategoriId = 10
                },

                   new Besin()
                {
                    Ad = "Yer Fıstığı",
                    Kalori = 580,
                    BesinKategoriId = 10
                },

                   new Besin()
                {
                    Ad = "Fındık",
                    Kalori = 630,
                    BesinKategoriId = 10
                },

                   new Besin()
                {
                    Ad = "Kaju Fıstığı",
                    Kalori = 610,
                    BesinKategoriId = 10
                },

                   new Besin()
                {
                    Ad = "Ceviz",
                    Kalori = 650,
                    BesinKategoriId = 10
                },

                   new Besin()
                {
                    Ad = "Antep Fıstığı",
                    Kalori = 590,
                    BesinKategoriId = 10
                },

                   new Besin()
                {
                    Ad = "Badem",
                    Kalori = 600,
                    BesinKategoriId = 10
                },

                   new Besin()
                {
                    Ad = "Çörek Otu",
                    Kalori = 200,
                    BesinKategoriId = 6
                },

                   new Besin()
                {
                    Ad = "Ayçiçek Yağı",
                    Kalori = 769,
                    BesinKategoriId = 7
                },

                   new Besin()
                {
                    Ad = "Terayağı",
                    Kalori = 853,
                    BesinKategoriId = 7
                },

                   new Besin()
                {
                    Ad = "Zeytinyağı",
                    Kalori = 837,
                    BesinKategoriId = 7
                },

                   new Besin()
                {
                    Ad = "Hardal",
                    Kalori = 70,
                    BesinKategoriId = 11
                },

                   new Besin()
                {
                    Ad = "Ketçap",
                    Kalori = 100,
                    BesinKategoriId = 11
                },

                   new Besin()
                {
                    Ad = "Mayonez",
                    Kalori = 390,
                    BesinKategoriId = 11
                },

                   new Besin()
                {
                    Ad = "Bal",
                    Kalori = 320,
                    BesinKategoriId = 2
                },

                   new Besin()
                {
                    Ad = "Vişne Reçeli",
                    Kalori = 250,
                    BesinKategoriId = 9
                },

                   new Besin()
                {
                    Ad = "Çilek Reçeli",
                    Kalori = 270,
                    BesinKategoriId = 9
                },

                   new Besin()
                {
                    Ad = "Ahududu Reçeli",
                    Kalori = 270,
                    BesinKategoriId = 9
                },

                   new Besin()
                {
                    Ad = "Üzüm Pekmezi",
                    Kalori = 290,
                    BesinKategoriId = 9
                },

                   new Besin()
                {
                    Ad = "Ayran",
                    Kalori = 40,
                    BesinKategoriId = 13
                },

                   new Besin()
                {
                    Ad = "Kola",
                    Kalori = 37.5,
                    BesinKategoriId = 13
                },

                   new Besin()
                {
                    Ad = "Fanta",
                    Kalori = 34.5,
                    BesinKategoriId = 13
                },

                   new Besin()
                {
                    Ad = "Su",
                    Kalori = 0,
                    BesinKategoriId = 13
                },

                   new Besin()
                {
                    Ad = "Gazoz",
                    Kalori = 30,
                    BesinKategoriId = 13
                },

                   new Besin()
                {
                    Ad = "Meyve Suyu",
                    Kalori = 54.5,
                    BesinKategoriId = 13
                },

                   new Besin()
                {
                    Ad = "Sade Soda",
                    Kalori = 0,
                    BesinKategoriId = 13
                },

                   new Besin()
                {
                    Ad = "Enerji İçeceği",
                    Kalori = 46,
                    BesinKategoriId = 13
                },

                   new Besin()
                {
                    Ad = "Türk Kahvesi",
                    Kalori = 42,
                    BesinKategoriId = 13
                },

                   new Besin()
                {
                    Ad = "Filtre Kahve",
                    Kalori = 1,
                    BesinKategoriId = 13
                },

                   new Besin()
                {
                    Ad = "Çay",
                    Kalori = 1,
                    BesinKategoriId = 9
                },
            };

            foreach (var besin in besinler)
                db.Besinler.Add(besin);

            Kullanici k1 = new Kullanici()
            {
                Ad = "Mehmet",
                Soyad = "Yılmaz",
                KullaniciAdi = "myilmaz",
                Sifre = "123",
                Cinsiyet = "Erkek",
                Kilo = 80.0,
                DogumTarihi = new DateTime(1992, 07, 17),
                Boy = 1.90,
                BoyunCevresi = 34.0,
                KalcaCevresi = 88.0
            };
            k1.YagOrani();
            k1.Yas();
            k1.VucutKitleEndeksi();

            Kullanici k2 = new Kullanici()
            {
                Ad = "Ayşe",
                Soyad = "Bilgin",
                KullaniciAdi = "abilgin",
                Sifre = "123",
                Cinsiyet = "Kadın",
                Kilo = 58.0,
                DogumTarihi = new DateTime(1995, 02, 17),
                Boy = 1.70,
                BoyunCevresi = 30.0,
                KalcaCevresi = 84.0
            };
            k1.YagOrani();
            k1.Yas();
            k1.VucutKitleEndeksi();

            db.Kullanicilar.Add(k1);
            db.Kullanicilar.Add(k2);

            Admin a1 = new Admin()
            {
                Ad = "Alp",
                Soyad = "Ceyhan",
                KullaniciAdi = "aceyhan",
                Sifre = "123"
            };

            db.Adminler.Add(a1);


            var kategoriler = new BesinKategori[]
            {
                new BesinKategori(){ Ad = "Sebze" },
                new BesinKategori(){ Ad = "Hayvansal Gıda" },
                new BesinKategori(){ Ad = "Meyve" },
                new BesinKategori(){ Ad = "Bakla" },
                new BesinKategori(){ Ad = "Süt ve Süt Ürünleri" },
                new BesinKategori(){ Ad = "Ekmek ve Tahıl Ürünleri" },
                new BesinKategori(){ Ad = "Yağ çeşitleri" },
                new BesinKategori(){ Ad = "Zeyitnyağlılar" },
                new BesinKategori(){ Ad = "Tatlılar" },
                new BesinKategori(){ Ad = "Kuruyemiş" },
                new BesinKategori(){ Ad = "Sos Çeşitleri" },
                new BesinKategori(){ Ad = "Su Ürünleri" },
                new BesinKategori(){ Ad = "İçecekler" }
            };

            foreach (var kategori in kategoriler)
                db.BesinKategoriler.Add(kategori);


            db.SaveChanges();
        }

    }
}

