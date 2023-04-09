public class CompraDetalles
{
    [Key]
    public int CompraDetalleId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
}