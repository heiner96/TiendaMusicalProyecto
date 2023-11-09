namespace ProyectoTiendaMusical.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public double Precio { get; set; }
        public String Marca { get; set; }
        public double MontoDescuento { get; set; }
        public String RutaImage { get; set; }
        public int Estado { get; set; }

    }
}
