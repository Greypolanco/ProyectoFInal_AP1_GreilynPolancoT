public class Compras
{
    [Key]
    public int CompraId { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Today;
    
    public string Concepto { get; set; } = string.Empty;
    [ForeignKey("CompraId")]
    public virtual List<CompraDetalles> CompraDetalles { get; set; } = new List<CompraDetalles>();
    public int ProveedorId { get; set; }
    
}