using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Projectcriczee
{
    public partial class CrickzeedbContext : DbContext
    {
        public CrickzeedbContext()
        {
        }

        public CrickzeedbContext(DbContextOptions<CrickzeedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChennaiSuperKing> ChennaiSuperKings { get; set; }
        public virtual DbSet<DelhiCapital> DelhiCapitals { get; set; }
        public virtual DbSet<KingsXipunjab> KingsXipunjabs { get; set; }
        public virtual DbSet<KolkataKnightRider> KolkataKnightRiders { get; set; }
        public virtual DbSet<MumbaiIndian> MumbaiIndians { get; set; }
        public virtual DbSet<PointsTable> PointsTables { get; set; }
        public virtual DbSet<RajasthanRoyal> RajasthanRoyals { get; set; }
        public virtual DbSet<RoyalChallengersBanglore> RoyalChallengersBanglores { get; set; }
        public virtual DbSet<SunRisesHyderabad> SunRisesHyderabads { get; set; }
        public virtual DbSet<TopBatsmen> TopBatsmens { get; set; }
        public virtual DbSet<TopBowler> TopBowlers { get; set; }
        public virtual DbSet<TopFielder> TopFielders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=LAPTOP-QDJ4SJPA;database=Crickzeedb;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChennaiSuperKing>(entity =>
            {
                entity.HasKey(e => e.Player)
                    .HasName("PK__ChennaiS__7CA37A1FDB9DD868");

                entity.Property(e => e.Player).HasMaxLength(50);

                entity.Property(e => e.PlayerId).ValueGeneratedOnAdd();

                entity.Property(e => e.PlayerRole).HasMaxLength(50);

                entity.Property(e => e.Price).HasMaxLength(50);
            });

            modelBuilder.Entity<DelhiCapital>(entity =>
            {
                entity.HasKey(e => e.Player)
                    .HasName("PK__DelhiCap__7CA37A1F5CF5BC85");

                entity.Property(e => e.Player).HasMaxLength(50);

                entity.Property(e => e.PlayerId).ValueGeneratedOnAdd();

                entity.Property(e => e.PlayerRole).HasMaxLength(50);

                entity.Property(e => e.Price).HasMaxLength(50);
            });

            modelBuilder.Entity<KingsXipunjab>(entity =>
            {
                entity.HasKey(e => e.Player)
                    .HasName("PK__KingsXIP__7CA37A1F1BD71844");

                entity.ToTable("KingsXIPunjab");

                entity.Property(e => e.Player).HasMaxLength(50);

                entity.Property(e => e.PlayerId).ValueGeneratedOnAdd();

                entity.Property(e => e.PlayerRole).HasMaxLength(50);

                entity.Property(e => e.Price).HasMaxLength(50);
            });

            modelBuilder.Entity<KolkataKnightRider>(entity =>
            {
                entity.HasKey(e => e.Player)
                    .HasName("PK__KolkataK__7CA37A1F187EF251");

                entity.Property(e => e.Player).HasMaxLength(50);

                entity.Property(e => e.PlayerId).ValueGeneratedOnAdd();

                entity.Property(e => e.PlayerRole).HasMaxLength(50);

                entity.Property(e => e.Price).HasMaxLength(50);
            });

            modelBuilder.Entity<MumbaiIndian>(entity =>
            {
                entity.HasKey(e => e.Player)
                    .HasName("PK__MumbaiIn__7CA37A1F9C9D3EEE");

                entity.Property(e => e.Player).HasMaxLength(50);

                entity.Property(e => e.PlayerId).ValueGeneratedOnAdd();

                entity.Property(e => e.PlayerRole).HasMaxLength(50);

                entity.Property(e => e.Price).HasMaxLength(50);
            });

            modelBuilder.Entity<PointsTable>(entity =>
            {
                entity.HasKey(e => e.Teams)
                    .HasName("PK__PointsTa__5709C6D5FF328381");

                entity.ToTable("PointsTable");

                entity.Property(e => e.Teams).HasMaxLength(50);

                entity.Property(e => e.Nrr)
                    .HasMaxLength(50)
                    .HasColumnName("NRR");

                entity.Property(e => e.Nrrposition).HasColumnName("NRRPosition");

                entity.Property(e => e.TeamId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RajasthanRoyal>(entity =>
            {
                entity.HasKey(e => e.Player)
                    .HasName("PK__Rajastha__7CA37A1FEA0AE392");

                entity.Property(e => e.Player).HasMaxLength(50);

                entity.Property(e => e.PlayerId).ValueGeneratedOnAdd();

                entity.Property(e => e.PlayerRole).HasMaxLength(50);

                entity.Property(e => e.Price).HasMaxLength(50);
            });

            modelBuilder.Entity<RoyalChallengersBanglore>(entity =>
            {
                entity.HasKey(e => e.Player)
                    .HasName("PK__RoyalCha__7CA37A1FD54C3FD2");

                entity.ToTable("RoyalChallengersBanglore");

                entity.Property(e => e.Player).HasMaxLength(50);

                entity.Property(e => e.PlayerId).ValueGeneratedOnAdd();

                entity.Property(e => e.PlayerRole).HasMaxLength(50);

                entity.Property(e => e.Price).HasMaxLength(50);
            });

            modelBuilder.Entity<SunRisesHyderabad>(entity =>
            {
                entity.HasKey(e => e.Player)
                    .HasName("PK__SunRises__7CA37A1F21356DA7");

                entity.ToTable("SunRisesHyderabad");

                entity.Property(e => e.Player).HasMaxLength(50);

                entity.Property(e => e.PlayerId).ValueGeneratedOnAdd();

                entity.Property(e => e.PlayerRole).HasMaxLength(50);

                entity.Property(e => e.Price).HasMaxLength(50);
            });

            modelBuilder.Entity<TopBatsmen>(entity =>
            {
                entity.HasKey(e => e.Player)
                    .HasName("PK__TopBatsm__7CA37A1F75724705");

                entity.Property(e => e.Player).HasMaxLength(50);

                entity.Property(e => e.PlayerId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TopBowler>(entity =>
            {
                entity.HasKey(e => e.Player)
                    .HasName("PK__TopBowle__7CA37A1FE60118E3");

                entity.Property(e => e.Player).HasMaxLength(50);

                entity.Property(e => e.PlayerId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TopFielder>(entity =>
            {
                entity.HasKey(e => e.Player)
                    .HasName("PK__TopField__7CA37A1F1F83CB8D");

                entity.Property(e => e.Player).HasMaxLength(50);

                entity.Property(e => e.PlayerId).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
