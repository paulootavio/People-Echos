using HQ_Echos___WEB.Filters;
using HQ_Echos___WEB.Models;
using HQ_Echos___WEB.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;
using HQ_Echos___WEB.Viewmodels;
using WebMatrix.WebData;
using System.Net.Mail;
using System.Net;
using System.Web.Http.Routing;

namespace HQ_Echos___WEB.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [InitializeSimpleMembership]
    public class FiltrosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult LoadTipoFichas()
        {
            var models = new Model1();
            var fichava = new FichaAvaliacao();
            var idUsuario = WebSecurity.CurrentUserId;

            var fichaEf = models.Avaliacao.Select(a => new{ a.nomeAvaliacao,a.idAvaliacao} ).ToList();
           
            return Json(fichaEf, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ListQuestoes(int idAvaliacao)
        {
            var models = new Model1();
            var idUsuario = WebSecurity.CurrentUserId;

            var Questoes = models.Questao.Where(q => q.idAvaliacao == idAvaliacao).Select(q => new { q.Nome, q.idQuestao }).ToList();

            //pegar lista de fichas
             return Json(Questoes, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult listResposta(int idQuestao, string resposta)
        {
            var models = new Model1();

            var idUsuario = WebSecurity.CurrentUserId;

            var Questoes = models.Resposta.Where(q => q.idQuestao == idQuestao && q.descricao.Contains(resposta)).ToList();

            var listIDs = Questoes.Select(q => q.idUser).ToList();

            var result = models.Users.Where(q => listIDs.Contains(q.UserId)).Select(q => q.UserName).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult FichaCompleta(int idAvaliacao, int idUser)
        {
            var models = new Model1();

            var idUsuario = WebSecurity.CurrentUserId;

            var resultQuestoesRespostas = models.Questao.Join(models.Resposta
                , a => a.idQuestao
                ,q => q.idQuestao
                , (a, q) => new { a, q })
                    .Where(q => q.a.idAvaliacao == idAvaliacao && q.q.idUser == idUser).Select(r =>  new {  r.q.Questao, r.a.Descricao })
                .ToList();
            return Json(resultQuestoesRespostas, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult QuestoesChecks(int idAvaliacao)
        {
            var models = new Model1();

            var Questoes = models.Questao.Where(q => q.idAvaliacao == idAvaliacao && q.idTipoQuestao == 3).Select(q => q.idQuestao).ToList();

            var resultQuestoesCkeck = models.QuestaoCheck.Where(q => Questoes.Contains(q.idQuestao)).ToList();                 

           
             return Json(resultQuestoesCkeck, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public JsonResult BuscarRespostaTeste()
        {
            var models = new Model1();

            var idUsuario = WebSecurity.CurrentUserId;

            var Questoes = models.Resposta.Where(q => q.idQuestao == idQuestao && q.descricao.Contains(resposta)).ToList();

            var listIDs = Questoes.Select(q => q.idUser).ToList();

            var result = models.Users.Where(q => listIDs.Contains(q.UserId)).Select(q => q.UserName).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }



        [HttpGet]
        public JsonResult listQuestoesChecks(int idAvaliacao)
        {
            var models = new Model1();

            var idUsuario = WebSecurity.CurrentUserId;
            var Questoes = models.Questao.Where(q => q.idAvaliacao == idAvaliacao).Select(q =>  q.idQuestao).ToList();
 
            var QuestoesCkeck = models.QuestaoCheck.Where(q => q.idQuestao == 31).Select(qc => qc.idQuestaoCheck).ToList();
          
            //pegar lista de fichas Questoes.Contains(q.idQuestao)
            var UsarioRespostasCheck = models.RespostaCheck.Where(rc => QuestoesCkeck.Contains(rc.idQuestaoCheck)).GroupBy(rcu => rcu.idUsuario).Select(rc => rc.Key ).ToList();


            //Resposta opcional
            var UsarioRespostaQuestao = models.Resposta.Where(q => q.idQuestao == 1 && q.descricao.Contains("Lider")).ToList();

            var listIDs = UsarioRespostaQuestao.Select(q => q.idUser).ToList();

            var result = models.Users.Where(q => listIDs.Contains(q.UserId)).Select(q => q.UserName).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);

            return Json(Questoes);
        }

        [HttpGet]
        public JsonResult listRespostaTeste(int idQuestao, string resposta)
        {
            var models = new Model1();

            var idUsuario = WebSecurity.CurrentUserId;

            var Questoes = models.Resposta.Where(q => q.idQuestao == idQuestao && q.descricao.Contains(resposta)).ToList();

            var listIDs = Questoes.Select(q => q.idUser).ToList();

            var result = models.Users.Where(q => listIDs.Contains(q.UserId)).Select(q => q.UserName).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
