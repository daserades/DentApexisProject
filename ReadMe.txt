Proje için örnek database yüklenmiþtir.

örnek database kullanýlmamasý durumunda;

1) sql server management studio da appuser tablosuna þu bilgiler eklenir;

---- Username : duru.yýldýz
---- Name     : Duru
---- Lastname : Yýldýz
---- Password : 123
---- Pozisyon : Boss
---- Fullname : Duru Yýldýz
---- Salary   : 15000
---- CreatedDate : 2020.01.01

2) Visiual Studio da DentApexisWinUI çalýþtýrýlýnca duru.yýldýz 123 kullanýcý adý ve þifresi ile giriþ yaptýktan sonra personel kayýt sekmesine týklayýp açýlan ekranda sýrasýyla personellerimizi ekliyoruz.
---- Duru Yýldýz  - Doktor
---- Ayþe Yýlmaz  - Doktor
---- Fatma Solmaz - Doktor
---- Merve Durmaz - Personel
---- Aytaç Mutlu  - Muhasebe
NOT: Bu isimler AppUser olarak veritabanýna eklenmiþ olacak(her biri  için þifre 123)

3) Bu iþlemler tamamlandýktan sonra;

---- merve.durmaz username'i ile hasta kayýt ve randevu iþlemlerini,
---- duru.yýldýz, ayþe.yýlmaz, fatma.solmaz username'leri ile tedavi planlama iþlemlerini yapabilir,username e ait randevularý takip edebilirsiniz.
---- aytaç.mutlu username'i ile muhasebe iþlemlerini,planlanan tedavilerin Hasta ödeme iþlemlerini, aylýk mali durumu görebilirsiniz
---- duru.yýlmaz username'i ile otomasyonda sýnýrlama olmadan tüm sayfalarý görüntüleyebilirsiniz.

NOT: Doktor tarafýndan planlanan tedavilerin ücretini muhasebe görevlisi tahsilatý yaptýktan sonra onaylar ve doktor ödemesini yapan hastanýn tedavi sürecini baþlatýr.

