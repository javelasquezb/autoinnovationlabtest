using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;

namespace autoinnovationlabtest.Web.Models
{
    /// <summary>
    /// Nombre de la clase: CarViewModel
    /// Clase representativa de la vista Index de Cars
    /// </summary>
    public class CarViewModel
    {
        /// <summary>
        /// Propeidad Id
        /// Identificador del registro
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Propiedad Model
        /// Nombre del modelo del Car
        /// </summary>
        [DisplayName("Modelo")]
        public string Model { get; set; }
        /// <summary>
        /// Propiedad Year
        /// Año del Car
        /// </summary>
        [DisplayName("Año")]
        public string Year { get; set; }
        /// <summary>
        /// Propiedad Brand
        /// Nombre de la marca a la que pertenece el Car
        /// </summary>
        [DisplayName("Marca")]
        public string Brand { get; set; }
        /// <summary>
        /// Propiedad Brands
        /// Lista de items con el listado de Marcas para realizar filtrado
        /// </summary>
        [DisplayName("Marcas")]
        public IEnumerable<SelectListItem> Brands { get; set; }
        /// <summary>
        /// Propiedad BrandId
        /// Identificador del registro Brand
        /// </summary>
        public int BrandId { get; set; }

    }
}
