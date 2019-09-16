using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;

namespace GrupoZonica.Services
{
    public static class WebDataHelper
    {
        public static async Task<string> GetNombrePrograma()
        {
            string location = "http://www.radiozonica.com.ar/nombreprogramaapp.php";
            return await Get(location);
        }

        public static async Task<string> GetBannerPrograma()
        {
            string location = "http://www.radiozonica.com.ar/ventaprogramaapp.php";
            return await Get(location);
        }

        private static async Task<string> Get(string location)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(location);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
