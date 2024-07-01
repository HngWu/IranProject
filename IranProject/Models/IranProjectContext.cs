using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IranProject.Models
{
    public partial class IranProjectContext : DbContext
    {
        public IranProjectContext()
        {
        }

        public IranProjectContext(DbContextOptions<IranProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Saloon> Saloon { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<SurveyAnswer> SurveyAnswer { get; set; }
        public virtual DbSet<SurveyOption> SurveyOption { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<WorkshopRequest> WorkshopRequest { get; set; }
        public virtual DbSet<WorkshopTime> WorkshopTime { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=IranProject;Trusted_Connection=true;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Saloon>(entity =>
            {
                entity.Property(e => e.SaloonName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SurveyName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SurveyAnswer>(entity =>
            {
                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyAnswer)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Survey_SurveyAnswer");

                entity.HasOne(d => d.SurveyOption)
                    .WithMany(p => p.SurveyAnswer)
                    .HasForeignKey(d => d.SurveyOptionId)
                    .HasConstraintName("FK_SurveyOption_SurveyAnswer");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SurveyAnswer)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_ServeyAnswer");
            });

            modelBuilder.Entity<SurveyOption>(entity =>
            {
                entity.Property(e => e.SurveyOptionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyOption)
                    .HasForeignKey(d => d.SurveyId)
                    .HasConstraintName("FK_Survey_SurveyOption");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Fullname).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserType_User");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.UserTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<WorkshopRequest>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.WorkshopRequest)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Category_WorkshopRequest");

                entity.HasOne(d => d.Saloon)
                    .WithMany(p => p.WorkshopRequest)
                    .HasForeignKey(d => d.SaloonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Saloon_WorkshopRequest");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WorkshopRequest)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_WorkshopRequest");

                entity.HasOne(d => d.WorkshopTime)
                    .WithMany(p => p.WorkshopRequest)
                    .HasForeignKey(d => d.WorkshopTimeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkshopTime_WorkshopRequest");
            });

            modelBuilder.Entity<WorkshopTime>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
