namespace WeddingPlanner.Api.Common;

/// <summary>
/// Bölüm 12-13: Yeni bir WeddingSpace oluşturulduğunda otomatik eklenen
/// varsayılan kategoriler ve örnek görevler. Kullanıcı bunları tamamen
/// özelleştirebilir (düzenleyebilir, silebilir, yeni ekleyebilir).
/// SubCategory, okunurluk için kategori içinde ikinci bir gruplama
/// seviyesi sağlar (örn. Çeyiz > Mutfak: Pişirme).
/// </summary>
public static class DefaultWeddingData
{
    public static readonly (string Name, int Order)[] Categories =
    {
        ("Çeyiz", 0),
        ("Ev İhtiyaçları", 1),
        ("Kız İsteme, Söz ve Nişan", 2),
        ("Bohça", 3),
        ("Kına", 4),
        ("Düğün", 5),
        ("Resmi İşlemler", 6),
        ("Evi Taşıma ve Yerleşme", 7),
        ("Balayı", 8),
    };

    public static readonly (string CategoryName, string? SubCategory, string Title, decimal EstimatedPrice)[] SampleTasks =
    {
        // Çeyiz — Mutfak: Pişirme
        ("Çeyiz", "Pişirme", "Tencere Seti", 12000m),
        ("Çeyiz", "Pişirme", "Düdüklü Tencere", 3000m),
        ("Çeyiz", "Pişirme", "Tava Seti", 1500m),
        ("Çeyiz", "Pişirme", "Sahan Seti", 800m),
        ("Çeyiz", "Pişirme", "Wok Tava", 700m),
        ("Çeyiz", "Pişirme", "Borcam Seti", 900m),
        ("Çeyiz", "Pişirme", "Fırın Tepsileri", 500m),
        ("Çeyiz", "Pişirme", "Kek Kalıbı", 300m),
        ("Çeyiz", "Pişirme", "Tart Kalıbı", 300m),
        ("Çeyiz", "Pişirme", "Muffin Kalıbı", 250m),
        ("Çeyiz", "Pişirme", "Güveç Kapları", 600m),

        // Çeyiz — Mutfak: Sofra
        ("Çeyiz", "Sofra", "Yemek Takımı", 8000m),
        ("Çeyiz", "Sofra", "Kahvaltı Takımı", 3500m),
        ("Çeyiz", "Sofra", "Çatal Kaşık Bıçak Seti", 2500m),
        ("Çeyiz", "Sofra", "Servis Kaşıkları", 400m),
        ("Çeyiz", "Sofra", "Servis Tabakları", 800m),
        ("Çeyiz", "Sofra", "Çerezlik", 300m),
        ("Çeyiz", "Sofra", "Salata Kasesi", 400m),
        ("Çeyiz", "Sofra", "Salata Servis Seti", 400m),
        ("Çeyiz", "Sofra", "Meşrubat Bardakları", 500m),
        ("Çeyiz", "Sofra", "Su Bardakları", 400m),
        ("Çeyiz", "Sofra", "Çay Bardağı Seti", 500m),
        ("Çeyiz", "Sofra", "Kahve Fincanı Seti", 600m),
        ("Çeyiz", "Sofra", "Kupa", 300m),
        ("Çeyiz", "Sofra", "Rakı / Bira / Şarap Kadehi", 700m),
        ("Çeyiz", "Sofra", "Shot Bardağı", 300m),
        ("Çeyiz", "Sofra", "Sürahi", 400m),
        ("Çeyiz", "Sofra", "Karaf", 500m),
        ("Çeyiz", "Sofra", "Tepsi", 400m),
        ("Çeyiz", "Sofra", "Kahvaltılık Kaseler", 400m),

        // Çeyiz — Mutfak: Mutfak Gereçleri
        ("Çeyiz", "Mutfak Gereçleri", "Mutfak Bıçak Seti", 1200m),
        ("Çeyiz", "Mutfak Gereçleri", "Kesme Tahtası", 400m),
        ("Çeyiz", "Mutfak Gereçleri", "Soyacak", 150m),
        ("Çeyiz", "Mutfak Gereçleri", "Rende", 150m),
        ("Çeyiz", "Mutfak Gereçleri", "Sarımsak Ezici", 150m),
        ("Çeyiz", "Mutfak Gereçleri", "Limon Sıkacağı", 150m),
        ("Çeyiz", "Mutfak Gereçleri", "Narenciye Sıkacağı", 250m),
        ("Çeyiz", "Mutfak Gereçleri", "Kevgir", 200m),
        ("Çeyiz", "Mutfak Gereçleri", "Süzgeç", 200m),
        ("Çeyiz", "Mutfak Gereçleri", "Maşa", 150m),
        ("Çeyiz", "Mutfak Gereçleri", "Spatula", 150m),
        ("Çeyiz", "Mutfak Gereçleri", "Kepçe", 150m),
        ("Çeyiz", "Mutfak Gereçleri", "Çırpıcı", 200m),
        ("Çeyiz", "Mutfak Gereçleri", "Ölçü Kabı", 200m),
        ("Çeyiz", "Mutfak Gereçleri", "Ölçü Kaşıkları", 150m),
        ("Çeyiz", "Mutfak Gereçleri", "Mutfak Makası", 200m),
        ("Çeyiz", "Mutfak Gereçleri", "Havan", 300m),
        ("Çeyiz", "Mutfak Gereçleri", "Şişe Açacağı", 100m),
        ("Çeyiz", "Mutfak Gereçleri", "Konserve Açacağı", 100m),
        ("Çeyiz", "Mutfak Gereçleri", "Tirbuşon", 200m),

        // Çeyiz — Mutfak: Saklama
        ("Çeyiz", "Saklama", "Saklama Kabı Seti", 1000m),
        ("Çeyiz", "Saklama", "Cam Saklama Kabı", 800m),
        ("Çeyiz", "Saklama", "Baharatlık Seti", 500m),
        ("Çeyiz", "Saklama", "Yağdanlık", 200m),
        ("Çeyiz", "Saklama", "Sirkelik", 200m),
        ("Çeyiz", "Saklama", "Ekmek Kutusu", 500m),
        ("Çeyiz", "Saklama", "Kurabiye Kavanozu", 400m),
        ("Çeyiz", "Saklama", "Bakliyat Kavanozları", 600m),
        ("Çeyiz", "Saklama", "Buzdolabı Düzenleyicileri", 500m),
        ("Çeyiz", "Saklama", "Streç Film", 100m),
        ("Çeyiz", "Saklama", "Alüminyum Folyo", 100m),
        ("Çeyiz", "Saklama", "Kilitli Poşet", 100m),

        // Çeyiz — Mutfak: Mutfak Tekstili
        ("Çeyiz", "Mutfak Tekstili", "Mutfak Havluları", 300m),
        ("Çeyiz", "Mutfak Tekstili", "Fırın Eldiveni", 200m),
        ("Çeyiz", "Mutfak Tekstili", "Fırın Önlüğü", 300m),
        ("Çeyiz", "Mutfak Tekstili", "Masa Örtüsü", 500m),
        ("Çeyiz", "Mutfak Tekstili", "Runner", 300m),
        ("Çeyiz", "Mutfak Tekstili", "Amerikan Servis", 400m),
        ("Çeyiz", "Mutfak Tekstili", "Peçeteler", 200m),

        // Çeyiz — Yatak Odası: Yatak
        ("Çeyiz", "Yatak", "Yatak", 20000m),
        ("Çeyiz", "Yatak", "Baza", 6000m),
        ("Çeyiz", "Yatak", "Başlık", 3000m),
        ("Çeyiz", "Yatak", "Yastık", 500m),
        ("Çeyiz", "Yatak", "Ortopedik Yastık", 1200m),
        ("Çeyiz", "Yatak", "Yorgan", 2000m),
        ("Çeyiz", "Yatak", "Yazlık Yorgan", 1500m),
        ("Çeyiz", "Yatak", "Battaniye", 800m),
        ("Çeyiz", "Yatak", "Alez", 500m),
        ("Çeyiz", "Yatak", "Yatak Koruyucu", 500m),

        // Çeyiz — Yatak Odası: Nevresim
        ("Çeyiz", "Nevresim", "Nevresim Takımı", 2800m),
        ("Çeyiz", "Nevresim", "Çarşaf", 600m),
        ("Çeyiz", "Nevresim", "Lastikli Çarşaf", 700m),
        ("Çeyiz", "Nevresim", "Yastık Kılıfı", 300m),
        ("Çeyiz", "Nevresim", "Pike", 1200m),
        ("Çeyiz", "Nevresim", "Yatak Örtüsü", 1500m),
        ("Çeyiz", "Nevresim", "Dekoratif Yastıklar", 500m),

        // Çeyiz — Yatak Odası: Düzen
        ("Çeyiz", "Düzen", "Elbise Askıları", 300m),
        ("Çeyiz", "Düzen", "Hurç", 800m),
        ("Çeyiz", "Düzen", "Çekmece Düzenleyicileri", 400m),
        ("Çeyiz", "Düzen", "Takı Organizeri", 500m),
        ("Çeyiz", "Düzen", "Ayakkabı Düzenleyici", 400m),
        ("Çeyiz", "Düzen", "Perde", 4000m),
        ("Çeyiz", "Düzen", "Halı", 8000m),

        // Çeyiz — Banyo
        ("Çeyiz", "Banyo", "Banyo Havlu Seti", 800m),
        ("Çeyiz", "Banyo", "El Havlusu", 300m),
        ("Çeyiz", "Banyo", "Yüz Havlusu", 300m),
        ("Çeyiz", "Banyo", "Ayak Havlusu", 300m),
        ("Çeyiz", "Banyo", "Bornoz", 900m),
        ("Çeyiz", "Banyo", "Ev Terliği", 400m),
        ("Çeyiz", "Banyo", "Banyo Paspası", 300m),
        ("Çeyiz", "Banyo", "Tuvalet Paspası", 200m),
        ("Çeyiz", "Banyo", "Duş Perdesi", 400m),
        ("Çeyiz", "Banyo", "Sabunluk", 150m),
        ("Çeyiz", "Banyo", "Diş Fırçalık", 150m),
        ("Çeyiz", "Banyo", "Şampuanlık", 200m),
        ("Çeyiz", "Banyo", "Çöp Kovası", 200m),
        ("Çeyiz", "Banyo", "Tuvalet Fırçası", 150m),
        ("Çeyiz", "Banyo", "Çamaşır Sepeti", 500m),
        ("Çeyiz", "Banyo", "Banyo Organizeri", 400m),
        ("Çeyiz", "Banyo", "Misafir Havluları", 400m),

        // Ev İhtiyaçları — Beyaz Eşya
        ("Ev İhtiyaçları", "Beyaz Eşya", "Buzdolabı", 35000m),
        ("Ev İhtiyaçları", "Beyaz Eşya", "Çamaşır Makinesi", 18000m),
        ("Ev İhtiyaçları", "Beyaz Eşya", "Bulaşık Makinesi", 16000m),
        ("Ev İhtiyaçları", "Beyaz Eşya", "Fırın ve Ocak", 12000m),
        ("Ev İhtiyaçları", "Beyaz Eşya", "Davlumbaz", 5000m),
        ("Ev İhtiyaçları", "Beyaz Eşya", "Televizyon", 15000m),
        ("Ev İhtiyaçları", "Beyaz Eşya", "Klima", 20000m),
        ("Ev İhtiyaçları", "Beyaz Eşya", "Kombi / Şofben", 15000m),

        // Ev İhtiyaçları — Küçük Ev Aletleri
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Mikrodalga Fırın", 4000m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Su Sebili", 2500m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Airfryer", 3500m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Robot Süpürge", 6000m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Dikey Süpürge", 2000m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Çay Makinesi", 1200m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Türk Kahvesi Makinesi", 800m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Filtre Kahve / Espresso Makinesi", 3000m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Kettle (Su Isıtıcısı)", 800m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Tost Makinesi", 1000m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Blender Seti", 1500m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Mikser", 1500m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Mutfak Robotu", 3000m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Buharlı Ütü", 1500m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Ütü Masası", 800m),
        ("Ev İhtiyaçları", "Küçük Ev Aletleri", "Saç Kurutma Makinesi", 800m),

        // Ev İhtiyaçları — Mobilya
        ("Ev İhtiyaçları", "Mobilya", "Koltuk Takımı", 45000m),
        ("Ev İhtiyaçları", "Mobilya", "TV Ünitesi", 6000m),
        ("Ev İhtiyaçları", "Mobilya", "Yemek Masası ve Sandalye Takımı", 15000m),
        ("Ev İhtiyaçları", "Mobilya", "Orta Sehpa", 3000m),
        ("Ev İhtiyaçları", "Mobilya", "Yatak Odası Takımı", 30000m),
        ("Ev İhtiyaçları", "Mobilya", "Gardırop", 12000m),
        ("Ev İhtiyaçları", "Mobilya", "Komodin", 3000m),
        ("Ev İhtiyaçları", "Mobilya", "Şifonyer", 7000m),
        ("Ev İhtiyaçları", "Mobilya", "Ayakkabılık", 2000m),
        ("Ev İhtiyaçları", "Mobilya", "Dresuar", 5000m),

        // Ev İhtiyaçları — Dekorasyon
        ("Ev İhtiyaçları", "Dekorasyon", "Halı", 5000m),
        ("Ev İhtiyaçları", "Dekorasyon", "Perde ve Tül", 4000m),
        ("Ev İhtiyaçları", "Dekorasyon", "Avize", 2500m),
        ("Ev İhtiyaçları", "Dekorasyon", "Lambader / Abajur", 1500m),
        ("Ev İhtiyaçları", "Dekorasyon", "Ayna / Duvar Dekorasyonu", 1500m),
        ("Ev İhtiyaçları", "Dekorasyon", "Dekoratif Objeler / Çiçek / Saksı", 1000m),

        // Ev İhtiyaçları — Temizlik
        ("Ev İhtiyaçları", "Temizlik", "Elektrikli Süpürge", 6000m),
        ("Ev İhtiyaçları", "Temizlik", "Mop ve Kova", 500m),
        ("Ev İhtiyaçları", "Temizlik", "Temizlik Seti (Cam Silme, Toz Bezi, Mikrofiber Bez)", 500m),
        ("Ev İhtiyaçları", "Temizlik", "Çamaşır Kurutmalık ve Mandal", 400m),
        ("Ev İhtiyaçları", "Temizlik", "Çamaşır Sepeti", 400m),
        ("Ev İhtiyaçları", "Temizlik", "Çöp Kovaları ve Çöp Poşetleri", 500m),
        ("Ev İhtiyaçları", "Temizlik", "Genel Temizlik Ürünleri", 800m),

        // Kız İsteme, Söz ve Nişan — Kız İsteme
        ("Kız İsteme, Söz ve Nişan", "Kız İsteme", "Tarih Belirleme ve Aileleri Bilgilendirme", 0m),
        ("Kız İsteme, Söz ve Nişan", "Kız İsteme", "Kıyafet Seçimi", 3000m),
        ("Kız İsteme, Söz ve Nişan", "Kız İsteme", "Ev Hazırlığı ve Misafir Listesi", 0m),
        ("Kız İsteme, Söz ve Nişan", "Kız İsteme", "İkram Hazırlığı (Tatlı, Çikolata, Lokum, Kurabiye)", 1000m),
        ("Kız İsteme, Söz ve Nişan", "Kız İsteme", "Türk Kahvesi Sunum Seti (Fincan, Tepsi)", 500m),
        ("Kız İsteme, Söz ve Nişan", "Kız İsteme", "Çiçek", 500m),
        ("Kız İsteme, Söz ve Nişan", "Kız İsteme", "Yüzükler ve Yüzük Tepsisi", 3000m),
        ("Kız İsteme, Söz ve Nişan", "Kız İsteme", "Anı Fotoğrafı Çekimi", 1500m),

        // Kız İsteme, Söz ve Nişan — Söz
        ("Kız İsteme, Söz ve Nişan", "Söz", "Mekan / Ev Organizasyonu ve Konsept", 3000m),
        ("Kız İsteme, Söz ve Nişan", "Söz", "Masa, Çiçek ve Dekorasyon", 1000m),
        ("Kız İsteme, Söz ve Nişan", "Söz", "Söz Yüzükleri", 5000m),
        ("Kız İsteme, Söz ve Nişan", "Söz", "Tepsi, Kurdele, Makas", 500m),
        ("Kız İsteme, Söz ve Nişan", "Söz", "Davetli Listesi", 0m),
        ("Kız İsteme, Söz ve Nişan", "Söz", "Kıyafet ve Ayakkabı", 2500m),
        ("Kız İsteme, Söz ve Nişan", "Söz", "Saç ve Makyaj", 1500m),
        ("Kız İsteme, Söz ve Nişan", "Söz", "Çikolata ve Pasta", 1500m),
        ("Kız İsteme, Söz ve Nişan", "Söz", "Fotoğraf / Video Çekimi", 2000m),
        ("Kız İsteme, Söz ve Nişan", "Söz", "Dijital Duyuru / Instagram Paylaşımı Tasarımı", 300m),

        // Kız İsteme, Söz ve Nişan — Nişan
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Mekan (Salon / Restoran / Ev)", 40000m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Organizasyon Firması, Konsept, Arka Fon", 5000m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Masa Düzeni, Sandalye ve Süsleme", 3000m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Nişan Yüzükleri", 15000m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Yüzük Tepsisi, Kurdele, Makas", 500m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Nişan Bohçası", 2000m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Gelinlik / Kıyafet, Ayakkabı, Takı, Çanta", 8000m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Saç ve Makyaj", 3000m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Davetli Listesi ve Masa Planı", 0m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Davetiyeler (Basılı + Dijital)", 1500m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Hediyelik / İkram / Pasta", 2000m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Fotoğraf ve Video Çekimi", 10000m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Drone Çekimi ve Albüm", 3000m),
        ("Kız İsteme, Söz ve Nişan", "Nişan", "Orkestra / DJ", 8000m),

        // Bohça — Gelin İçin
        ("Bohça", "Gelin İçin", "Pijama, Sabahlık, Gecelik", 1500m),
        ("Bohça", "Gelin İçin", "İç Çamaşırı, Çorap, Terlik, Bornoz, Havlu", 1500m),
        ("Bohça", "Gelin İçin", "Parfüm, Deodorant, Duş ve Cilt Bakım Ürünleri", 1500m),
        ("Bohça", "Gelin İçin", "Makyaj Ürünleri", 1500m),
        ("Bohça", "Gelin İçin", "Çanta, Cüzdan, Takı, Saat, Aksesuar", 3000m),
        ("Bohça", "Gelin İçin", "Seccade", 500m),

        // Bohça — Damat İçin
        ("Bohça", "Damat İçin", "Pijama, Sabahlık, Gecelik", 1500m),
        ("Bohça", "Damat İçin", "İç Çamaşırı, Çorap, Terlik, Bornoz, Havlu", 1500m),
        ("Bohça", "Damat İçin", "Parfüm, Deodorant, Tıraş Seti, Cilt Bakım Ürünleri", 1500m),
        ("Bohça", "Damat İçin", "Gömlek, Kravat, Kemer, Cüzdan, Saat, Ayakkabı", 3000m),
        ("Bohça", "Damat İçin", "Seccade", 500m),

        // Bohça — Genel
        ("Bohça", "Genel", "Kına Gecesi Kıyafetleri", 3000m),
        ("Bohça", "Genel", "Takı", 4000m),
        ("Bohça", "Genel", "Tatlı / Lokum", 1500m),
        ("Bohça", "Genel", "Bohça Süslemesi / Organizasyonu", 1000m),
        ("Bohça", "Genel", "Kişiye Özel Hediyeler", 1500m),

        // Kına
        ("Kına", "Mekan ve Organizasyon", "Kına Mekanı ve Organizasyon Firması", 25000m),
        ("Kına", "Mekan ve Organizasyon", "Konsept, Dekorasyon, Masa Süsleme, Sahne, Işıklandırma", 5000m),
        ("Kına", "Kıyafet ve Güzellik", "Kına Gecesi Kıyafeti (Bindallı / Kaftan)", 3500m),
        ("Kına", "Kıyafet ve Güzellik", "Kına Tacı ve Aksesuarları", 1000m),
        ("Kına", "Kıyafet ve Güzellik", "Saç ve Makyaj", 3000m),
        ("Kına", "Malzemeler", "Kına Malzemeleri (Kına, Tepsi, Sepet, Mum, Fular, Eldiven, Kese)", 800m),
        ("Kına", "Malzemeler", "Kına Tepsisi ve Dağıtmalık Süslemesi", 1500m),
        ("Kına", "Misafir", "Davetli Listesi ve Davetiyeler", 1000m),
        ("Kına", "Misafir", "Hediyelik, İkramlıklar, İçecekler, Pasta", 2000m),
        ("Kına", "Medya ve Müzik", "Fotoğraf Çekimi", 3000m),
        ("Kına", "Medya ve Müzik", "Müzik / DJ (Giriş, Çıkarma, Oyun Havası, Halay Listesi)", 5000m),

        // Düğün — Mekan ve Organizasyon
        ("Düğün", "Mekan ve Organizasyon", "Düğün Mekanı (Salon / Kır Düğünü / Otel / Restoran)", 150000m),
        ("Düğün", "Mekan ve Organizasyon", "Mekan Sözleşmesi, Kapora, Kalan Ödeme Takibi", 0m),
        ("Düğün", "Mekan ve Organizasyon", "Organizasyon Firması", 10000m),
        ("Düğün", "Mekan ve Organizasyon", "Masa Süslemesi, Sandalye Süslemesi, Gelin Masası", 5000m),
        ("Düğün", "Mekan ve Organizasyon", "Gelin Yolu, Sahne, Arka Fon, Çiçekler, Işıklandırma", 5000m),

        // Düğün — Müzik
        ("Düğün", "Müzik", "DJ / Orkestra", 15000m),
        ("Düğün", "Müzik", "İlk Dans, Giriş, Pasta ve Halay Müzikleri", 0m),

        // Düğün — Gelin
        ("Düğün", "Gelin", "Gelinlik ve Aksesuarları (Duvak, Takı, Çanta, Parfüm)", 15000m),
        ("Düğün", "Gelin", "Gelin Ayakkabısı ve Yedek Ayakkabı", 1500m),
        ("Düğün", "Gelin", "Gelin Saçı ve Makyajı, Manikür, Pedikür, Kaş, Cilt Bakımı", 4000m),

        // Düğün — Damat
        ("Düğün", "Damat", "Damatlık, Gömlek, Kravat / Papyon", 8000m),
        ("Düğün", "Damat", "Damat Ayakkabı, Kemer, Kol Düğmesi, Saat, Parfüm", 2000m),
        ("Düğün", "Damat", "Damat Saç ve Tıraşı", 500m),

        // Düğün — Davetli
        ("Düğün", "Davetli", "Davetli Listesi ve Masa Planı / Oturma Düzeni", 0m),
        ("Düğün", "Davetli", "Davetiye Tasarımı, Baskısı ve Dağıtımı", 3000m),

        // Düğün — Fotoğraf ve Video
        ("Düğün", "Fotoğraf ve Video", "Fotoğraf ve Video Çekimi", 20000m),
        ("Düğün", "Fotoğraf ve Video", "Drone Çekimi, Save the Date, Dış Çekim", 5000m),
        ("Düğün", "Fotoğraf ve Video", "Albüm Seçimi ve Video Klip", 3000m),
        ("Düğün", "Fotoğraf ve Video", "Canlı Yayın / Sosyal Medya Paylaşımı", 1000m),

        // Düğün — Pasta ve İkram
        ("Düğün", "Pasta ve İkram", "Düğün Pastası ve Pasta Tadımı", 5000m),
        ("Düğün", "Pasta ve İkram", "İkram Menüsü, Meşrubat, Kahve / Çay", 8000m),
        ("Düğün", "Pasta ve İkram", "Gelin Arabası / VIP Transfer", 5000m),

        // Düğün — Nikah
        ("Düğün", "Nikah", "Nikah Memuru, Tarih, Başvuru ve Gerekli Belgeler", 0m),
        ("Düğün", "Nikah", "Şahitler ve Nikah Şekeri", 2000m),
        ("Düğün", "Nikah", "Nikah Defteri", 500m),

        // Düğün — Çiçek ve Aksesuar
        ("Düğün", "Çiçek ve Aksesuar", "Gelin Buketi ve Damat Yaka Çiçeği", 2000m),
        ("Düğün", "Çiçek ve Aksesuar", "Nedime Çiçekleri", 1000m),
        ("Düğün", "Çiçek ve Aksesuar", "Gelin Tacı, Saç Aksesuarı, Duvak", 2000m),
        ("Düğün", "Çiçek ve Aksesuar", "Takılar", 5000m),
        ("Düğün", "Çiçek ve Aksesuar", "Alyans ve Alyans Kutusu", 10000m),

        // Düğün — Hediyelik
        ("Düğün", "Hediyelik", "Nikah Şekeri, Kolonya, Magnet, Mum (Hediyelik)", 2500m),
        ("Düğün", "Hediyelik", "Misafir Karşılama Hediyesi ve Özel Hediyelik", 2500m),

        // Düğün — 1 Ay Kala (Son Kontrol)
        ("Düğün", "1 Ay Kala", "Gelinlik / Damatlık Son Provası ve Kontrolü", 0m),
        ("Düğün", "1 Ay Kala", "Alyansları Teslim Al, Nikah Belgelerini Kontrol Et", 0m),
        ("Düğün", "1 Ay Kala", "Davetli Listesi ve Masa Düzenini Kesinleştir", 0m),
        ("Düğün", "1 Ay Kala", "Mekan, Organizasyon, Fotoğrafçı, DJ/Orkestra Teyidi", 0m),
        ("Düğün", "1 Ay Kala", "Kuaför ve Makyaj Randevusunu Teyit Et", 0m),
        ("Düğün", "1 Ay Kala", "Balayı Rezervasyonları, Uçuş ve Otel Kontrolü", 0m),
        ("Düğün", "1 Ay Kala", "Düğün Ödemelerini Kontrol Et", 0m),

        // Düğün — Düğün Haftası (7 / 3 / 1 Gün Kala)
        ("Düğün", "Düğün Haftası", "7 Gün Kala: Tüm Tedarikçileri (Mekan, Fotoğrafçı, Kuaför) Son Kez Teyit Et", 0m),
        ("Düğün", "Düğün Haftası", "7 Gün Kala: Damatlığı, Alyansları ve Balayı Bavuluna Hazırlığı Başlat", 0m),
        ("Düğün", "Düğün Haftası", "3 Gün Kala: Çanta, Aksesuar, Ayakkabı, Takı ve Belgeleri Hazırla", 0m),
        ("Düğün", "Düğün Haftası", "3 Gün Kala: Ödemeleri Son Kez Kontrol Et", 0m),
        ("Düğün", "Düğün Haftası", "1 Gün Kala: Telefon/Powerbank Şarjı, Son Hazırlıklar ve Sorumlu Ataması", 0m),

        // Düğün — Acil Çanta
        ("Düğün", "Acil Çanta", "Dikiş Seti, Ağrı Kesici, Yara Bandı, Mendil", 300m),
        ("Düğün", "Acil Çanta", "Deodorant, Parfüm, Pudra, Ruj, Saç Spreyi", 300m),
        ("Düğün", "Acil Çanta", "Yedek Çorap / Ayakkabı, Şarj Kablosu, Powerbank", 500m),
        ("Düğün", "Acil Çanta", "Su, Atıştırmalık, Güvenlik İğnesi, Leke Çıkarıcı", 100m),

        // Resmi İşlemler
        ("Resmi İşlemler", null, "Nikah Başvurusu ve Nikah Dairesi Randevusu", 0m),
        ("Resmi İşlemler", null, "Kimlik Kontrolü ve Fotoğraf", 0m),
        ("Resmi İşlemler", null, "Sağlık Raporu", 500m),
        ("Resmi İşlemler", null, "Şahitleri Belirleme", 0m),
        ("Resmi İşlemler", null, "Nikah Ücretini Ödeme", 0m),
        ("Resmi İşlemler", null, "Evlilik Sonrası Nüfus Cüzdanı İşlemleri", 0m),
        ("Resmi İşlemler", null, "Soyadı Değişikliği İşlemleri", 0m),
        ("Resmi İşlemler", null, "Adres Değişikliği", 0m),
        ("Resmi İşlemler", null, "Banka Bilgilerini Güncelleme / Ortak Hesap Açılışı", 0m),
        ("Resmi İşlemler", null, "Sigorta İşlemleri", 0m),
        ("Resmi İşlemler", null, "Gerekli Abonelikleri Düzenleme", 0m),
        ("Resmi İşlemler", null, "e-Devlet Evlilik Bildirimi Takibi", 0m),

        // Evi Taşıma ve Yerleşme
        ("Evi Taşıma ve Yerleşme", null, "Ev Temizliği / Derin Temizlik", 2000m),
        ("Evi Taşıma ve Yerleşme", null, "Mobilyaların ve Beyaz Eşyaların Teslim Alınması", 0m),
        ("Evi Taşıma ve Yerleşme", null, "İnternet Bağlatma", 500m),
        ("Evi Taşıma ve Yerleşme", null, "Elektrik, Su, Doğalgaz İşlemleri", 500m),
        ("Evi Taşıma ve Yerleşme", null, "Perdelerin Takılması ve Halıların Serilmesi", 0m),
        ("Evi Taşıma ve Yerleşme", null, "Mutfak, Gardırop, Banyo Yerleşimi", 0m),
        ("Evi Taşıma ve Yerleşme", null, "Temizlik Malzemelerinin Alınması", 500m),
        ("Evi Taşıma ve Yerleşme", null, "İlk Market Alışverişi", 1500m),

        // Balayı — Planlama
        ("Balayı", "Planlama", "Balayı Destinasyonu Seçimi ve Tarih Belirleme", 0m),
        ("Balayı", "Planlama", "Uçak Bileti", 15000m),
        ("Balayı", "Planlama", "Otel Rezervasyonu ve Transfer", 25000m),
        ("Balayı", "Planlama", "Pasaport / Vize İşlemleri", 2000m),
        ("Balayı", "Planlama", "Seyahat Sigortası", 1000m),
        ("Balayı", "Planlama", "Gezi Planı, Aktiviteler ve Özel Sürprizler (Spa, Tekne Turu)", 5000m),

        // Balayı — Bavul ve Kişisel Bakım
        ("Balayı", "Bavul ve Kişisel Bakım", "Bavul Hazırlığı (Kıyafet, Mayo, İç Çamaşırı, Pijama, Terlik)", 3000m),
        ("Balayı", "Bavul ve Kişisel Bakım", "Kişisel Bakım Ürünleri (Diş Fırçası, Şampuan, Güneş Kremi, Makyaj)", 1000m),

        // Balayı — Teknoloji
        ("Balayı", "Teknoloji", "Teknoloji (Şarj Kablosu, Powerbank, Kamera, Adaptör)", 1500m),
        ("Balayı", "Teknoloji", "Yurt Dışı Hat / eSIM", 500m),
    };
}
