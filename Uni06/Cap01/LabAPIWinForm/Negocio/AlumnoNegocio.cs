using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Negocio
{
    public class AlumnoNegocio
    {
        private const string BaseUrl = "http://localhost:5119/api/Alumno/";
        public async static Task<IEnumerable<Alumno>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync(BaseUrl);
            var data = JsonConvert.DeserializeObject<IEnumerable<Alumno>>(response);
            return data ?? new List<Alumno>();
        }

        public async static Task<Boolean> Delete(Alumno alumno)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync($"{BaseUrl}{alumno.DNI}");
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Add(Alumno alumno)
        {
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync(BaseUrl, alumno);
            return response.IsSuccessStatusCode;
        }

        public async static Task<Boolean> Update(Alumno alumno)
        {
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync($"{BaseUrl}{alumno.DNI}", alumno);
            return response.IsSuccessStatusCode;
        }
    }
}
