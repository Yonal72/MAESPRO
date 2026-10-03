namespace MAESPRO.Domain.Entities;

public class Parca:BaseEntity
{
    public string ParcaNo { get; set; } = string.Empty;
    public string ParcaAdi { get; set; } = string.Empty;
    public string? SkechPath { get; set; }
    public ParcaTipi ParcaTipi { get; set; } = ParcaTipi.TeklifParcasi;

    public Guid MusteriId { get; set; }
    public Musteri Musteri { get; set; } = null!;

    public Guid TeklifId { get; set; }
    public Teklif Teklif { get; set; } = null!;
}
