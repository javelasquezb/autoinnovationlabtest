using autoinnovationlabtest.Data.Entities;
using autoinnovationlabtest.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace autoinnovationlabtest.Data.Repositories
{
	/// <summary>
	/// Nombre de la clase: GenericRepository
	/// Clase para el manejo generico de CRUD
	/// </summary>
	/// <typeparam name="T">Variable Generica para el manejo de las clases representativas de la base de datos</typeparam>
	public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
	{
		//Variable contexto de la base de datos
		private readonly DataContext _context;

		/// <summary>
		/// Constructor de la clase
		/// </summary>
		/// <param name="context"></param>
		public GenericRepository(DataContext context)
		{
			this._context = context;
		}

		/// <summary>
		/// Metodo para obtener todos los registros
		/// </summary>
		/// <returns>Iqueryable de la clase indicada</returns>
		public IQueryable<T> GetAll()
		{
			return this._context.Set<T>().AsNoTracking();
		}

		/// <summary>
		/// Metodo para obtener un registro por Id
		/// </summary>
		/// <param name="id">int con el valor a buscar</param>
		/// <returns>Objeto de la clase indicada</returns>
		public async Task<T> GetByIdAsync(int id)
		{
			return await this._context.Set<T>()
				.AsNoTracking()
				.FirstOrDefaultAsync(e => e.Id == id);
		}

		/// <summary>
		/// Metodo para guardar un registro
		/// </summary>
		/// <param name="entity">objeto de la clase indicada</param>
		/// <returns>Objeto de la clase indicada</returns>
		public async Task<T> CreateAsync(T entity)
		{
			await this._context.Set<T>().AddAsync(entity);
			await SaveAllAsync();
			return entity;
		}

		/// <summary>
		/// Metodo para actualizar un registro
		/// </summary>
		/// <param name="entity">objeto de la clase indicada</param>
		/// <returns>objeto de la clase indicada</returns>
		public async Task<T> UpdateAsync(T entity)
		{
			this._context.Set<T>().Update(entity);
			await SaveAllAsync();
			return entity;
		}

		/// <summary>
		/// Metodo para eliminar un registro
		/// </summary>
		/// <param name="entity">Objeto de la clase indicada</param>
		/// <returns>Objeto de tipo Task</returns>
		public async Task DeleteAsync(T entity)
		{
			this._context.Set<T>().Remove(entity);
			await SaveAllAsync();
		}

		/// <summary>
		/// Metodo para saber si existe registro
		/// </summary>
		/// <param name="id">int con el valor a consultar</param>
		/// <returns>bool con la existencia del registro</returns>
		public async Task<bool> ExistAsync(int id)
		{
			return await this._context.Set<T>().AnyAsync(e => e.Id == id);

		}

		/// <summary>
		/// Metodo para guardar los cambios efectuados
		/// </summary>
		/// <returns>bool con la respuesta de la cantidad de registros afectados en el cambio</returns>
		public async Task<bool> SaveAllAsync()
		{
			return await this._context.SaveChangesAsync() > 0;
		}
	}
}
