
public class Proveedores
{
    [Key]
    public int ProveedorId { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Today;
    [Required (ErrorMessage ="Nombre del Proveedor es requerido")]
    public string Nombre { get; set; }= string.Empty;
     [Required (ErrorMessage ="Empresa del Proveedor es requerida")]
    public string Empresa { get; set; } = string.Empty;

    [Required (ErrorMessage ="La RNC de la empresa es requerida")]
    [StringLength(8,MinimumLength =8, ErrorMessage ="El RNC es requerido 8 digitos")]
    public string RNC { get; set; } = string.Empty;
}