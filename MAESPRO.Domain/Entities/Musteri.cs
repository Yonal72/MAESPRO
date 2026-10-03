namespace MAESPRO.Domain.Entities;

public class Musteri:BaseEntity
{
    public string Code { get; set; } = string.Empty;
    public string MusteriAdi { get; set; } = string.Empty;
    public MusteriTipi MusteriTipi { get; set; } = MusteriTipi.AdayMusteri;
    public string? VergiNo { get; set; }
    public string? VergiDairesi { get; set; }
    public string? IlgiliKisi { get; set; }
    public string? Email { get; set; }
    public string? Telefon { get; set; }
    public string? Adres { get; set; }
    public string? Aciklama { get; set; }
    
    public ICollection<Parca> Parcalar { get; set; } = new List<Parca>();
}