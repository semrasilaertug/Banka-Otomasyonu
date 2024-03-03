1. Yeni Müşteri Ekleme; Banka işlemlerini yapacak müşterilerin sisteme eklenmesi işlemi 
yapılacaktır. Aynı müşteri numarası başka müşteriler tarafından kullanılamayacaktır. Ayrıca farklı 
ayrıcalıklara sahip olan 2 tip müşteri bulunmaktadır. Müşteriler; ticari müşteri, bireysel müşteri 
olabilmektedir.  
2. Hesap Açtırma; 
• Bir müşterinin birden fazla hesabı olabilir. 
• Her hesabı için ayrı ayrı hesap numarası verilmesi gerekir. Aynı hesap numarası birden 
fazla müşteriye verilmemelidir.  
3. Para Çekme; Müşteri, para çekecekse ilgili bilgiler girilip çekilen tutar kadar bakiyesinden 
bakiyesi yetmiyorsa ek hesabını kullanarak para çekme işlemi gerçekleşecektir. Günlük maksimum 
para çekme limiti 750 tl dir. Daha fazla para çekilmek istendiği takdirde işlem gerçekleşmeyecektir. 
4. Para Yatırma; Müşteri, para yatıracaksa ilgili bilgiler girilip yatırılan tutar kadar bakiyesi 
artacaktır. 
5. Hesaba Havale; Müşteri, havale yapacaksa; havale yapacağı kişinin hesabının kayıtlı olması 
gerekmektedir. Ardından havale tutarı kadar miktar kendi hesabının bakiyesinden eksilecek, 
gönderdiği kişinin bakiyesi artacaktır. Ayrıca Ticari Müşterilerden havale ücreti kesilmez iken, 
Bireysel Müşterilerden gönderilecek tutarın %2 oranında havale ücreti kesilmektedir. 
6. Banka Gelir-Gider Raporu;  Bankanın gelir-giderleri(bankadan giden, gelen ve bankada bulunan 
toplam para miktarı vb.) hesaplanıp görüntülenecektir. Raporlama için grid bileşeni kullanmanız 
beklenmektedir. 
7. Hesap Özeti; Seçilen bir hesap için belirtilen tarih aralığında hesap özeti görüntülenecektir. 
Çekilen, yatırılan, havale yapılmışsa kime yapıldığı ve miktarı, başka bir hesaptan havale para 
geldiyse kimden geldiği ve miktarı gibi bilgiler ve bu işlemlerin tarihleri görüntülenmelidir. 
8. Hesap Kapama; İstenilen hesap kapatılabilecektir. Kapama işlemi için hesap bakiyesi 0 olması 
gerekmektedir.

Geliştirdiğimiz banka otomasyonunda müşteri ve personel olmak üzere 
iki tip kullanıcı bulunuyor.

Personel kullanıcı adı ="admin" , şifre = "1234"

Personel giriş yaparak müşteri ekleyebilir.
Eklediği müşterinin numarasını seçerek de hesap ekleyebilir.
Kayıtlı olan tüm müşteri ve hesapları listeleyebilir. 
İstenilen müşteriyi veya hesabı gerekli şartlar sağlanıyorsa silebilir.
Bankanın gelir-gider raporunu görüntüleyebilir. Ve çıkış yapabilir.


Müşteri kendisine verilen müşteri numarası ve şifre ile giriş yaparak;
para yatırma, para çekme, havale yapma , hesap özeti görüntüleme gibi 
işlemleri gerçekleştirebilir.

Windows Form uygulamasıdır.
