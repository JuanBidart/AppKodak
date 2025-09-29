using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace appkodak
{
    public class ConexionApiDolar
    {
        // Propiedades de Solo Lectura, se asignan en la lógica de carga.
        public string compraOficial { get; private set; } = string.Empty;
        public string ventaOficial { get; private set; } = string.Empty;
        public string fechaOficial { get; private set; } = string.Empty;

        public string compraBlue { get; private set; } = string.Empty;
        public string ventaBlue { get; private set; } = string.Empty;
        public string fechaBlue { get; private set; } = string.Empty;

        // Estructura DTO (Data Transfer Object) para la deserialización
        private class DatosDolarDTO // Uso el sufijo DTO para distinguirlo de la clase principal
        {
            // Solo necesitamos mapear las propiedades que vas a usar.
            public decimal compra { get; set; } // Mejor usar decimal para valores monetarios
            public decimal venta { get; set; }
            public string fechaActualizacion { get; set; } = string.Empty;
        }

        // 1. Constructor PRIVADO (solo se puede llamar desde la propia clase)
        private ConexionApiDolar() { }

        // 2. Método de Fábrica Asíncrono (Punto de entrada obligatorio)
        public static async Task<ConexionApiDolar> CreateAsync()
        {
            var instancia = new ConexionApiDolar();
            // Llama a la función asíncrona y AWAIT la respuesta, garantizando que
            // la instancia solo se devuelve cuando está completamente cargada.
            await instancia.ObtenerDatosDolarAsync();
            return instancia;
        }

        // 3. Método de carga asíncrona que gestiona las llamadas
        private async Task ObtenerDatosDolarAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string fechaOficial = String.Empty;
                string fechaBlue = String.Empty;
                // ** MEJORA DE RENDIMIENTO: Carga paralela con Task.WhenAll **
                Task<DatosDolarDTO> oficialTask = CargarDatosDolarAsync(httpClient, "oficial");
                Task<DatosDolarDTO> blueTask = CargarDatosDolarAsync(httpClient, "blue");

                // Esperamos que ambas tareas terminen antes de continuar
                await Task.WhenAll(oficialTask, blueTask);

                // Procesamos los resultados
                var datosOficial = oficialTask.Result;
                var datosBlue = blueTask.Result;

                // Asignamos los datos (Oficial)
                this.compraOficial = datosOficial.compra.ToString("0");
                this.ventaOficial = datosOficial.venta.ToString("0");
                fechaOficial = datosOficial.fechaActualizacion;
                fechaOficial = Convert.ToDateTime(fechaOficial).ToString("dd/MM/yyyy  HH:mm");
                this.fechaOficial = fechaOficial;


                // Asignamos los datos (Blue)
                this.compraBlue = datosBlue.compra.ToString("0");
                this.ventaBlue = datosBlue.venta.ToString("0");
                fechaBlue = datosBlue.fechaActualizacion;
                fechaBlue = Convert.ToDateTime(fechaOficial).ToString("dd/MM/yyyy  HH:mm");
                this.fechaBlue = fechaBlue;
            }
        }

        // Método auxiliar para la lógica de la API (reutilizable)
        private async Task<DatosDolarDTO> CargarDatosDolarAsync(HttpClient client, string tipoDolar)
        {
            try
            {
                string url = $"https://dolarapi.com/v1/dolares/{tipoDolar}";
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Lanza excepción si la respuesta no es 2xx

                var jsonResponse = await response.Content.ReadAsStringAsync();

                var datosDolar = JsonSerializer.Deserialize<DatosDolarDTO>(jsonResponse,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                // Retorna los datos o una instancia vacía si la deserialización falla
                return datosDolar ?? new DatosDolarDTO();
            }
            catch (Exception ex)
            {
                // Puedes loguear el error aquí
                Console.WriteLine($"Error al cargar el dólar {tipoDolar}: {ex.Message}");
                // Retornamos un DTO vacío para evitar un error en el flujo principal
                return new DatosDolarDTO();
            }
        }
    }
}