using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace AssignmentPRN.Models
{
    public partial class Assignment_PRNContext : DbContext
    {
        public Assignment_PRNContext()
        {
        }

        public Assignment_PRNContext(DbContextOptions<Assignment_PRNContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<CorrectAnswer> CorrectAnswers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<TestName> TestNames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                optionsBuilder.UseSqlServer("server=localhost; database=Assignment_PRN; uid=luongnthhe151453;password=14052001");
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("DBContext"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnswerContent).HasColumnName("answerContent");

                entity.Property(e => e.QuestionId).HasColumnName("questionId");
            });

            modelBuilder.Entity<CorrectAnswer>(entity =>
            {
                entity.HasKey(e => new { e.QuestionId, e.AnswerId });

                entity.Property(e => e.QuestionId).HasColumnName("questionId");

                entity.Property(e => e.AnswerId).HasColumnName("answerId");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.CorrectAnswers)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CorrectAnswers_Answer");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.CorrectAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CorrectAnswers_Questions");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.Qid);

                entity.Property(e => e.Qid).HasColumnName("qid");

                entity.Property(e => e.QContent).HasColumnName("qContent");

                entity.Property(e => e.TestId).HasColumnName("testId");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK_Questions_TestName");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.TestId });

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.Score)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("score");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Results_Account");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Results_TestName");
            });

            modelBuilder.Entity<TestName>(entity =>
            {
                entity.ToTable("TestName");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.TestCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("testCode");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
