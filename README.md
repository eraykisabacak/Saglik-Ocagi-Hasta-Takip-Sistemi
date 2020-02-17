## [Demo](https://www.youtube.com/watch?v=ydSiWok7wN8&t=95s&ab_channel=ErayK%C4%B1sabacak)
## [Blog](http://eraykisabacak.com/c-ile-saglik-ocagi-hasta-takip-sistemi-health-center-patient-tracking-system-hbys/)
# Saglik-Ocagi-Hasta-Takip-Sistemi
Sağlık Ocağı Hasta Takip Sistemi - Health Center Patient Tracking System - HBYS

Sağlık Ocağı Hasta Takip Sistemi
Sağlık ocaklarında hastaların poliklinik giriş ve çıkışlarının takibi ve raporlanması amacıyla detaylı bir otomasyon geliştirmeniz istenmektedir.

## Kurulum
Projede Entity Framework kullanılmıştır. 
script.sql dosyasından Microsoft Management Studio'ya giderek New Query'ye tıkladıkdan sonra script.sql dosyasının içindeki kodu alıp Execute ettiğinizde tablolar ve veriler gelmiş olacaktır.

## Uygulama İçi Fotoğraflar

### Login
![](https://github.com/eraykisabacak/Saglik-Ocagi-Hasta-Takip-Sistemi/blob/master/login1.png)

### Login Uyarısı
![](https://github.com/eraykisabacak/Saglik-Ocagi-Hasta-Takip-Sistemi/blob/master/uyari2.png)

### Hasta İşlemleri
![](https://github.com/eraykisabacak/Saglik-Ocagi-Hasta-Takip-Sistemi/blob/master/hasta3.png)

### Taburcu Formu
![](https://github.com/eraykisabacak/Saglik-Ocagi-Hasta-Takip-Sistemi/blob/master/taburcu4.png)

### Taburcu Formu
![](https://github.com/eraykisabacak/Saglik-Ocagi-Hasta-Takip-Sistemi/blob/master/taburcu5.png)

### Poliklinik Tanıtma
![](https://github.com/eraykisabacak/Saglik-Ocagi-Hasta-Takip-Sistemi/blob/master/poliklinik6.png)

### Kullanıcı Tanıtma
![](https://github.com/eraykisabacak/Saglik-Ocagi-Hasta-Takip-Sistemi/blob/master/kullanici7.png)

### Hasta Bulma
![](https://github.com/eraykisabacak/Saglik-Ocagi-Hasta-Takip-Sistemi/blob/master/arabul8.png)

## Detaylı Bilgiler
txtDosyaNo: Hasta ya ait unique numara dosya no metin kutusunun key press eventi enter tuşunu döndürürse hasta bilgileri formdaki alanlara doldurulur.

btnBul: Dosya numarası bilinmeyen hasta geldiğinde bul butonu ile acılan Dosya Arama Yardımı penceresinde hastaya ait bilgiler den biri seçilip sorgulanarak hastanın dosya numarasına erişilir, Gridden seçilen hasta dosya numarası ve bütün bilgileri formda ilgili alanlara doldurulur.

txtSevkTarihi: Muayeneye gelen hasta için her gelişinde sevk açılmaz, Sevk tarihi ile dosya numarası birlikte hastanın bir kez gelişini birlikte primary key olarak ifade eder.

btnHastaBilgileri: Hastanın Gerekli bilgilerinin düzenlendiği bir form açar. Burada hastaya ait kişisel, kurumsal, kimlik ve iletişim bilgileri bulunur.

cbPoliklinik: hastanın o sevkinde hangi poliklinikte muayene olacağı seçilir.

txtSıraNo: Hastanın poliklinikte muayene için bekleyeceği sıra numarası otomatik olarak verilir.

txtKayitSaati: hasta kaydının yapıldığı saati sistem saatinden çekip bu alana yazdırılır.

btnKaydet: hastanın bu sevkini kaydeder ve bu sevke tahlil ve işlem girilebilir.
Groupbox Yapılan tahlil ve işlemler: bu groupbox içinde yer alan alanlar yapılan her bir işlem için doldurulup Ekle butonu ile alttaki gride eklenir. Dr. Kodu her bir doktorun sahip olduğu kod yazılır. Tarih ve saat sistemden çekilir.

btnKaydet: hastanın bu sevkini yapılan işlemler ile birlikte kaydeder (Gride eklenen kayıtlar direk veritabanına işlenirse bu butona gerek kalmayabilir).

btnSeçSil: Hastanın hesabında silinmek istenen işlem veya tahlil grid satır baslığından seçilerek bu buton ile silinir.

btnYeni: Formu temizleyerek yeni bir hastaya işlem yapabilmeye hazır hale getirir.

btnTaburcu: Hastanın gerekli işlemleri (Örneğin ücret tahsil edilmesi) bittikten sonra taburcu edilir. Yani veri tabanına çıkış saati yazılır.

btnYazdır: Hastanın bu sevkine ait bilgileri yazdırılır.

Toplam Tutar: Gridde hasta ya işlenen işlemlerin miktarları ve birim fiyatları çarpılarak işlem tutarı hanesinde görülecek, bu işlem tutarları toplamı toplam tutarda gösterilir,

Poliklinik Tanıtma: Sağlık ocağındaki polikliniklerin insert, update, delete edildiği form,
dbPoliklinik te burada kayıtlı ve geçerli poliklinikler görüntülenecek. Poliklinik adı girilip textbox üzerinde entere basıldığında kayıt varsa form doldurulur, yoksa böyle bir kayıt bulunamadı açayım mı diye msgbox uyarısı verir, evet seçilirse alttaki komponente geçer aksi halde formu temizler.

Kullanıcı tanıtma: Kullanıcı adı yazılıp enterlandıgında bilgileri gelir, yetkili kullanıcılar haricindekilere Referanslar ana menüsü görünmez.

Doktor tanıtma: kodu girildiğinde bilgiler gelir ya da mesajla bu kaydı açayım mı diye sorar, doktor kodları hasta işlemleri formunda işlem eklemede ve raporlarda imza olarak kullanılır.

Sağlık Personeli tanıtma: hemşireler vb. personel tanıtılır doktor tanıtmanın benzeri işlemler yapılır.
