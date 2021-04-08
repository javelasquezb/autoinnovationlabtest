using System.ComponentModel;

namespace autoinnovationlabtest.Web.Models
{
    /// <summary>
    /// Nombre de la clase: CarViewModel
    /// </summary>
    public class CarViewModel
    {
        public int Id { get; set; }
        [DisplayName("Modelo")]
        public string Model { get; set; }
        [DisplayName("Año")]
        public string Year { get; set; }
        [DisplayName("Marca")]
        public string Brand { get; set; }
    }
}
