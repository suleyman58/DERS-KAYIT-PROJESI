# DERS KAYIT PROJESI
 Katmanlı mimari kullanarak ders kayıt projesi oluşturdum.İçerisinde siteye kayıt,siteye giriş,ders ve öğrenci kayıdı oluşturma gibi işlemler yapılabiliyor.
Projenin çalışabilmesi için MİCROSOFT SQL SERVER ile yeniden bağlamalısınız,SQL içerisinde aşağıdaki isim ve kolonlarda tablolar oluşturmalısınız.
Tablolar proje içerisinde yazdığından tablo adlarını değiştirdiğiniz taktirde kod çalışmaz ya tablo adını aynı yazın yada kendi tablo adlarınızı kod içerisinden güncelleyin.

 TABLO ADI                                    KOLONLAR
tblbasvuruformu                    basvuruID,ogrenciID,dersID
tblogrenci                         ogrID,ograd,ogrsoyad,ogrnumara,ogrfoto,ogrbakiye
tblogrencikayitlari                ogrno,ogrsifre
tbldersler                         dersID,dersad,dersminkontenjan,dersmaxkontenjan
tblogretmen                        ogrtID,ogrtadsoyad,ogrtbrans




Kullanıcı girişi için kullanılan şifre kolonunun şifreleme algoritması SHA256 algoritmasıdır. 
Sitenin doğru kullanılması için ilk açılması gereken sayfa SİTEanasayfa.aspx dir.
