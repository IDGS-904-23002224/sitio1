using sitio1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace sitio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 1. Agregar servicios
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // 2. Configurar SQL Server
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // 3. Configurar el pipeline
            app.UseDeveloperExceptionPage(); // Mostrar detalles del error para diagnóstico

            app.UseSwagger();
            app.UseSwaggerUI();

            // app.UseHttpsRedirection(); // Comentado temporalmente para pruebas locales HTTP
            app.UseAuthorization();
            app.MapControllers();

            // 4. Arrancar la aplicación
            app.Run();
        }
    }
}