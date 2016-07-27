namespace HQ_Echos___WEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Questao")]
    public partial class Questao
    {
        public Questao()
        {
            Resposta = new HashSet<Resposta>();
        }

        [Key]
        public int idQuestao { get; set; }

        public int? idAvaliacao { get; set; }

        [StringLength(500)]
        public string Nome { get; set; }

        [Column(TypeName = "text")]
        public string Descricao { get; set; }

        public int? idTipoQuestao { get; set; }

        public DateTime? dataCriacao { get; set; }

        public DateTime? dataAlteracao { get; set; }

        public virtual Avaliacao Avaliacao { get; set; }

        public virtual TipoQuestao TipoQuestao { get; set; }

        public virtual ICollection<Resposta> Resposta { get; set; }
    }


    [Table("QuestaoCheck")]
    public partial class QuestaoCheck
    {
        [Key]
        public int idQuestaoCheck { get; set; }

        public int idQuestao { get; set; }

        public string Resposta { get; set; }

        public DateTime? dataCriacao { get; set; }

        public DateTime? dataAlteracao { get; set; }
    }


  
}
