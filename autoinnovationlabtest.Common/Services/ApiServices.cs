using autoinnovationlabtest.Common.Api;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Common.Services
{
    /// <summary>
    /// Nombre de la clase: ApiService
    /// </summary>
    public class ApiService : IApiService
    {
        /// <summary>
        /// Metodo para invocar los metodos Get del Api
        /// </summary>
        /// <param name="url">Recibe un string con la url a consumir</param>
        /// <returns>Retornar un objeto de tipo Response</returns>
        public async Task<Response> GetAsync(string url)
        {
            Response result = new Response();
            try
            {
                var client = new HttpClient();

                //Establece el tipo de dato
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync(url);
                var resultJson = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                    result = JsonConvert.DeserializeObject<Response>(resultJson);
                else
                {
                    result.IsSucced = false;
                    result.Message = resultJson;
                }

            }
            catch (Exception ex)
            {
                result.IsSucced = false;
                result.Message = " No se pudo realizar la conexion.";
            }
            return result;
        }

        /// <summary>
        /// Metodo para invocar los metodos post del api
        /// </summary>
        /// <param name="url"></param>
        /// <param name="pObject"></param>
        /// <returns></returns>
        public async Task<Response> PostAsync(string url,object pObject)
        {
            Response result = new Response();
            try
            {
                string request = JsonConvert.SerializeObject(pObject);
                StringContent content = new StringContent(request,Encoding.UTF8,"application/json");
                var client = new HttpClient();
                //Establece el tipo de dato
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.PostAsync(url,content);
                var resultJson = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                    result = JsonConvert.DeserializeObject<Response>(resultJson);
                else
                {
                    result.IsSucced = false;
                    result.Message = resultJson;
                }

            }
            catch (Exception ex)
            {
                result.IsSucced = false;
                result.Message = " No se pudo realizar la conexion.";
            }
            return result;
        }
    }
}
