namespace WeddingPlanner.Api.Common;

/// <summary>
/// Bölüm 12-13: Yeni bir WeddingSpace oluşturulduğunda otomatik eklenen
/// varsayılan kategoriler ve örnek görevler.
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
        ("Çeyiz", "Yemek Takımı", 8000m),
        ("Çeyiz", "Kahvaltı Takımı", 3500m),
        ("Çeyiz", "Tencere Seti", 12000m),
        ("Çeyiz", "Çatal Kaşık Seti", 2500m),
        ("Çeyiz", "Bıçak Seti", 1500m),
        ("Çeyiz", "Nevresim Takımı", 2800m),
        ("Çeyiz", "Havlu Seti", 1200m),
    };
}
