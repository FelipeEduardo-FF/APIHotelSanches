using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CodeFirstExistingDatabaseSample
{
    public partial class Db_HotelContext : DbContext
    {
        public Db_HotelContext()
        {
        }

        public Db_HotelContext(DbContextOptions<Db_HotelContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<CheckIn> CheckIns { get; set; }
        public virtual DbSet<CheckOut> CheckOuts { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Comodo> Comodos { get; set; }
        public virtual DbSet<ComodoDeQuarto> ComodoDeQuartos { get; set; }
        public virtual DbSet<Estoque> Estoques { get; set; }
        public virtual DbSet<Frigobar> Frigobars { get; set; }
        public virtual DbSet<TbFuncao> Funcaos { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<ItemFrigobar> ItemFrigobars { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Quarto> Quartos { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<TipoQuarto> TipoQuartos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                                                        //NOME DO PC                     //NOME DO BANCO DE DADOS
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-N9SU4J9;Initial Catalog=Db_Hotel;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<CheckIn>(entity =>
            {
                entity.HasKey(e => e.IdCheckIn)
                    .HasName("PK__Check_in__84D8ECF13F93015F");

                entity.ToTable("Check_in");

                entity.Property(e => e.IdCheckIn).HasColumnName("IdCheck_in");

                entity.Property(e => e.DataHoraChekIn)
                    .HasColumnType("datetime")
                    .HasColumnName("DataHoraChek_in");

                entity.HasOne(d => d.Reserva)
                    .WithMany(p => p.CheckIns)
                    .HasForeignKey(d => d.IdReserva)
                    .HasConstraintName("FK__Check_in__IdRese__47DBAE45");
            });

            modelBuilder.Entity<CheckOut>(entity =>
            {
                entity.HasKey(e => e.IdCheckOut)
                    .HasName("PK__Check_ou__190524300722F8AD");

                entity.ToTable("Check_out");

                entity.Property(e => e.IdCheckOut).HasColumnName("IdCheck_out");

                entity.Property(e => e.DataHoraChekOut)
                    .HasColumnType("datetime")
                    .HasColumnName("DataHoraChek_out");

                entity.Property(e => e.ValorTotal).HasColumnType("numeric(9, 2)");

                entity.HasOne(d => d.Reserva)
                    .WithMany(p => p.CheckOuts)
                    .HasForeignKey(d => d.IdReserva)
                    .HasConstraintName("FK__Check_out__IdRes__4AB81AF0");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Tb_Categ__A3C02A10C113ED00");

                entity.ToTable("Tb_Categoria");

                entity.Property(e => e.DescricaoCategoria)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Tb_Clien__D5946642482289C2");

                entity.ToTable("Tb_Cliente");

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdPessoa)
                    .HasConstraintName("FK__Tb_Client__IdPes__2C3393D0");
            });

            modelBuilder.Entity<Comodo>(entity =>
            {
                entity.HasKey(e => e.IdComodo)
                    .HasName("PK__Tb_Comod__0A1008A6FCE83B05");

                entity.ToTable("Tb_Comodo");

                entity.Property(e => e.DescricaoComodo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComodoDeQuarto>(entity =>
            {
                entity.HasKey(e => new { e.IdComodo, e.IdTipoQuarto })
                    .HasName("PK__Tb_Comod__9770C31C987930D1");

                entity.ToTable("Tb_ComodoDeQuarto");
            });

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.HasKey(e => e.IdEstoque)
                    .HasName("PK__Tb_Estoq__82C4C02AA9250A9F");

                entity.ToTable("Tb_Estoque");

                entity.Property(e => e.DescricaoEstoque)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Frigobar>(entity =>
            {
                entity.HasKey(e => e.IdFrigobar)
                    .HasName("PK__Tb_Frigo__AC84952C788A0FB7");

                entity.ToTable("Tb_Frigobar");

                entity.HasOne(d => d.IdQuartoNavigation)
                    .WithMany(p => p.Frigobars)
                    .HasForeignKey(d => d.IdQuarto)
                    .HasConstraintName("FK__Tb_Frigob__IdQua__3F466844");
            });

            modelBuilder.Entity<TbFuncao>(entity =>
            {
                entity.HasKey(e => e.IdFuncao)
                    .HasName("PK__Tb_Funca__CE75DBD24C6F18F7");

                entity.ToTable("Tb_Funcao");

                entity.Property(e => e.DescricaoFuncao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Funcao)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PK__Tb_Funci__35CB052A936319D5");

                entity.ToTable("Tb_Funcionario");

                entity.Property(e => e.DataContratacao).HasColumnType("date");

                entity.Property(e => e.SalarioFuncionario).HasColumnType("numeric(9, 2)");

                entity.HasOne(d => d.Funcao)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.IdFuncao)
                    .HasConstraintName("FK__Tb_Funcio__IdFun__286302EC");

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.Funcionarios)
                    .HasForeignKey(d => d.IdPessoa)
                    .HasConstraintName("FK__Tb_Funcio__IdPes__29572725");
            });

            modelBuilder.Entity<ItemFrigobar>(entity =>
            {
                entity.HasKey(e => new { e.IdFrigobar, e.IdProduto })
                    .HasName("PK__Tb_ItemF__8E6C16EECF074180");

                entity.ToTable("Tb_ItemFrigobar");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(e => e.IdPessoa)
                    .HasName("PK__TB_Pesso__7061465D12E01DCA");

                entity.ToTable("TB_Pessoa");

                entity.Property(e => e.CpfPessoa)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.EmailPessoa)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NomePessoa)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.IdProduto)
                    .HasName("PK__Tb_Produ__2E883C236AAD80BC");

                entity.ToTable("Tb_Produto");

                entity.Property(e => e.DescricaoProduto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValorCompra).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ValorVenda).HasColumnType("numeric(9, 2)");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Tb_Produt__IdCat__32E0915F");

                entity.HasOne(d => d.IdEstoqueNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdEstoque)
                    .HasConstraintName("FK__Tb_Produt__IdEst__33D4B598");
            });

            modelBuilder.Entity<Quarto>(entity =>
            {
                entity.HasKey(e => e.NumeroQuarto)
                    .HasName("PK__Tb_Quart__DAD94D864152BDDA");

                entity.ToTable("Tb_Quartos");

                entity.Property(e => e.NumeroQuarto).ValueGeneratedNever();

                entity.Property(e => e.DescricaoQuarto)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValorDiaria).HasColumnType("numeric(9, 2)");

                entity.HasOne(d => d.IdTipoQuartoNavigation)
                    .WithMany(p => p.Quartos)
                    .HasForeignKey(d => d.IdTipoQuarto)
                    .HasConstraintName("FK__Tb_Quarto__IdTip__3C69FB99");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva)
                    .HasName("PK__TB_Reser__0E49C69D95E58452");

                entity.ToTable("TB_Reserva");

                entity.Property(e => e.DtFinalReserva).HasColumnType("date");

                entity.Property(e => e.DtInicialReserva).HasColumnType("date");

                entity.Property(e => e.StatusReserva).HasColumnName("statusReserva");

                entity.Property(e => e.ValorPago).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ValorTotal).HasColumnType("numeric(9, 2)");

                entity.HasOne(d => d.Pessoa)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Reserv__IdPes__440B1D61");

                entity.HasOne(d => d.Quarto)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdQuarto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TB_Reserv__IdQua__44FF419A");
            });

            modelBuilder.Entity<TipoQuarto>(entity =>
            {
                entity.HasKey(e => e.IdTipoQuarto)
                    .HasName("PK__Tb_TipoQ__D60CBBA8300BA62C");

                entity.ToTable("Tb_TipoQuarto");

                entity.Property(e => e.DescricaoTipo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
