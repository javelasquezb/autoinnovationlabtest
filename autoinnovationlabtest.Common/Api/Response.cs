namespace autoinnovationlabtest.Common.Api
{
    /// <summary>
    /// Nombre de la clase: Response
    /// Clase para indicar el estado de las respuesta del api
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Propiedad IsSucced
        /// </summary>
        public bool IsSucced { get; set; }
        /// <summary>
        /// Propiedad Message
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Propiedad Result
        /// </summary>
        public object Result { get; set; }
    }
}
