using System.ComponentModel.DataAnnotations;

namespace Systekna.Core.Entities.Base
{
    public abstract class ModelBase
    {
        [Key]
        public int? ID { get; set; } = default(int?);
        public DateTime? DtCriação { get; set; } = DateTime.Now;
        public DateTime? DtAlteração { get; set; } = DateTime.Now;
        public bool FlExclusão { get; set; } = false;
        public DateTime? DtExclusão { get; set; } = default(DateTime?);
    }
}
