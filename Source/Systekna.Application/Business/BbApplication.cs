using Microsoft.EntityFrameworkCore;
using Systekna.Core;
using Systekna.Core.DTOs;
using Systekna.Infrasctruture;

namespace Systekna.Application.Business
{
    public class BbApplication : DbApplicationDbContext, IBbApplication
    {
        public BbApplication(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Cadastra despesa no banco de dados.
        /// </summary>
        /// <param name="despesa">Parametro despesa</param>
        /// <returns></returns>
        public async Task InsertDespesa(EntityDespesaDTO despesa)
        {
            var ent = EntityDespesa.Map(despesa);
            Add(ent);
            await SaveChangesAsync();
        }

        /// <summary>
        /// Returna lista de despesas cadastro no banco de dados.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EntityDespesa>> GetAllDespesa()
        { 
            return await TB_DESPESA.ToListAsync();
        }
    }
}
