# Çocuklar İçin Makine Öğrenmesi
![GitHub Logo](https://i.hizliresim.com/i5hhQh.jpg)

## Problem
Çocuklara makinenin nasıl öğrendiğini öğretmek başlı başına bir problem olmakla birlikte bu probleme çeşitli çözümler üretilmiştir. Çeşitli kurslar, web siteleri kurulmuştur ama bunlarda da Türkçe kaynak problemi vardır. Bu sorundan yola çıkarak çocuklara makine öğrenmesini temellerini aşılamak için bu programı geliştirdik.

## Kullanılan Teknolojiler
1. C#
2. Bunifu Framework

# Uygulama İçi Ekran Görüntüleri
![Ekran Görüntüsü 1](https://i.hizliresim.com/vFAh8h.png)
<p align="center">Açılış Ekranı</p>

![Ekran Görüntüsü 2](https://i.hizliresim.com/7ZOT4y.png)
<p align="center">Oyun Ekranı</p>

# Oyunların Çalışma Prensipleri
Oyunlarımız emülatör tabanlı olmakla birlikte sonuçlar bazı oyunlarda tamamen rastgele üretilirken bazı oyunlarda girilen veriye göre üretmektedir.

## Snap
### Eğitim Aşaması 
Her bir iskambil kartı için en düşük 1 en yüksek 18 olmak üzere resim yüklenmelidir. 
### Test Aşaması
Sonuç görüntülenmesi için yüklenen resmin isminin iskambil kartlarının isimleriyle aynı olması gerekmektedir. Örneğin **heart.jpg**, **club.png** vs. Böylece yüklenen resmin hangi karta ait olduğunu öğrenebilirsiniz. Bunun dışındaki tüm yüklenen resimlerde sonuç bulunmadı cevabı verecektir.

## Judge Book
### Eğitim Aşaması
4 adet kategori karşılamaktadır. İsmi **kitap.jpg** olan bir resim dosyası hazırlayıp istenilen kategoriye yüklenecektir. 
### Test Aşaması
**kitap.jpg** resmini yükleyerek resmin hangi kategoriye ait olduğunu öğrenbilirsiniz. **kitap.jpg** olarak yüklenmeyen her resim için sonuç gösterilmeyecektir.

## School Library
### Eğitim Aşaması
**Sayfa Sayısı**, **Satır Sayısı**, **Resim Adeti** rakamsal değer girilecektir. 
### Test Aşaması
Aynı rakamsal değerler kullanıcıyı karşılayacaktır girilen değerlere rastgele sonuç gösterilmektedir.

## Chatbot
### Eğitim Aşaması
Aslanla ilgili bilgi girdikten sonra **Cevaplar Ekle** butonuna tıklanırak eğitim aşaması tamamlanır. 
### Test Aşaması
Kelime girerek test aşamasında girdiğiniz kelimeleri görüntüleyebilirsiniz.

## Journey To School
### Eğitim Aşaması
**Yürüme**, **Araba**, **Bisiklet** kategorilerini gireceğiniz değerlerle yeteri kadar ettiğinizi düşündüğünüz de eğitim aşamasını tamamlamış oluyorsunuz. 
### Test Aşaması
Gireceğiniz değerlere tamamen rastgele sonuçları görüntüleyebiliyorsunuz.

## Titanic
### Eğitim Aşaması
**Hayatta Kalacak**, **Hayatta Kalmayacak** olarak ayırdığımız kategorilere her birine en az 2 değer girdikten sonra eğitim aşamasını geçebilirsiniz. 
### Test Aşaması
Gireceğiniz değerlere göre kişinin hayatta kalıp kalmayacağını görüntüleyebilirsiniz.

## Make Me Happy
### Eğitim Aşaması
**Olumlu** kategorisine ekleyeceğiniz her kelime +1 puan alarak, **Olumsuz** kategorisine ekleyeceğiniz her kelime ise -1 puan alarak sözlüğe eklenecektir. Örneğin olumlu kategorisine ekleyeceğiniz **çok** kelimesi +1 puan alarak sözlüğe eklenir ve aynı kelimeyi olumsuz kategorisine eklediğiniz ise o kelimenin puanı -1 düşürülecektir. Toplamda sözlükte tekil olarak 10 tane kelime olduğunda ise eğitme aşaması tamamlanmış olacaktır. 
### Test Aşaması
Gireceğiniz cümledeki kelimelere bakılarak cümlenin olumlu, olumsuz yada nötr olma durumu gösterilecektir.

## Locate Larry
### Eğitim Aşaması
Kategorilere yükleyeceğiniz resimlerle test aşamasını tamamlayabilirsiniz.
### Test Aşaması
Yükleyeceğiniz 5 adet resim ile birlikte yüklediğiniz resimlerde **Larry** olup olmadığı kontrol edilerek sonuçlar gösterilir.

## Rock Paper Scissors
### Eğitim Aşaması
3 adet kategoriye yükleyeceğiniz en az 1 en çok 18 tane resim ile eğitim aşamasını tamamlayabilirsiniz.
### Test Aşaması
Sonuç görüntülemek için yükleyeceğiniz resmin **rock.jpg**, **kağıt.png** gibi isimlere sahip olması gerekmektedir. Bu isimlere sahip olmayan resimler yüklediğinizde sonuç bulunamadı gösterilecektir.

## Face Lock
### Eğitim Aşaması
2 adet kategoriye yükleyeceğiniz en az 1 en çok 18 tane resim ile eğitim aşamasını tamamlayabilirsiniz.
### Test Aşaması
Sonuç görüntülemek için yükleyeceğiniz resmin **geçerli.jpg**, **invalid.png** gibi isimlere sahip olması gerekmektedir. Bu isimlere sahip olmayan resimler yüklediğinizde sonuç bulunamadı gösterilecektir.
