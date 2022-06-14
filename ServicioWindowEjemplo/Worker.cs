using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ServicioWindowEjemplo
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                
              
                string path = @"C:\Users\Daniel\Downloads\Capacitacion\Capacitacion\";
                //Creamos el directorio
                Directory.CreateDirectory(path);
                //Establecemos la ubicación del fichero de texto
                path += "output.txt";
                //Escribimos en el fichero
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"Esto es un Ejemplo de un Servicio, con fecha {DateTime.Now}");
                }
                await Task.Delay(15000, stoppingToken);
            }
        }
    }
}
