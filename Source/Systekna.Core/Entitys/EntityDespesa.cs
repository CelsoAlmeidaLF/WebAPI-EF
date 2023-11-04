using Systekna.Core.DTOs;
using Systekna.Core.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Systekna.Core
{
    public class EntityDespesa : ModelBase
    {
        public string DsDespesa { get; set; } = string.Empty; 

        [Column(TypeName = "decimal(12, 2)")]
        public decimal VlrDespesa { get; set; } = 0;

        [DataType(DataType.Date)]
        public DateTime DtVencimento { get; set; } = DateTime.Now;

        public StatusPagamento IdStatus { get; set; } = StatusPagamento.EmAberto;

        public static EntityDespesa Map(EntityDespesaDTO despesa)
        {
            return new EntityDespesa()
            {
                DsDespesa = despesa.DsDespesa,
                VlrDespesa = despesa.VlrDespesa,
                DtVencimento = despesa.DtVencimento,
                IdStatus = despesa.Status
            };
        }
    }
}