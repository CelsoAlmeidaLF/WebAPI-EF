using System.ComponentModel.DataAnnotations;

namespace Systekna.Core.DTOs
{
    public class EntityDespesaDTO
    {
        public string DsDespesa { get; set; } = string.Empty;

        public decimal VlrDespesa { get; set; } = 0;

        [DataType(DataType.Date)]
        public DateTime DtVencimento { get; set; } = DateTime.Now;

        public StatusPagamento Status { get; set; } = StatusPagamento.EmAberto;
    }
}
