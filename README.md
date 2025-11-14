# 🛍️ MULTISHOP MIKROSERVIS PROJESİ – .NET Core 6.0

## 🔎 GENEL BAKIŞ
**MultiShop**, mikroservis mimarisi ile geliştirilmiş modern, güvenli ve ölçeklenebilir bir e-ticaret platformudur.
Proje, kullanıcıların ürünleri görüntüleyip inceleyebildiği, sepete ekleme yapabildiği, aynı zamanda yöneticilerin ürün, kategori ve kampanya yönetimi yapabildiği uçtan uca bir e-ticaret sistemidir.

Docker altyapısı sayesinde servisler bağımsız şekilde ayağa kalkabilir, taşınabilir ve kolayca ölçeklenebilir.
Projede hem **kullanıcı (User)** hem de **yönetici (Admin)** panelleri bulunmaktadır.

---

## 🚀 ÖZELLİKLER

### 👥 KULLANICI ARAYÜZÜ
- Ürünleri kategori bazlı listeleme  
- Ürün detaylarını görüntüleme
- Ürün yorumlarını görüntüleme 
- Ürünlere yorum ekleme ve puan verme  
- Sepete ürün ekleme / çıkarma
- Sepet detaylarını görüntüleme
- Kupon kodu ile indirim uygulama  
- Sepeti onaylama ve kart işlemleri
- Kayıt olma ve giriş yapma (Login/Register)  
- Giriş yapmadan sepete erişim engeli  
- İletişim formu üzerinden mesaj gönderme  
- Sipariş geçmişini görüntüleme

### 🛠️ ADMİN PANELİ
- Ürün, kategori, marka, kargo şirketi yönetimi (CRUD işlemleri)  
- Slider, özel teklifler ve öne çıkan ürün, hakkımda alanları yönetimi
- Kullanıcı listesi görüntüleme
- Tüm yorumların görüntülenmesi
- İstatistiklerin görüntülenmesi  
- Gelen/giden mesajların yönetimi
- Giriş yapmadan bu panele erişim engeli

### 👤 KULLANICI PANELİ
- Kayıt olma ve giriş yapma (Login/Register)
- Sipariş geçmişini görüntüleme
- Gelen/giden mesajları görüntüleme
- Giriş yapmadan bu panele erişim engeli  

---

## 🧩 GENEL SİSTEM ÖZELLİKLERİ
- **Mikroservis mimarisi** ile bağımsız servis yapısı  
- **Ocelot API Gateway** ile merkezi servis yönlendirme  
- **IdentityServer4** ve **JWT** ile güvenli kimlik doğrulama  
- **RabbitMQ** ile asenkron mesajlaşma  
- **SignalR** ile gerçek zamanlı bildirimler  
- **Google Cloud Storage** ile bulut tabanlı dosya yönetimi
- **DBeaver** ile veritabanlarını tek noktadan yönetme
- Çoklu veritabanı desteği: **MSSQL, PostgreSQL, MongoDB, Redis**  

---

## 🧱 MİMARİ YAPI
Proje, modern yazılım geliştirme prensiplerine uygun olarak **Onion Architecture** ve **N-Tier Architecture** yapısında tasarlanmıştır.  
Bu sayede her servis kendi bağımsız yaşam döngüsüne sahiptir ve sistemin ölçeklenebilirliği maksimum düzeyde tutulmuştur.

### 🔹 KULLANILAN TASARIM DESENLERİ
- **CQRS Pattern** – Komut ve sorguların ayrıştırılması  
- **Mediator Design Pattern** – Modüller arası gevşek bağlılık  
- **Repository Pattern** – Veri erişim katmanının soyutlanması  

---

## 🔒 Güvenlik

* Kimlik doğrulama: IdentityServer4
* Yetkilendirme: JWT (JSON Web Token)
* API güvenliği: Token bazlı erişim kontrolü
* Giriş yapılmadan belirli sayfalara erişim engeli

---

## ⚙️ KULLANILAN TEKNOLOJİLER

| Alan | Teknolojiler |
|------|---------------|
| **Backend** | ASP.NET Core 6.0 Web API |
| **Frontend** | ASP.NET Core MVC, HTML, CSS, JavaScript, Bootstrap |
| **Veritabanları** | MSSQL, PostgreSQL, MongoDB, Redis |
| **ORM / Data Access** | Entity Framework Core, Dapper |
| **API Test & Dökümantasyon** | Swagger, Postman |
| **Mesajlaşma & Queue** | RabbitMQ |
| **E-Mail Servisi** | MailKit |
| **Veritabanı Yönetimi** | DBeaver |
| **Containerization** | Docker |
| **Gateway Yönetimi** | Ocelot API Gateway |
| **Gerçek Zamanlı İletişim** | SignalR |
| **Kimlik Doğrulama** | IdentityServer4, JWT |
| **Bulut Entegrasyonu** | Google Cloud Storage |
| **Doğrulama & Validasyon** | FluentValidation |
| **API Tüketimi** | RapidAPI |

---

## 🧠 PROJE MODÜLLERİ

| SERVİS ADI           | AÇIKLAMA                                                         |
| -------------------- | ---------------------------------------------------------------- |
| **Catalog Service**  | Ürün, marka, kategori, iletişim ve görsel yönetimi — **MongoDB** |
| **Basket Service**   | Sepet işlemleri — **Redis**                                      |
| **Cargo Service**    | Kargo işlemleri — **SQL Server**                                 |
| **Comment Service**  | Yorum işlemleri — **SQL Server**                                 |
| **Discount Service** | Kampanya ve indirim kodu yönetimi — **SQL Server**               |
| **Order Service**    | Sipariş oluşturma ve geçmiş yönetimi — **SQL Server**            |
| **Message Service**  | Kullanıcı mesajları ve iletişim — **PostgreSQL**                 |
| **Identity Service** | Login/Register, kimlik doğrulama — **SQL Server**                |
| **Images Service**   | Görsel işlemleri — **Google Cloud Storage**                      |
| **Ocelot Gateway**   | Servis yönlendirme ve merkezi kontrol                            |
| **WebUI**            | Kullanıcı ve Admin arayüzleri                                    |


## 📸  PROJE EKRAN GÖRÜNTÜLERİ

---
## 🖥️ Kullanıcı Arayüzü
### Ana Sayfa
![DefaultIndex](https://github.com/user-attachments/assets/323712e3-cd34-4c22-b620-3a890e7a9a91)
### Ürün Detay
![ProductDetail](https://github.com/user-attachments/assets/5b3376dd-210a-4161-b31f-e0adabd3511c)
### Kategoriye Ait Ürünler
![ProductListCategory](https://github.com/user-attachments/assets/e49ee11c-c82d-43e7-ab0d-1c564c4f5b97)
### Sepet Ekranı
![Shopping](https://github.com/user-attachments/assets/71bac9a3-9f3c-4631-b869-f5369a4ed592)
### Sipariş Ekranı
![Order](https://github.com/user-attachments/assets/5c51f208-ec08-4e2b-9f0c-46e0e014da0b)
### Ödeme Ekranı
![Payment](https://github.com/user-attachments/assets/28d947f3-ee18-4b03-a317-1e54d14057f1)

### İletişim
![Contact](https://github.com/user-attachments/assets/ee1fcc15-609d-4c23-95a0-2aa5d98d1bba)

### Giriş & Kayıt
<img width="1288" height="481" alt="Login" src="https://github.com/user-attachments/assets/97b59092-4629-4ec8-bd53-35f1fc39c224" />
<img width="1291" height="699" alt="Register" src="https://github.com/user-attachments/assets/a32d7684-e184-4f73-ba96-e0d2233c690b" />



---

## 🛠️ Admin Paneli
### Kategoriler
<img width="1456" height="953" alt="AdminCategory" src="https://github.com/user-attachments/assets/a9287d4a-08d6-4504-a40e-6f7a88316427" />

### Ürünler
<img width="1288" height="940" alt="AdminProduct" src="https://github.com/user-attachments/assets/070932bb-c51c-4362-b37b-f3a2944c6d98" />

### Ürün Güncelleme sayfası
![AdminUpdateProduct](https://github.com/user-attachments/assets/f12d9f09-8463-498e-8259-3e9c5553131d)

### Ürün Görsel İşlemleri
<img width="1286" height="552" alt="AdminProductImages" src="https://github.com/user-attachments/assets/63010407-8426-4859-97e7-c52bba5b01fe" />

### Ürün Açıklama ve Bilgi İşlemleri
<img width="1285" height="576" alt="AdminProductDetail" src="https://github.com/user-attachments/assets/ec130ec3-c199-4186-8387-50289aaebc59" />

### Özel Teklifler
<img width="1282" height="365" alt="AdminSpecialOffer" src="https://github.com/user-attachments/assets/def0957b-d642-41a6-aa2b-a7b7a7340992" />

### İndirim Teklifleri
<img width="1287" height="368" alt="AdminOfferDiscount" src="https://github.com/user-attachments/assets/dc8f6aca-86cc-4bf0-81dc-9037253c7ee0" />

### Slider Paneli
<img width="1276" height="489" alt="AdminSlider" src="https://github.com/user-attachments/assets/96a0d5a5-1b60-4cf5-9441-ecbadaa6c569" />

### Öne Çıkan Alan Paneli
<img width="1286" height="487" alt="AdminFeature" src="https://github.com/user-attachments/assets/2ae7ed64-2c59-4f65-8c68-58b760633599" />

### Markalar
![AdminBrand](https://github.com/user-attachments/assets/0c1803df-8359-44e9-8197-5a7decf7b3b5)
### Hakkımda
<img width="1285" height="322" alt="AdminAbout" src="https://github.com/user-attachments/assets/9d08bf22-fa1e-436e-974b-fcf0d07c108a" />

### Yorumlar
<img width="1284" height="813" alt="AdminComment" src="https://github.com/user-attachments/assets/52dbee98-b6da-40e3-9fa4-99e6209d83d0" />

### Kullanıcı Listesi
<img width="1283" height="537" alt="AdminUserList" src="https://github.com/user-attachments/assets/28480556-78ef-4c63-bb79-b5ad5f1f2adc" />

### Kargo Firmaları
<img width="1281" height="399" alt="AdminCargoCompanyList" src="https://github.com/user-attachments/assets/5da57865-d3f5-419c-a38d-0c982292a91b" />

### İstatistikler
<img width="1460" height="474" alt="AdminStatistic" src="https://github.com/user-attachments/assets/66eb5240-4b6a-4fc3-98ab-d637ce6acee7" />

## 👤 Kullanıcı Paneli
### Gelen Mesajlar
![UserMessageInbox](https://github.com/user-attachments/assets/d2451af3-3cd4-49dc-8d2f-63384166a6ec)
### Gelen Mesaj Detay
<img width="1476" height="904" alt="UserMessageDetail" src="https://github.com/user-attachments/assets/63f3ba1b-4ac9-4ed9-b041-c79a9e316c7e" />

### Gönderilen Mesajlar
![UserMessageSendbox](https://github.com/user-attachments/assets/4b43921b-2280-4bfe-9f2a-4309ae231c37)

## 🚀 Docker
<img width="1554" height="693" alt="Docker" src="https://github.com/user-attachments/assets/4ae6d4da-add7-4295-8c38-50a0a3c1c965" />

## ⚙ MongoDb
<img width="1839" height="746" alt="MongoDb" src="https://github.com/user-attachments/assets/b5c55517-2ae7-46a4-b540-f29572fc441a" />

## ⚙️ Startup Yapılandırması
<img width="914" height="768" alt="StartupProject" src="https://github.com/user-attachments/assets/dba59e37-1fb9-4c1c-af40-83b1ac55a385" />
