namespace ProyectoTiendaMusical.Models
{
    public class CarritoCompras
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
        public int CantidadXProducto { get; set; }
        public double PrecioProductoUnitario { get; set; }
        public String RutaImagenProducto { get; set; }
        public String MarcaProducto { get; set; }
        public double MontoDescuentoXProducto { get; set; }
        public int Estado { get; set; }
    }
}
