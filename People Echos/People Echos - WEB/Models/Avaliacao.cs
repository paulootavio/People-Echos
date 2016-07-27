namespace HQ_Echos___WEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Avaliacao")]
    public partial class Avaliacao
    {
        public Avaliacao()
        {
            FichaAvaliacao = new HashSet<FichaAvaliacao>();
            Questao = new HashSet<Questao>();
        }

        [Key]
        public int idAvaliacao { get; set; }

        [StringLength(200)]
        public string nomeAvaliacao { get; set; }

        public int? idTipoAvaliacao { get; set; }

        public DateTime? dataCriacao { get; set; }

        public DateTime? dataAlteracao { get; set; }

        public virtual ICollection<FichaAvaliacao> FichaAvaliacao { get; set; }

        public virtual ICollection<Questao> Questao { get; set; }
    }
}
