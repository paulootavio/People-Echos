namespace HQ_Echos___WEB.Viewmodels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public class ViewModelQuestaoCheck
    {
        public int idQuestao { get; set; }
        public int? idAvaliacao { get; set; }
        public int? idFichaAvaliacao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? idTipoQuestao { get; set; }
        public string Resposta { get; set; }
    }
}
