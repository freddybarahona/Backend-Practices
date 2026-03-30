using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using pr_DBContext.Domaind.Database.SqlServer.Entities;

namespace pr_DBContext.Domaind.Database.SqlServer.Context;

public partial class SocialAppDbContext : DbContext
{
    public SocialAppDbContext()
    {
    }

    public SocialAppDbContext(DbContextOptions<SocialAppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<Like> Likes { get; set; }

    public virtual DbSet<Mensaje> Mensajes { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Seguidore> Seguidores { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;User=sa;Password=Admin1234@;Database=socialAppDB;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Texto).HasMaxLength(150);

            entity.HasOne(d => d.Post).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comentarios_Posts");

            entity.HasOne(d => d.User).WithMany(p => p.Comentarios)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Comentarios_Usuarios");
        });

        modelBuilder.Entity<Like>(entity =>
        {
            entity.HasIndex(e => new { e.UserId, e.PostId }, "UQ_UserId_PostId").IsUnique();

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Post).WithMany(p => p.Likes)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Likes_Posts");

            entity.HasOne(d => d.User).WithMany(p => p.Likes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Likes_Usuarios");
        });

        modelBuilder.Entity<Mensaje>(entity =>
        {
            entity.Property(e => e.Content).HasMaxLength(400);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Receiver).WithMany(p => p.MensajeReceivers)
                .HasForeignKey(d => d.ReceiverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mensajes_DestinyId");

            entity.HasOne(d => d.Remitente).WithMany(p => p.MensajeRemitentes)
                .HasForeignKey(d => d.RemitenteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mensajes_Remitente");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.Property(e => e.Content).HasMaxLength(300);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.User).WithMany(p => p.Posts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Posts_Usuarios");
        });

        modelBuilder.Entity<Seguidore>(entity =>
        {
            entity.HasKey(e => new { e.FollowerId, e.FollowingId });

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Follower).WithMany(p => p.SeguidoreFollowers)
                .HasForeignKey(d => d.FollowerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Seguidores_Follower");

            entity.HasOne(d => d.Following).WithMany(p => p.SeguidoreFollowings)
                .HasForeignKey(d => d.FollowingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Seguidores_Following");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasIndex(e => e.Email, "UQ_Usuarios_Email").IsUnique();

            entity.HasIndex(e => e.Username, "UQ_Usuarios_Username").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
