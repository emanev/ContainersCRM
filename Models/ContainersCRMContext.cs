using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContainersCRM.Models
{
    public partial class ContainersCRMContext : DbContext
    {
        public ContainersCRMContext()
        {
        }

        public ContainersCRMContext(DbContextOptions<ContainersCRMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ContainerCapacity> ContainerCapacity { get; set; }
        public virtual DbSet<ContainerColour> ContainerColour { get; set; }
        public virtual DbSet<ContainerMaterialType> ContainerMaterialType { get; set; }
        public virtual DbSet<Containers> Containers { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Movement> Movement { get; set; }
        public virtual DbSet<ObjectTypes> ObjectTypes { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<SrsobjectIndustrial> SrsobjectIndustrial { get; set; }
        public virtual DbSet<SrsobjectIndustrialContainer> SrsobjectIndustrialContainer { get; set; }
        public virtual DbSet<SrsobjectIndustrialSchema> SrsobjectIndustrialSchema { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-722117P0\\EMO;Database=ContainersCRM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ContainerCapacity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ContainerColour>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ContainerMaterialType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Containers>(entity =>
            {
                entity.Property(e => e.InventarNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ContainerCapacity)
                    .WithMany(p => p.Containers)
                    .HasForeignKey(d => d.ContainerCapacityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Containers_ContainerCapacity");

                entity.HasOne(d => d.ContainerColour)
                    .WithMany(p => p.Containers)
                    .HasForeignKey(d => d.ContainerColourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Containers_ContainerColour");

                entity.HasOne(d => d.ContainerMaterialType)
                    .WithMany(p => p.Containers)
                    .HasForeignKey(d => d.ContainerMaterialTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Containers_ContainerMaterialType");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_District_City");
            });

            modelBuilder.Entity<Movement>(entity =>
            {
                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.Movement)
                    .HasForeignKey(d => d.ContainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movement_Containers");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Movement)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movement_User");

                entity.HasOne(d => d.WarehouseFrom)
                    .WithMany(p => p.MovementWarehouseFrom)
                    .HasForeignKey(d => d.WarehouseFromId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movement_Warehouse1");

                entity.HasOne(d => d.WarehouseTo)
                    .WithMany(p => p.MovementWarehouseTo)
                    .HasForeignKey(d => d.WarehouseToId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movement_Warehouse");
            });

            modelBuilder.Entity<ObjectTypes>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.Property(e => e.RaiseDate).HasColumnType("datetime");

                entity.Property(e => e.SrsobjectId).HasColumnName("SRSObjectId");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_City");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_District");

                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_ObjectTypes");

                entity.HasOne(d => d.Srsobject)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.SrsobjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_SRSObjectIndustrial");
            });

            modelBuilder.Entity<SrsobjectIndustrial>(entity =>
            {
                entity.ToTable("SRSObjectIndustrial");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.ContactPerson).IsRequired();

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.District)
                    .WithMany(p => p.SrsobjectIndustrial)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRSObjectIndustrial_District");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SrsobjectIndustrial)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRSObjectIndustrial_User");
            });

            modelBuilder.Entity<SrsobjectIndustrialContainer>(entity =>
            {
                entity.ToTable("SRSObjectIndustrialContainer");

                entity.Property(e => e.SrsobjectIndustrialId).HasColumnName("SRSObjectIndustrialId");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.SrsobjectIndustrialContainer)
                    .HasForeignKey(d => d.ContainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRSObjectIndustrialContainer_Containers");

                entity.HasOne(d => d.Movement)
                    .WithMany(p => p.SrsobjectIndustrialContainer)
                    .HasForeignKey(d => d.MovementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRSObjectIndustrialContainer_Movement");

                entity.HasOne(d => d.SrsobjectIndustrial)
                    .WithMany(p => p.SrsobjectIndustrialContainer)
                    .HasForeignKey(d => d.SrsobjectIndustrialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRSObjectIndustrialContainer_SRSObjectIndustrial");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SrsobjectIndustrialContainer)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRSObjectIndustrialContainer_User");
            });

            modelBuilder.Entity<SrsobjectIndustrialSchema>(entity =>
            {
                entity.ToTable("SRSObjectIndustrialSchema");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Hour)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SrsobjectIndustrialId).HasColumnName("SRSObjectIndustrialId");

                entity.HasOne(d => d.SrsobjectIndustrial)
                    .WithMany(p => p.SrsobjectIndustrialSchema)
                    .HasForeignKey(d => d.SrsobjectIndustrialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRSObjectIndustrialSchema_SRSObjectIndustrial");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SrsobjectIndustrialSchema)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SRSObjectIndustrialSchema_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Roles");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.ContactPerson)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Warehouse)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_City");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Warehouse)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_District");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Warehouse)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
