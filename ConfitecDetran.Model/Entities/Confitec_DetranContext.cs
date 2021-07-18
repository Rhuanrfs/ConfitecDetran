using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ConfitecDetran.Model.Entities
{
    public partial class Confitec_DetranContext : DbContext
    {
        public Confitec_DetranContext()
        {
        }

        public Confitec_DetranContext(DbContextOptions<Confitec_DetranContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Condutor> Condutors { get; set; }
        public virtual DbSet<Transferencium> Transferencia { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Confitec_Detran;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Condutor>(entity =>
            {
                entity.HasKey(e => e.CodCondutor)
                    .HasName("PK__Condutor__5441CED4ADE7D1C2");

                entity.ToTable("Condutor");

                entity.Property(e => e.CodCondutor)
                    .ValueGeneratedNever()
                    .HasColumnName("Cod_Condutor");

                entity.Property(e => e.Cnh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CNH");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("Data_Nascimento");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telefone)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transferencium>(entity =>
            {
                entity.HasKey(e => e.CodTransferencia)
                    .HasName("PK__Transfer__4EBB96716923E8A9");

                entity.Property(e => e.CodTransferencia)
                    .ValueGeneratedNever()
                    .HasColumnName("Cod_Transferencia");

                entity.Property(e => e.CodCondutor).HasColumnName("Cod_Condutor");

                entity.Property(e => e.CodVeiculo).HasColumnName("Cod_Veiculo");

                entity.Property(e => e.DataFim)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Fim");

                entity.Property(e => e.DataInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_Inicio")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CodCondutorNavigation)
                    .WithMany(p => p.Transferencia)
                    .HasForeignKey(d => d.CodCondutor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transferencia_Condutor");

                entity.HasOne(d => d.CodVeiculoNavigation)
                    .WithMany(p => p.Transferencia)
                    .HasForeignKey(d => d.CodVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transferencia_Veiculo");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.CodUsuario)
                    .HasName("PK__Usuario__D16E26A6E84E87DB");

                entity.ToTable("Usuario");

                entity.Property(e => e.CodUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("Cod_Usuario");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Veiculo>(entity =>
            {
                entity.HasKey(e => e.CodVeiculo)
                    .HasName("PK__Veiculo__A4F949D12B0E86F8");

                entity.ToTable("Veiculo");

                entity.Property(e => e.CodVeiculo)
                    .ValueGeneratedNever()
                    .HasColumnName("Cod_Veiculo");

                entity.Property(e => e.Cor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
