
using GestionEventos.API.Entities;

namespace GestionEventos.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var builder = WebApplication.CreateBuilder(args);

            //// Add services to the container.

            //builder.Services.AddControllers();
            //// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            //var app = builder.Build();

            //// Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}

            //app.UseHttpsRedirection();

            //app.UseAuthorization();


            //app.MapControllers();

            //app.Run();
            //---------------------------------------------------------------------------- 
            //Lo que esta arriba son cosas que tenia la clase program.cs y no se si borrarlas.

            // Instancia de la clase academico
            Academico objEventoAcademico = new Academico("Semana de la programacion",
                "ITM Freternidad",
                "Evento donde se ponenen a prueba los conocimeintos de los estudiantes en el area" +
                "de la programacion",
                "Programacion de Software",
                new DateTime(2023, 9, 27),
                new DateTime(2023, 10,30 )
            );

            // Informacion del Evento Academico con el metodo toString
            Console.WriteLine(objEventoAcademico.ToString());

            // Esperar a que el usuario presione una tecla para cerrar la aplicación
            Console.WriteLine("\nPulsa cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}