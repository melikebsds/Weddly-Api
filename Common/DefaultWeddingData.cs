namespace WeddingPlanner.Api.Common;

/// <summary>
/// Bölüm 12-13: Yeni bir WeddingSpace oluşturulduğunda otomatik eklenen
/// varsayılan kategoriler ve örnek görevler. Kullanıcı bunları tamamen
/// özelleştirebilir (düzenleyebilir, silebilir, yeni ekleyebilir).
/// </summary>
public static class DefaultWeddingData
{
    public static readonly (string Name, int Order)[] Categories =
    {
        ("Çeyiz", 0),
        ("Ev İhtiyaçları", 1),
        ("Kız İsteme", 2),
        ("Söz", 3),
        ("Nişan", 4),
        ("Bohça", 5),
        ("Kına", 6),
        ("Düğün", 7),
        ("Balayı", 8),
        ("Resmi İşlemler", 9),
    };

    public static readonly (string CategoryName, string Title, decimal EstimatedPrice)[] SampleTasks =
    {
        // Çeyiz
        ("Çeyiz", "Yemek Takımı", 8000m),
        ("Çeyiz", "Kahvaltı Takımı", 3500m),
        ("Çeyiz", "Tencere Seti", 12000m),
        ("Çeyiz", "Çatal Kaşık Seti", 2500m),
        ("Çeyiz", "Bıçak Seti", 1500m),
        ("Çeyiz", "Nevresim Takımı", 2800m),
        ("Çeyiz", "Havlu Seti", 1200m),

        // Ev İhtiyaçları
        ("Ev İhtiyaçları", "Buzdolabı", 35000m),
        ("Ev İhtiyaçları", "Çamaşır Makinesi", 18000m),
        ("Ev İhtiyaçları", "Bulaşık Makinesi", 16000m),
        ("Ev İhtiyaçları", "Fırın", 12000m),
        ("Ev İhtiyaçları", "Koltuk Takımı", 45000m),
        ("Ev İhtiyaçları", "Yatak Odası Takımı", 30000m),
        ("Ev İhtiyaçları", "Televizyon", 15000m),

        // Kız İsteme
        ("Kız İsteme", "Çikolata / Şeker", 800m),
        ("Kız İsteme", "Çiçek", 500m),
        ("Kız İsteme", "Kıyafet", 3000m),
        ("Kız İsteme", "Tarih ve Aile Görüşmesi Organizasyonu", 0m),

        // Söz
        ("Söz", "Söz Yüzükleri", 5000m),
        ("Söz", "Davetli Listesi", 0m),
        ("Söz", "Mekan / Ev Organizasyonu", 3000m),
        ("Söz", "Kıyafet", 2500m),
        ("Söz", "Fotoğraf Çekimi", 2000m),

        // Nişan
        ("Nişan", "Nişan Yüzükleri", 15000m),
        ("Nişan", "Salon / Mekan", 40000m),
        ("Nişan", "Davetiyeler", 1500m),
        ("Nişan", "Gelinlik/Kıyafet", 8000m),
        ("Nişan", "Fotoğraf ve Video Çekimi", 10000m),
        ("Nişan", "Orkestra / DJ", 8000m),
        ("Nişan", "Pasta", 2000m),

        // Bohça
        ("Bohça", "Kına Gecesi Kıyafetleri", 3000m),
        ("Bohça", "Takı", 4000m),
        ("Bohça", "Tatlı / Lokum", 1500m),
        ("Bohça", "Pijama / Havlu Seti", 1200m),

        // Kına
        ("Kına", "Kına Gecesi Kıyafeti", 3500m),
        ("Kına", "Mekan / Organizasyon", 25000m),
        ("Kına", "Davetiyeler", 1000m),
        ("Kına", "Kına Tepsisi Süslemesi", 1500m),
        ("Kına", "Fotoğraf Çekimi", 3000m),
        ("Kına", "DJ / Müzik", 5000m),

        // Düğün
        ("Düğün", "Düğün Salonu", 150000m),
        ("Düğün", "Gelinlik", 15000m),
        ("Düğün", "Damatlık", 8000m),
        ("Düğün", "Fotoğraf ve Video Çekimi", 20000m),
        ("Düğün", "Davetiyeler", 3000m),
        ("Düğün", "Pasta", 5000m),
        ("Düğün", "Orkestra / DJ", 15000m),
        ("Düğün", "Gelin Arabası", 5000m),
        ("Düğün", "Nikah Şekeri", 2000m),

        // Balayı
        ("Balayı", "Uçak Bileti", 15000m),
        ("Balayı", "Otel Rezervasyonu", 25000m),
        ("Balayı", "Pasaport / Vize İşlemleri", 2000m),
        ("Balayı", "Seyahat Sigortası", 1000m),
        ("Balayı", "Bagaj / Valiz", 2000m),

        // Resmi İşlemler
        ("Resmi İşlemler", "Nikah Dairesi Randevusu", 0m),
        ("Resmi İşlemler", "Sağlık Raporu", 500m),
        ("Resmi İşlemler", "Nüfus Cüzdanı İşlemleri", 0m),
        ("Resmi İşlemler", "Soyadı Değişikliği İşlemleri", 0m),
    };
}
