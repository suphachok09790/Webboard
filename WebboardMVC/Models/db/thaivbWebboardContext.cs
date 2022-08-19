using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebboardMVC.Models.db
{
    public partial class thaivbWebboardContext : DbContext
    {
        public thaivbWebboardContext()
        {
        }

        public thaivbWebboardContext(DbContextOptions<thaivbWebboardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Kratoo> Kratoos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=thaivbWebboard;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(255);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => new { e.Kid, e.CommentNo })
                    .HasName("PK__Reply__B873363C4B81568C");

                entity.Property(e => e.Kid).HasColumnName("KID");

                entity.Property(e => e.CommentNo).HasColumnName("CommentNO");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ReplyDate).HasColumnType("datetime");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(100)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.KidNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.Kid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reply_Topic");
            });

            modelBuilder.Entity<Kratoo>(entity =>
            {
                entity.HasKey(e => e.Kid)
                    .HasName("PK__Topic__C456D729EF6C2ECF");

                entity.Property(e => e.Kid).HasColumnName("KID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.KratooDetails).HasMaxLength(255);

                entity.Property(e => e.KratooTopic).HasMaxLength(100);

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(100)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Kratoos)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kratoos_Categories");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
