//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity;
//using System.Globalization;
//using System.Web.Security;

//namespace HQ_Echos___WEB.Models
//{
//    public class AvaliacaoRever : DbContext
//    {
//        public AvaliacaoRever()
//            : base("DefaultConnection")
//        {
//        }

//        public DbSet<AvaliacaoRever> avaliacao { get; set; }
//        public DbSet<Fichaavaliacao> fichaavaliacao { get; set; }
//        public DbSet<Questao> questao { get; set; }
//        public DbSet<TipoQuestao> tipoQuestao { get; set; }
//        public DbSet<Resposta> resposta { get; set; }
//    }

//    [Table("Avaliacao")]
//    public class avaliacao
//    {
//        [Key]
//        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
//        public int idAvaliacao { get; set; }
//        public string nomeAvaliacao { get; set; }
//        public int idTipoAvaliacao { get; set; }
//        public DateTime dataCriacao { get; set; }
//        public DateTime dataAlteracao { get; set; }
//    }

//    public class Fichaavaliacao
//    {
//        [Key]
//        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
//        public int idAvaliacao { get; set; }
//        public string nomeAvaliacao { get; set; }
//        public int idTipoAvaliacao { get; set; }
//        public DateTime dataCriacao { get; set; }
//        public DateTime dataAlteracao { get; set; }
//    }

//    public class Questao 
//    {
//        [Key]
//        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
//        public int idQuestao { get; set; }
//        public int idTipoQuestao { get; set; }
//        public string Nome { get; set; }
//        public DateTime dataCriacao { get; set; }
//        public DateTime dataAlteracao { get; set; }
//    }

//    public class TipoQuestao
//    {
//         [Key]
//         [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
//         public int idTipoQuestao { get; set; }
//         public string DescTipo { get; set; }

//    }

//    public class Resposta
//    {
//        [Key]
//        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
//        public int idQuestao { get; set; }
//        public int idFichaAvalicao { get; set; }
//        public string Nome { get; set; }
//        public int idTipoQuestao { get; set; }
//        public DateTime dataCriacao { get; set; }
//        public DateTime dataAlteracao { get; set; }
//    }


//    //public class LocalPasswordModel
//    //{
//    //    [Required]
//    //    [DataType(DataType.Password)]
//    //    [Display(Name = "Current password")]
//    //    public string OldPassword { get; set; }

//    //    [Required]
//    //    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
//    //    [DataType(DataType.Password)]
//    //    [Display(Name = "New password")]
//    //    public string NewPassword { get; set; }

//    //    [DataType(DataType.Password)]
//    //    [Display(Name = "Confirm new password")]
//    //    [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
//    //    public string ConfirmPassword { get; set; }
//    //}

//    //public class LoginModel
//    //{
//    //    [Required]
//    //    [Display(Name = "User name")]
//    //    public string UserName { get; set; }

//    //    [Required]
//    //    [DataType(DataType.Password)]
//    //    [Display(Name = "Password")]
//    //    public string Password { get; set; }

//    //    [Display(Name = "Remember me?")]
//    //    public bool RememberMe { get; set; }
//    //}

//    //public class RegisterModel
//    //{
//    //    [Required]
//    //    [Display(Name = "User name")]
//    //    public string UserName { get; set; }

//    //    [Required]
//    //    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
//    //    [DataType(DataType.Password)]
//    //    [Display(Name = "Password")]
//    //    public string Password { get; set; }

//    //    [DataType(DataType.Password)]
//    //    [Display(Name = "Confirm password")]
//    //    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
//    //    public string ConfirmPassword { get; set; }
//    //}

//    //public class ExternalLogin
//    //{
//    //    public string Provider { get; set; }
//    //    public string ProviderDisplayName { get; set; }
//    //    public string ProviderUserId { get; set; }
//    //}
//}
