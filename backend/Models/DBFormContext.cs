using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace backend.Models
{
    public partial class DBFormContext : DbContext
    {
        public DBFormContext(DbContextOptions<DBFormContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Detail> Details { get; set; } = null!;
        public virtual DbSet<Form> Forms { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, ysou should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, 
//                see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QQ24FM7\\SQLEXPRESS;Database=DBForm;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detail>(entity =>
            {
                entity.Property(e => e.LabelText)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Label_text");

                entity.Property(e => e.MaxCalendrier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Max_Calendrier");

                entity.Property(e => e.MinCalendrier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Min_Calendrier");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceHolder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeBtn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeCmp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeInput)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Type_Input");

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.HasKey(e => e.IdForm);

                entity.ToTable("Form");

                entity.Property(e => e.IdForm).HasColumnName("Id_Form");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_creation");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.NameForm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_Form");

                entity.Property(e => e.NbrComposants).HasColumnName("Nbr_composants");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Forms)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Form_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fullname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
