using autoinnovationlabtest.Data.Entities;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Data.Repositories.Interfaces
{
    /// <summary>
    /// Nombre de la interfaz: ICarRepository
    /// Interfaz con los metodos para operar con la clase Car
    /// </summary>
    public interface ICarRepository : IGenericRepository<Car>
    {
        /// <summary>
        /// Firma de metodo GetAllInfo
        /// Metodo para obtener toda la informacion de un Car
        /// con las tablas con que se relaciona
        /// </summary>
        /// <param name="id">int con el valor del id del Car a consultar</param>
        /// <returns>Objeto de tipo Car con la informacion consultada</returns>
        Task<Car> GetAllInfo(int id);
    }
}
