using Newtonsoft.Json;

namespace ProyectoJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string configPath = "config.json";

            LectorConfig config;

            if (File.Exists(configPath))
            {
                // LEER CONTENIDO JSON
                string jsonContent = File.ReadAllText(configPath);

                // DESERIALIZAR JSON EN OBJETO LECTORCONFIG
                config = JsonConvert.DeserializeObject<LectorConfig>(jsonContent);
            }
            else
            {
                config = new LectorConfig();
            }

            // Acceder a los valores de configuración
            Console.WriteLine($"Contrincante: {config.Contrincante}");
            Console.WriteLine($"Posicionamiento: {config.Posicionamiento}");
            Console.WriteLine($"Versión: {config.Version}");
        }
    }
}