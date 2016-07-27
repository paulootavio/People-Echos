namespace HQ_Echos___WEB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Models")
        {
        }

        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<FichaAvaliacao> FichaAvaliacao { get; set; }
        public virtual DbSet<Questao> Questao { get; set; }
        public virtual DbSet<QuestaoCheck> QuestaoCheck { get; set; }
        public virtual DbSet<Resposta> Resposta { get; set; }
        public virtual DbSet<RespostaCheck> RespostaCheck { get; set; }
        public virtual DbSet<TipoQuestao> TipoQuestao { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<Users> Users { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avaliacao>()
                .Property(e => e.nomeAvaliacao)
                .IsUnicode(false);

    
            modelBuilder.Entity<Questao>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Questao>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Resposta>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TipoQuestao>()
                .Property(e => e.DescTipo)
                .IsFixedLength();
        }
    }

    public partial class Resposta1 : DbContext
    {
        public Resposta1()
            : base("name=Models")
        {
        }

        public virtual DbSet<RespostaCheck> RespostaCheck { get; set; }
        public virtual DbSet<Resposta> Resposta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resposta>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<RespostaCheck>();


        }
    }
    
}