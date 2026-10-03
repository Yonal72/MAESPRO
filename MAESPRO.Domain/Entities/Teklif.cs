namespace MAESPRO.Domain.Entities;

public class Teklif:BaseEntity
{
    public string TeklifNo { get; set; } = string.Empty;
    public decimal HesaplananFiyat { get; set; }
    public decimal VerilenFiyat { get; set; }
    public ParaBirimi ParaBirimi { get; set; } = ParaBirimi.TL;
    public string? ExcelFilePath { get; set; }
    public string? ExcelFileName { get; set; }
    public string? Aciklama { get; set; }

    public Guid ParcaId { get; set; }
    public Parca Parca { get; set; } = null!;
    
}