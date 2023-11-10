using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProyectoTiendaMusical.Models;

namespace ProyectoTiendaMusical.DataBaseContext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        public ApplicationDBContext()
        {

        }
        #region Productos
        public virtual DbSet<Producto> Productos { get; set; }
       
        public List<Producto> sp_GetAllProductos()
        {
            return Productos.FromSqlRaw("EXECUTE [dbo].[GetAllProductos]").ToList();
        }

        public int sp_InsertProducto(Producto pProducto)
        {
        SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@Id", pProducto.Id),
                new SqlParameter("@Nombre", pProducto.Nombre),
                new SqlParameter("@Descripcion", pProducto.Descripcion),
                new SqlParameter("@Precio", pProducto.Precio),
                new SqlParameter("@Marca", pProducto.Marca),
                new SqlParameter("@RutaImage", pProducto.RutaImage),
                new SqlParameter("@Estado", pProducto.Estado),
                new SqlParameter("@MontoDescuento", pProducto.MontoDescuento)
            };
            return Database.ExecuteSqlRaw("EXECUTE [dbo].[InsertProducto] @Id , @Nombre , @Descripcion , @Precio , @Marca , @RutaImage , @Estado , @MontoDescuento", parameters);
        }
        public int sp_UpdateProducto(int idProducto, Producto pProducto)
        {
            SqlParameter[] parameters = new SqlParameter[] {
               new SqlParameter("@Id", pProducto.Id),
                new SqlParameter("@Nombre", pProducto.Nombre),
                new SqlParameter("@Descripcion", pProducto.Descripcion),
                new SqlParameter("@Precio", pProducto.Precio),
                new SqlParameter("@Marca", pProducto.Marca),
                new SqlParameter("@RutaImage", pProducto.RutaImage),
                new SqlParameter("@Estado", pProducto.Estado),
                new SqlParameter("@MontoDescuento", pProducto.MontoDescuento)
            };
            return Database.ExecuteSqlRaw("EXECUTE [dbo].[UpdateProducto]  @Id , @Nombre , @Descripcion , @Precio , @Marca , @RutaImage , @Estado , @MontoDescuento", parameters);
        }
        public int sp_GetProducto(int? idProducto)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@Id", idProducto)
            };
            return Database.ExecuteSqlRaw("EXECUTE [dbo].[GetProducto] @Id", parameters);
        }
        public int sp_DeleteProducto(int? idProductos)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@Id", idProductos)
            };
            return Database.ExecuteSqlRaw("EXECUTE [dbo].[DeleteProducto] @Id", parameters);
        }

        #region Productos

        #region Clientes
        public virtual DbSet<Usuario> Usuarios { get; set; }
        
        public List<Producto> sp_GetAllUsuarios()
        {
            return Productos.FromSqlRaw("EXECUTE [dbo].[GetAllUsuarios]").ToList();
        }

        public int sp_InsertUsuario(Usuario pUsuario)
        {                   
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@Id", pUsuario.Id),
                new SqlParameter("@Rol", pUsuario.Rol),
                new SqlParameter("@NombreCompleto", pUsuario.NombreCompleto),
                new SqlParameter("@Password", pUsuario.Password),
                new SqlParameter("@NombreUsuario", pUsuario.NombreUsuario),
                new SqlParameter("@Correo", pUsuario.Correo),
                new SqlParameter("@Estado", pUsuario.Estado)
            };
            return Database.ExecuteSqlRaw("EXECUTE [dbo].[InsertUsuario] @Id , @Rol , @NombreCompleto , @Password , @NombreUsuario , @Estado , @Correo", parameters);
        }
        public int sp_UpdateUsuario(int idUsuario, Usuario pUsuario)
        {
            SqlParameter[] parameters = new SqlParameter[] {
               new SqlParameter("@Id", pUsuario.Id),
                new SqlParameter("@Rol", pUsuario.Rol),
                new SqlParameter("@NombreCompleto", pUsuario.NombreCompleto),
                new SqlParameter("@Password", pUsuario.Password),
                new SqlParameter("@NombreUsuario", pUsuario.NombreUsuario),
                new SqlParameter("@Correo", pUsuario.Correo),
                new SqlParameter("@Estado", pUsuario.Estado)
            };
            return Database.ExecuteSqlRaw("EXECUTE [dbo].[UpdateUsuario]  @Id , @Rol , @NombreCompleto , @Password , @NombreUsuario , @Estado , @Correo", parameters);
        }
        public int sp_GetUsuario(int? idUsuario)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@Id", idUsuario)
            };
            return Database.ExecuteSqlRaw("EXECUTE [dbo].[GetUsuario] @Id", parameters);
        }
        public int sp_DeleteUsuario(int? idProductos)
        {
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@Id", idProductos)
            };
            return Database.ExecuteSqlRaw("EXECUTE [dbo].[DeleteUsuario] @Id", parameters);
        }
        #region Clientes
    }
}
