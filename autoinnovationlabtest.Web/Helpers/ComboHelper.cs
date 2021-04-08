using autoinnovationlabtest.Common.Models;
using autoinnovationlabtest.Common.Services.Brands;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Web.Helpers
{
    public class ComboHelper : IComboHelper
    {
        private readonly IBrandService _brandService;

        public ComboHelper(IConfiguration configuration,IBrandService brandService)
        {
            _brandService = brandService;
            _brandService.UrlBase = configuration.GetValue<string>("UrlApi");
        }
        public async Task<IEnumerable<SelectListItem>> GetComboBrands()
        {
            List<SelectListItem> list = new List<SelectListItem>
            {
                new SelectListItem { Value = "0", Text = "" }
            };
            var response = await _brandService.GetAll();
            if(response.IsSucced)
            {
                var brands = JsonConvert.DeserializeObject<List<Brand>>(response.Result.ToString());
                foreach (var brand in brands)
                {
                    list.Add(new SelectListItem { Value = brand.Id.ToString(),Text = $"{brand.Name}" });
                }
            }
            
            return list;
        }
    }
}
