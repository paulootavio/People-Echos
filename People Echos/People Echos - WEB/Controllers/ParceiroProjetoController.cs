using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using HQ_Echos___WEB.Filters;
using HQ_Echos___WEB.Models;
using HQ_Echos___WEB.Viewmodels;
using WebMatrix.WebData;
using System.Net.Mail;
using System.Net;

namespace HQ_Echos___WEB.Controllers
{
     [Authorize]
    [InitializeSimpleMembership]
    public class ParceiroProjetoController : Controller
    {

        public ActionResult Index()
        {
            return View("../Home/Index");
        }
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }
        [HttpGet]
        public JsonResult LoadFicha()
        {
            //Lista Check
            var questaoCursosEDT = new List<ViewModelQuestaoCheck>();
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 95, textoResposta  = "Imersão em Design Thinking", selecionado = false, idQuestao = 61 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 96, textoResposta  = "ENACT - Negócios do Futuro", selecionado = false, idQuestao = 61 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 97, textoResposta  = "Design Thinking Experience", selecionado = false, idQuestao = 61 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 98, textoResposta  = "Mobilize!", selecionado = false, idQuestao = 61 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 99, textoResposta  = "Design e Gestão de Serviços", selecionado = false, idQuestao = 61 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 100, textoResposta = "Inovação Social", selecionado = false, idQuestao = 61 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 101, textoResposta = "Business Design", selecionado = false, idQuestao = 61 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 102, textoResposta = "Make it - A Nova Revolução Industrial", selecionado = false, idQuestao = 61 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 103, textoResposta = "Preparatório de Facilitação", selecionado = false, idQuestao = 61 });
            
            //Montagem da questoes da ficha.
            var models = new Model1();
            var fichava = new FichaAvaliacao();
            var idUsuario = WebSecurity.CurrentUserId;

            fichava.idUser = WebSecurity.CurrentUserId;
            fichava.idAvaliacao = 4;

            var fichaEf = models.FichaAvaliacao.FirstOrDefault(i => i.idAvaliacao == 1 && i.idUser == fichava.idUser);

            if (fichaEf == null)
            {
                models.FichaAvaliacao.Add(new FichaAvaliacao
                {
                    idAvaliacao = 1,
                    idUser = WebSecurity.CurrentUserId,
                    dataCriacao = DateTime.Now
                }
                    );
                models.SaveChanges();
                fichaEf = models.FichaAvaliacao.FirstOrDefault(i => i.idAvaliacao == 1 && i.idUser == fichava.idUser);
            }
            var avali = models.Avaliacao.ToList();
            var vwModel = new List<ViewModelQuestao>();

            foreach (var a in avali)
            {
                foreach (var aq in a.Questao)
                {
                    var tt = new ViewModelQuestao();
                    tt.Nome = aq.Nome;
                    tt.idQuestao = aq.idQuestao;
                    tt.idFichaAvaliacao = fichaEf.idFichaAvaliacao;
                    vwModel.Add(tt);
                }
            }

            ////Verifica respostas das questoes se existe.
            var contextResposta = new Resposta1();
            foreach (var viewModelQuestao in vwModel)
            {
                var resposta = contextResposta.Resposta.SingleOrDefault(a => a.idQuestao == viewModelQuestao.idQuestao && a.idUser == WebSecurity.CurrentUserId);
                if (resposta != null)
                {
                    if (resposta.descricao != null)
                    {
                        viewModelQuestao.Resposta = resposta.descricao;
                        viewModelQuestao.idResposta = resposta.idResposta;
                    }
                    else
                    {
                        viewModelQuestao.idResposta = resposta.idResposta;
                    }
                }
            }

            var respostasChecks = models.RespostaCheck.Where(q => q.idUsuario == idUsuario).ToList();
            foreach (var resposta in respostasChecks)
            {

                foreach (var questaoEDT in questaoCursosEDT)
                {
                    if (questaoEDT.perguntaCheckId == resposta.idQuestaoCheck)
                    {
                        questaoEDT.selecionado = resposta.Resposta;
                        questaoEDT.idRespostaCheck = resposta.idRespostaCheck;
                    }
                }
            }



            return Json(new { model = vwModel, questaoCursosEDT }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Cadastro(List<ViewModelQuestao> model, List<ViewModelQuestaoCheck> questaoCursosEDT)
        {
            //var email = new Viewmodels.MailModel();
            //email.Subject = "Muito obrigado pelo seu interesse!";
            var emailTo = WebSecurity.CurrentUserName;
            //email.From = "peopleechos@echos.cc";
            //MailMessage mail = new MailMessage();
            //mail.To.Add(email.To);
            //mail.From = new MailAddress(email.From);
            //mail.Subject = email.Subject;
            string Body = @"    
             <h1>Muito obrigado pelo seu interesse!</h1>
             <p>Oi!Tudo bem?</p>
             <p>Além de dizer que estamos muito felizes pelo seu interesse em ser um facilitador da Escola Design Thinking, também gostaríamos de alinhar os próximos passos da nossa relação.</p>

            <p>A partir das informações que você nos enviou neste formulário faremos uma pré-seleção e entraremos em contato te convidando para uma entrevista, um Skype, ou um café mesmo assim que tivermos a necessidade de um facilitador para o curso que você se interessou.</p>
            </br>
            <p>Depois desta entrevista te daremos um retorno dizendo se o seu perfil é o que estamos buscando realmente. 
            E em seguida voltaremos a entrar em contato com você sempre que tivermos um projeto que se encaixe no seu perfil e nas suas áreas de interesse.</p>

            </br>
            <p>IMPORTANTE:  para ser facilitador de um curso da Escola Design Thinking é FUNDAMENTAL que você compreenda profundamente a nossa cultura e a forma como trabalhamos os nossos temas, além do aprofundamento prático e teórico no tema em questão. Por isso geralmente buscamos pessoas que já conheçam nosso ecossistema e, necessariamente, tenham feito o curso em questão.</p>
            <p><b>É desejável que o facilitador tenha feito algum curso de design thinking na Escola e o curso preparatório de facilitação.</b> </p>
            <p>
            Por enquanto é isso.
            Mais uma vez obrigado pelo seu interesse em trabalhar conosco e nos vemos em breve. =)
            </p>

            Atenciosamente,
            Design Echos.</p>";

            //mail.Body = Body;
            //mail.IsBodyHtml = true;
            //SmtpClient smtp = new SmtpClient("smtp.live.com");
            //smtp.Host = "smtp.live.com";
            //smtp.Port = 587;
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new System.Net.NetworkCredential
            //("paulinho.speed@hotmail.com", "p4$$wordn3w1");// Enter seders User name and password  
            //smtp.EnableSsl = true;
            //smtp.Send(mail);

            try
            {
                SmtpClient ss = new SmtpClient();
                ss.Host = "smtpout.secureserver.net";
                ss.Port = 3535;
                ss.Timeout = 100000;
                ss.DeliveryMethod = SmtpDeliveryMethod.Network;
                ss.UseDefaultCredentials = false;
                ss.Credentials = new NetworkCredential("admin@peopleechos.com", "echosadmin@2016");
                ss.EnableSsl = false;

                MailMessage mailMsg = new MailMessage("admin@peopleechos.com", emailTo, "Muito obrigado pelo seu interesse!", "my body");
                mailMsg.Body = Body;

                mailMsg.IsBodyHtml = true;
                mailMsg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                ss.Send(mailMsg);
            }
            catch (Exception ex)
            {

                return Json(ex.ToString());
            }


            var idUser = WebSecurity.CurrentUserId;
            var context = new Resposta1();
            var RespostaModel = new Resposta();
            var RespostaCheckModel = new RespostaCheck();

            foreach (var resposta in model)
            {
                if (resposta.idResposta > 0)
                {
                    var respostaContext = context.Resposta.Find(resposta.idResposta);
                    respostaContext.descricao = resposta.Resposta;

                    context.Entry(respostaContext).State = EntityState.Modified;
                    context.SaveChanges();
                }
                else
                {
                    RespostaModel.idQuestao = resposta.idQuestao;
                    RespostaModel.idFichaAvaliacao = resposta.idFichaAvaliacao;
                    RespostaModel.descricao = resposta.Resposta;
                    RespostaModel.idUser = idUser;
                    context.Resposta.Add(RespostaModel);
                    context.SaveChanges();
                }
            }

            foreach (var respostaCheckEDT in questaoCursosEDT)
            {

                if (respostaCheckEDT.idRespostaCheck > 0)
                {
                    var respostaContext = context.RespostaCheck.Find(respostaCheckEDT.idRespostaCheck);
                    respostaContext.Resposta = respostaCheckEDT.selecionado;

                    context.Entry(respostaContext).State = EntityState.Modified;
                    context.SaveChanges();
                }
                else
                {
                    RespostaCheckModel.idQuestaoCheck = respostaCheckEDT.perguntaCheckId;
                    RespostaCheckModel.idUsuario = idUser;
                    RespostaCheckModel.Resposta = respostaCheckEDT.selecionado;
                    context.RespostaCheck.Add(RespostaCheckModel);
                    context.SaveChanges();
                }
            }

            context.SaveChanges();
            context.Dispose();

            return View("../Home/IndexAuth");
        }

        [HttpPost]
        public ActionResult EnviarEmail()
        {
            //WebSecurity.CurrentUserName;
            var email = new Viewmodels.MailModel();
            email.Subject = "Muito obrigado pelo seu interesse!";
            email.To = "paulinho.speed@hotmail.com";
            email.From = "peopleechos@echos.cc";
            MailMessage mail = new MailMessage();
            mail.To.Add(email.To);
            mail.From = new MailAddress(email.From);
            mail.Subject = email.Subject;
            string Body = @"    <h1>Muito obrigado pelo seu interesse!</h1>
                <p>Oi!Tudo bem?</p>
             <p>Além de dizer que estamos muito felizes pelo seu interesse em ser um consultor da Design Echos, também gostaríamos de alinhar os próximos passos da nossa relação.</p>

            <p>A partir das informações que você nos enviou neste formulário faremos uma pré-seleção e entraremos em contato te convidando para uma entrevista, um Skype, ou um café mesmo. ;D
            Como queremos analisar bem profundamente seu perfil esperamos entrar em contato com você em até 30 dias. Desde já pedimos desculpas pela demora.</p>
            </br>
            <p>Depois desta entrevista te daremos um retorno dizendo se o seu perfil é o que estamos buscando realmente. 
            E em seguida voltaremos a entrar em contato com você sempre que tivermos um projeto que se encaixe no seu perfil e nas suas áreas de interesse.</p>

            </br>
            <p><b>IMPORTANTE:</b> se você tem alguma demanda de um projeto de inovação e gostaria de trazê-lo para trabalharmos juntos dê uma olhadinha na nossa seção de Parceiro de projetos na página: www.escoladesignthinking.com.br/</p>

            <p>
            Por enquanto é isso.
            Mais uma vez obrigado pelo seu interesse em trabalhar conosco e nos vemos em breve. =)
            </p>

            Atenciosamente,
            Design Echos.</p>";

            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;


            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("peopleechos@echos.cc", "master2016");// Enter seders User name and password  
            smtp.EnableSsl = true;
            smtp.Send(mail);

            SmtpClient client = new SmtpClient();
            return null;
        }
    }
}
