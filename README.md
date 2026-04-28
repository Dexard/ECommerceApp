# ECommerceApp Vize Projesi

## 📌 Proje Tanımı

Bu proje, C# dili kullanılarak geliştirilmiş basit bir e-ticaret sistemidir. Kullanıcılar ürün seçebilir, sepete ekleyebilir, sipariş verebilir ve ödeme işlemi gerçekleştirebilir.

Projenin amacı, yazılım test türlerini (Unit, Black Box, Gray Box, Integration) uygulamalı olarak göstermek ve sistemde bulunan hataların testler ile nasıl yakalandığını göstermektir.

---

## 🛠 Kullanılan Teknolojiler

* C#
* .NET
* NUnit
* GitHub

---

## 📂 Proje Yapısı

```
ECommerceApp/
 ├── ECommerceApp/
 │   ├── Core/
 │   │   ├── Product.cs
 │   │   ├── Cart.cs
 │   │   ├── OrderService.cs
 │   │   └── PaymentService.cs
 │   └── Program.cs
 │
 ├── ECommerceApp.Tests/
 │   ├── UnitTests/
 │   ├── BlackBoxTests/
 │   ├── GrayBoxTests/
 │   └── IntegrationTests/
 │
 └── README.md
```

---

## 🧠 Sistem Senaryosu

Kullanıcı:

* Ürün seçer
* Sepete ekler
* Sipariş oluşturur
* Ödeme yapar

---

## ⚠️ Bilerek Bırakılan Hatalar

Projede testlerin yakalayabilmesi için bazı hatalar bilinçli olarak eklenmiştir:

1. Stokta olmayan ürün sepete eklenebiliyor.
2. Sepette olmayan ürün silinmek istendiğinde hata fırlatılmıyor.
3. Sepet toplamına fazladan 10 TL ekleniyor.
4. Negatif ödeme kabul ediliyor.
5. Boş sepet ile sipariş verilebiliyor.

---

## 🧪 Test Türleri

### 1. Unit Test (White Box)

Kodun iç yapısı bilinerek yapılan testlerdir.

### 2. Black Box Test

Kodun iç yapısı bilinmeden sadece giriş-çıkışlara göre yapılan testlerdir.

### 3. Gray Box Test

Hem sistem davranışı hem de kısmen iç yapı bilinerek yapılan testlerdir.

### 4. Integration Test

Birden fazla bileşenin birlikte çalışmasını test eder.

---

## 📊 Test Sonuçları

```
Toplam Test: 12
Başarılı: 6
Başarısız: 6
```

---

## ❌ Başarısız Testler ve Nedenleri

### 1. CalculateTotal_TwoProducts_ShouldReturnCorrectTotal

Toplam hesaplama metodunda fazladan 10 TL eklenmektedir.

### 2. AddProduct_OutOfStockProduct_ShouldNotBeAdded

Stok kontrolü yapılmadan ürün sepete eklenmektedir.

### 3. RemoveProduct_NotExistingProduct_ShouldThrowException

Sepette olmayan ürün silinmek istendiğinde hata fırlatılmamaktadır.

### 4. CalculateTotal_EmptyCart_ShouldReturnZero

Boş sepette toplam 0 olması gerekirken 10 dönmektedir.

### 5. PlaceOrder_EmptyCart_ShouldReturnFalse

Sepet boş olsa bile sipariş verilebilmektedir.

### 6. Payment_NegativeAmount_ShouldReturnFalse

Negatif ödeme tutarı kabul edilmektedir.

---

## ✅ Sonuç

Bu projede farklı test türleri uygulanmış ve sistemdeki hatalar testler sayesinde başarıyla tespit edilmiştir. Bu çalışma, yazılım geliştirme sürecinde test yazmanın önemini göstermektedir.

Başarısız olan testler, sistemde bilinçli olarak bırakılan hataları ortaya çıkarmaktadır.

---
