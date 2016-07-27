namespace HQ_Echos___WEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Resposta")]
    public partial class Resposta
    {
        [Key]
        public int idResposta { get; set; }

        public int? idQuestao { get; set; }

        public int? idFichaAvaliacao { get; set; }

        [Column(TypeName = "text")]
        public string descricao { get; set; }

        public DateTime? dataCriacao { get; set; }

        public DateTime? dataAlteracao { get; set; }

        public virtual FichaAvaliacao FichaAvaliacao { get; set; }

        public virtual Questao Questao { get; set; }

        public int idUser { get; set; }
    }

    [Table("RespostaCheck")]
    public partial class RespostaCheck
    {
        [Key]
        public int idRespostaCheck { get; set; }

        public int idQuestaoCheck { get; set; }

        public int idUsuario { get; set; }

        public bool Resposta { get; set; }

        public DateTime? dataCriacao { get; set; }

        public DateTime? dataAlteracao { get; set; }

    }
}
