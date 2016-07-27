namespace HQ_Echos___WEB.Viewmodels
{
    using System;
    using HQ_Echos___WEB.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public class ViewModelQuestaoCheck
    {
        public List<Questao> listQuestao { get; set; }
        public List<QuestaoCheck> listQuestao { get; set; }
    }
}
