namespace WeddingPlanner.Api.Entities;

/// <summary>
/// Bir görevin/ürünün alım durumu. NotNeeded, ilerleme ve bütçe
/// hesaplamalarından tamamen hariç tutulur (sanki hiç eklenmemiş gibi).
/// </summary>
public enum WeddingTaskStatus
{
    ToBuy = 0,
    Bought = 1,
    NotNeeded = 2,
}
