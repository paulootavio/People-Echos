namespace HQ_Echos___WEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FichaAvaliacao")]
    public partial class FichaAvaliacao
    {
       [Key]
        public int idFichaAvaliacao { get; set; }

        public int? idAvaliacao { get; set; }

        public int? idUser { get; set; }

        public DateTime? dataCriacao { get; set; }

        public DateTime? dataAlteracao { get; set; }

        public virtual Avaliacao Avaliacao { get; set; }

     
    }
}
