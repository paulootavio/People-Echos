namespace HQ_Echos___WEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoQuestao")]
    public partial class TipoQuestao
    {
        public TipoQuestao()
        {
            Questao = new HashSet<Questao>();
        }

        [Key]
        public int idTipoQuestao { get; set; }

        [StringLength(100)]
        public string DescTipo { get; set; }

        public virtual ICollection<Questao> Questao { get; set; }
    }
}
