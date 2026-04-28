# ECommerceApp Vize Projesi

Bu proje, C# ile geliştirilmiş basit bir e-ticaret uygulamasıdır. 
Projede kullanıcı ürün seçebilir, sepete ürün ekleyebilir, sipariş verebilir ve ödeme işlemi yapabilir.

Projenin amacı, yazılım test türlerini uygulamalı olarak göstermektir. 
Bu yüzden sistemin içine bilinçli olarak bazı hatalar eklenmiştir. 
Bu hatalar NUnit testleri ile yakalanmaktadır.

# Projenin Senaryosu

Bir e-ticaret sisteminde kullanıcı ürünleri sepete ekler, sepet toplamını görür, sipariş verir ve ödeme yapar. 
Sistem temel olarak ürün, sepet, sipariş ve ödeme sınıflarından oluşmaktadır.

Bilerek Bırakılan Hatalar

Projede testlerin yakalaması için bazı hatalar bilerek bırakılmıştır:

Stokta olmayan ürün sepete eklenebiliyor.
Sepette olmayan ürün silinmek istendiğinde hata fırlatılmıyor.
Sepet toplamı hesaplanırken toplam tutara fazladan 10 TL ekleniyor.
Negatif ödeme tutarı sistem tarafından kabul ediliyor.
Boş sepetle sipariş verilebiliyor.
Test Türleri

Projede dört farklı test türü kullanılmıştır:

1. Unit Test / White Box Test

Kodun iç yapısı bilinerek yapılan testlerdir. Bu projede özellikle Cart sınıfının metotları test edilmiştir.

2. Black Box Test

Kodun iç yapısına bakmadan, sadece giriş ve beklenen çıkışlara göre yapılan testlerdir. 
Örneğin stokta olmayan ürünün sepete eklenmemesi gerektiği test edilmiştir.

3. Gray Box Test

Hem sistem davranışı hem de kısmen iç yapı bilinerek yapılan testlerdir. 
Bu projede sipariş ve ödeme akışları gray box test olarak ele alınmıştır.

4. Integration Test

Birden fazla sınıfın birlikte doğru çalışıp çalışmadığını kontrol eden testlerdir. B
u projede Cart, OrderService ve PaymentService birlikte test edilmiştir.


# Test Sonucu

Testler dotnet test komutu ile çalıştırılmıştır.

Son test sonucunda:

Toplam Test: 12
Başarılı Test: 6
Başarısız Test: 6
Atlanan Test: 0

Başarısız olan testler, projeye bilinçli olarak eklenen hataları başarıyla yakalamıştır.

# Sonuç

Bu projede basit bir e-ticaret sistemi üzerinden farklı test türleri uygulanmıştır. 
Unit Test, Black Box Test, Gray Box Test ve Integration Test örnekleri yazılmıştır. 
Sisteme bilerek eklenen hatalar testler sayesinde tespit edilmiştir. 
Bu sayede test yazmanın yazılım geliştirme sürecindeki önemi gösterilmiştir.
