Proje i�in �rnek database y�klenmi�tir.

�rnek database kullan�lmamas� durumunda;

1) sql server management studio da appuser tablosuna �u bilgiler eklenir;

---- Username : duru.y�ld�z
---- Name     : Duru
---- Lastname : Y�ld�z
---- Password : 123
---- Pozisyon : Boss
---- Fullname : Duru Y�ld�z
---- Salary   : 15000
---- CreatedDate : 2020.01.01

2) Visiual Studio da DentApexisWinUI �al��t�r�l�nca duru.y�ld�z 123 kullan�c� ad� ve �ifresi ile giri� yapt�ktan sonra personel kay�t sekmesine t�klay�p a��lan ekranda s�ras�yla personellerimizi ekliyoruz.
---- Duru Y�ld�z  - Doktor
---- Ay�e Y�lmaz  - Doktor
---- Fatma Solmaz - Doktor
---- Merve Durmaz - Personel
---- Ayta� Mutlu  - Muhasebe
NOT: Bu isimler AppUser olarak veritaban�na eklenmi� olacak(her biri  i�in �ifre 123)

3) Bu i�lemler tamamland�ktan sonra;

---- merve.durmaz username'i ile hasta kay�t ve randevu i�lemlerini,
---- duru.y�ld�z, ay�e.y�lmaz, fatma.solmaz username'leri ile tedavi planlama i�lemlerini yapabilir,username e ait randevular� takip edebilirsiniz.
---- ayta�.mutlu username'i ile muhasebe i�lemlerini,planlanan tedavilerin Hasta �deme i�lemlerini, ayl�k mali durumu g�rebilirsiniz
---- duru.y�lmaz username'i ile otomasyonda s�n�rlama olmadan t�m sayfalar� g�r�nt�leyebilirsiniz.

NOT: Doktor taraf�ndan planlanan tedavilerin �cretini muhasebe g�revlisi tahsilat� yapt�ktan sonra onaylar ve doktor �demesini yapan hastan�n tedavi s�recini ba�lat�r.

