using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.Mvc;

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
    public class ConsultorController : Controller
    {
         [ValidateAntiForgeryToken]
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
        public JsonResult teste()
        {

            List<ViewModelQuestaoCheck> questaoCursosEDT = new List<ViewModelQuestaoCheck>();
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 1, textoResposta = "Imersão em Design Thinking", selecionado = false, idQuestao = 25 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 2, textoResposta = "ENACT - Negócios do Futuro", selecionado = false, idQuestao = 25 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 3, textoResposta = "Design Thinking Experience", selecionado = false, idQuestao = 25 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 4, textoResposta = "Mobilize!", selecionado = false, idQuestao = 25 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 5, textoResposta = "Design e Gestão de Serviços", selecionado = false, idQuestao = 25 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 6, textoResposta = "Inovação Social", selecionado = false, idQuestao = 25 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 7, textoResposta = "Business Design", selecionado = false, idQuestao = 25 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 8, textoResposta = "Make it - A Nova Revolução Industrial", selecionado = false, idQuestao = 25 });
            questaoCursosEDT.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 9, textoResposta = "Preparatório de Facilitação", selecionado = false, idQuestao = 25 });

            List<ViewModelQuestaoCheck> questaoSkillTema = new List<ViewModelQuestaoCheck>();
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 9, textoResposta = "Design Thinking", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 10, textoResposta = "Bio Hacking", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 11, textoResposta = "Facilitação de processos de inovação", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 12, textoResposta = "Inteligencia Artificial", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 13, textoResposta = "Redes", selecionado = false, idQuestao = 26 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 14, textoResposta = "Empreendedorismo Criativo", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 15, textoResposta = "Criatividade", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 16, textoResposta = "Big Data", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 17, textoResposta = "Design de Serviço", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 18, textoResposta = "Empreendedorismo Tecnológico (Startups)", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 19, textoResposta = "Fabricação Digital", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 20, textoResposta = "Robótica", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 21, textoResposta = "Internet das Coisas", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 22, textoResposta = "Tecnologias Wearable", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 23, textoResposta = "Big Data", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 24, textoResposta = "Crowdsourcing", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 25, textoResposta = "Crowdfunding", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 26, textoResposta = "Gamefication", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 27, textoResposta = "Gamefication", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 28, textoResposta = "Cool Hunting", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 29, textoResposta = "Inovação Social", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 30, textoResposta = "Modelagem de Negócios", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 31, textoResposta = "Mudança Cultural em Empresas", selecionado = false, idQuestao = 23 });
            questaoSkillTema.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 32, textoResposta = "Etnografia", selecionado = false, idQuestao = 23 });

            List<ViewModelQuestaoCheck> questaoMercado = new List<ViewModelQuestaoCheck>();
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 33, textoResposta = "Saúde", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 34, textoResposta = "Indústrias de bens de capital (siderúrgicas, metalúrgicas, indústrias de equipamentos e máquinas)", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 35, textoResposta = "Indústrias extrativas (mineradoras, madeireiras e petrolíferas)", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 36, textoResposta = "Educação", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 37, textoResposta = "Serviços Financeiros", selecionado = false, idQuestao = 26 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 38, textoResposta = "Tecnologia", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 39, textoResposta = "Energia", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 40, textoResposta = "Construção Civil", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 41, textoResposta = "Transporte", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 42, textoResposta = "Telecomunicação", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 43, textoResposta = "Alojamento e Alimentação", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 44, textoResposta = "Serviços em geral", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 45, textoResposta = "Bens de Consumo duráveis (automóveis, linha branca, etc.)", selecionado = false, idQuestao = 23 });
            questaoMercado.Add(new ViewModelQuestaoCheck { idRespostaCheck = 0, perguntaCheckId = 46, textoResposta = "Bens de Consumo não duráveis (higiene e beleza)", selecionado = false, idQuestao = 23 });
            

            var models = new Model1();
            FichaAvaliacao fichava = new FichaAvaliacao();
            var idUsuario =  WebSecurity.CurrentUserId;
            fichava.idUser = WebSecurity.CurrentUserId;
            fichava.idAvaliacao = 1;
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
                    foreach (var questaoSkill in questaoSkillTema)
                    {
                        if (questaoSkill.perguntaCheckId == resposta.idQuestaoCheck)
                        {
                            questaoSkill.selecionado = resposta.Resposta;
                            questaoSkill.idRespostaCheck = resposta.idRespostaCheck;
                        }
                    }
                    foreach (var questaomerc in questaoMercado)
                    {
                        if (questaomerc.perguntaCheckId == resposta.idQuestaoCheck)
                        {
                            questaomerc.selecionado = resposta.Resposta;
                            questaomerc.idRespostaCheck = resposta.idRespostaCheck;
                        }
                    }
                
                            
            }



            return Json(new { model = vwModel, questaoCursosEDT = questaoCursosEDT, questaoSkillTema = questaoSkillTema, questaoMercado = questaoMercado }, JsonRequestBehavior.AllowGet);
        }
   
        [HttpPost]
        public ActionResult Cadastro(List<ViewModelQuestao> model, List<ViewModelQuestaoCheck> questaoCursosEDT, List<ViewModelQuestaoCheck> questaoSkillTema, List<ViewModelQuestaoCheck>  questaoMercado)
        {
            ////WebSecurity.CurrentUserName;
            //var email = new Viewmodels.MailModel();
            //email.Subject = "Muito obrigado pelo seu interesse!";
            var EmailTo = WebSecurity.CurrentUserName;
            //email.To = "paulinho.speed@hotmail.com";
            //email.From = "echosteste@pogsp.com";
            //MailMessage mail = new MailMessage();
            //mail.To.Add(email.To);
            //mail.From = new MailAddress(email.From);
            //mail.Subject = email.Subject;
            //string Body = @"    <h1>Muito obrigado pelo seu interesse!</h1>
            //    <p>Oi!Tudo bem?</p>
            // <p>Além de dizer que estamos muito felizes pelo seu interesse em ser um consultor da Design Echos, também gostaríamos de alinhar os próximos passos da nossa relação.</p>

            //<p>A partir das informações que você nos enviou neste formulário faremos uma pré-seleção e entraremos em contato te convidando para uma entrevista, um Skype, ou um café mesmo. ;D
            //Como queremos analisar bem profundamente seu perfil esperamos entrar em contato com você em até 30 dias. Desde já pedimos desculpas pela demora.</p>
            //</br>
            //<p>Depois desta entrevista te daremos um retorno dizendo se o seu perfil é o que estamos buscando realmente. 
            //E em seguida voltaremos a entrar em contato com você sempre que tivermos um projeto que se encaixe no seu perfil e nas suas áreas de interesse.</p>

            //</br>
            //<p><b>IMPORTANTE:</b> se você tem alguma demanda de um projeto de inovação e gostaria de trazê-lo para trabalharmos juntos dê uma olhadinha na nossa seção de Parceiro de projetos na página: www.escoladesignthinking.com.br/</p>

            //<p>
            //Por enquanto é isso.
            //Mais uma vez obrigado pelo seu interesse em trabalhar conosco e nos vemos em breve. =)
            //</p>

            //Atenciosamente,
            //Design Echos.</p>";

            //mail.Body = Body;
            //mail.IsBodyHtml = true;
            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "relay-hosting.secureserver.net";
            //smtp.Port = 25;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new System.Net.NetworkCredential("echosteste@pogsp.com", "internet10");// Enter seders User name and password  
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

                MailMessage mailMsg = new MailMessage("admin@peopleechos.com", EmailTo, "Muito obrigado pelo seu interesse!", "my body");
                mailMsg.Body =  @"    <h1>Muito obrigado pelo seu interesse!</h1>
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

                mailMsg.IsBodyHtml = true;
                mailMsg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                ss.Send(mailMsg);
            }
            catch (Exception ex)
            {

                return Json(ex.ToString());
            }
           

            //EmailMessage m = new EmailMessage();
            //m.LogPath = "c:\\email.log";
            //m.Logging = true;

            //m.Server = "smtpout.secureserver.net";
            //m.Port = 465;
            //m.TimeOut = 10000;
            //m.Username = "testingaccount@comicidolonline.com";
            //m.Password = "abc123";

            //m.From = "testingaccount@comicidolonline.com";
            //m.To = "youremail@youremail.com";
            //m.Subject = "subject here";
            //m.Body = "my body";

            //AdvancedIntellect.Ssl.SslSocket ssl = new AdvancedIntellect.Ssl.SslSocket();
            ////load the SSL socket, but tell it to connect *before* the 220 Welcome response
            //m.LoadSslSocket(ssl, true);

            //m.Send();
            //Console.WriteLine("Sent email");  
      
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
            foreach (var respostaSkillTema in questaoSkillTema)
            {
                if (respostaSkillTema.idRespostaCheck > 0)
                {
                    var respostaContext = context.RespostaCheck.Find(respostaSkillTema.idRespostaCheck);
                    respostaContext.Resposta = respostaSkillTema.selecionado;
                    respostaContext.dataAlteracao = DateTime.Now;
                    context.Entry(respostaContext).State = EntityState.Modified;
                    context.SaveChanges();
                }
                else
                {
                    RespostaCheckModel.idQuestaoCheck = respostaSkillTema.perguntaCheckId;
                    RespostaCheckModel.idUsuario = idUser;
                    RespostaCheckModel.dataCriacao = DateTime.Now;
                    RespostaCheckModel.Resposta = respostaSkillTema.selecionado;
                    context.RespostaCheck.Add(RespostaCheckModel);
                    context.SaveChanges();
                }
            }
            foreach (var respostamercado in questaoMercado)
            {
                if (respostamercado.idRespostaCheck > 0)
                {
                    var respostaContext = context.RespostaCheck.Find(respostamercado.idRespostaCheck);
                    respostaContext.Resposta = respostamercado.selecionado;
                    respostaContext.dataAlteracao = DateTime.Now;
                    context.Entry(respostaContext).State = EntityState.Modified;
                    context.SaveChanges();
                }
                else
                {
                    RespostaCheckModel.idQuestaoCheck = respostamercado.perguntaCheckId;
                    RespostaCheckModel.idUsuario = idUser;
                    RespostaCheckModel.dataCriacao = DateTime.Now;
                    RespostaCheckModel.Resposta = respostamercado.selecionado;
                    context.RespostaCheck.Add(RespostaCheckModel);
                    context.SaveChanges();
                }
            }

            context.SaveChanges();
            context.Dispose();

            return View("../Home/IndexAuth");
            //return null;
        }

        [HttpPost]
        public ActionResult EnviarEmail()
        {
            //WebSecurity.CurrentUserName;
//            var email = new Viewmodels.MailModel();
//            email.Subject = "Muito obrigado pelo seu interesse!";
//            email.To = "paulinho.speed@hotmail.com";
//            email.From = "peopleechos@echos.cc";
//            MailMessage mail = new MailMessage();
//            mail.To.Add(email.To);
//            mail.From = new MailAddress(email.From);
//            mail.Subject = email.Subject;
//            string Body = @"    <h1>Muito obrigado pelo seu interesse!</h1>
//                <p>Oi!Tudo bem?</p>
//                <p>Além de dizer que estamos muito felizes pelo seu interesse em ser um consultor da Design Echos, também gostaríamos de alinhar os próximos passos da nossa relação.</p>
//
//                <p>A partir das informações que você nos enviou neste formulário faremos uma pré-seleção e entraremos em contato te convidando para uma entrevista, um Skype, ou um café mesmo. ;D
//                Como queremos analisar bem profundamente seu perfil esperamos entrar em contato com você em até 30 dias. Desde já pedimos desculpas pela demora.</p>
//                </br>
//                <p>Depois desta entrevista te daremos um retorno dizendo se o seu perfil é o que estamos buscando realmente. 
//                E em seguida voltaremos a entrar em contato com você sempre que tivermos um projeto que se encaixe no seu perfil e nas suas áreas de interesse.</p>
//
//                </br>
//                <p><b>IMPORTANTE:</b> se você tem alguma demanda de um projeto de inovação e gostaria de trazê-lo para trabalharmos juntos dê uma olhadinha na nossa seção de Parceiro de projetos na página: www.escoladesignthinking.com.br/</p>
//
//                <p>
//                Por enquanto é isso.
//                Mais uma vez obrigado pelo seu interesse em trabalhar conosco e nos vemos em breve. =)
//                </p>
//
//                Atenciosamente,
//                Design Echos.</p>";

//            mail.Body = Body;
//            mail.IsBodyHtml = true;
//            SmtpClient smtp = new SmtpClient();
//            smtp.Host = "smtp.gmail.com";
//            smtp.Port = 587;
//            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            

//            smtp.UseDefaultCredentials = false;
//            smtp.Credentials = new System.Net.NetworkCredential("peopleechos@echos.cc", "master2016");// Enter seders User name and password  
//            smtp.EnableSsl = true;
//            smtp.Send(mail);

//            SmtpClient client = new SmtpClient();

            SmtpClient ss = new SmtpClient();
            ss.Host = "smtpout.secureserver.net";
            ss.Port = 3535;
            ss.Timeout = 100000;
            ss.DeliveryMethod = SmtpDeliveryMethod.Network;
            ss.UseDefaultCredentials = false;
            ss.Credentials = new NetworkCredential("echosteste@pogsp.com", "internet10");
            ss.EnableSsl = false;

            MailMessage mailMsg = new MailMessage("echosteste@pogsp.com", "paulinho.speed@hotmail.com", "TESTE", "my body");
            mailMsg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            ss.Send(mailMsg);

            return null;
        }
       
    }
}
