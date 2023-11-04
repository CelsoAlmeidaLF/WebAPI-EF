using Systekna.Core;
using Systekna.Core.DTOs;

namespace Systekna.Application
{
    public interface IBbApplication
    {
        /// <summary>
        /// Cadastra despesa no banco de dados.
        /// </summary>
        /// <param name="despesa">Parametro despesa</param>
        /// <returns></returns>
        Task InsertDespesa(EntityDespesaDTO despesa);

        /// <summary>
        /// Returna lista de despesas cadastro no banco de dados.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<EntityDespesa>> GetAllDespesa();
    }
}