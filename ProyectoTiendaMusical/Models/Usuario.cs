namespace ProyectoTiendaMusical.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int Rol { get; set; }
        public string NombreCompleto { get; set; }
        public String Password { get; set; }
        public String NombreUsuario { get; set; }
        public String? Correo { get; set; }
        public int Estado { get; set; }
    }
}
