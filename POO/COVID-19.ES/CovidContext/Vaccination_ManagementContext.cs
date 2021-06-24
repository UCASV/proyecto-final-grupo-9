using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Vaccination_ManagementContext : DbContext
    {
        public Vaccination_ManagementContext()
        {
        }

        public Vaccination_ManagementContext(DbContextOptions<Vaccination_ManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment1> Appointment1s { get; set; }
        public virtual DbSet<Appointment2> Appointment2s { get; set; }
        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Cabinxappointment1> Cabinxappointment1s { get; set; }
        public virtual DbSet<Cabinxappointment2> Cabinxappointment2s { get; set; }
        public virtual DbSet<ChronicDisease> ChronicDiseases { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Dose1> Dose1s { get; set; }
        public virtual DbSet<Dose1xsideEffect> Dose1xsideEffects { get; set; }
        public virtual DbSet<Dose2> Dose2s { get; set; }
        public virtual DbSet<Dose2xsideEffect> Dose2xsideEffects { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<PriorityGroup> PriorityGroups { get; set; }
        public virtual DbSet<RegistrationStart> RegistrationStarts { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<WaitRow1> WaitRow1s { get; set; }
        public virtual DbSet<WaitRow2> WaitRow2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NVUFJE1;DataBase=Vaccination_Management;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Appointment1>(entity =>
            {
                entity.ToTable("APPOINTMENT_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.DuiCitizen).HasColumnName("dui_citizen");

                entity.Property(e => e.Place)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Appointment1s)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CITIZENXAPPOINTMET_1");
            });

            modelBuilder.Entity<Appointment2>(entity =>
            {
                entity.ToTable("APPOINTMENT_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.DuiCitizen).HasColumnName("dui_citizen");

                entity.Property(e => e.Place)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Appointment2s)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CITIZENXAPPOINTMET_2");
            });

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("CABIN");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Direction)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("direction");

                entity.Property(e => e.Mail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Phone)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Position)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("position");
            });

            modelBuilder.Entity<Cabinxappointment1>(entity =>
            {
                entity.HasKey(e => new { e.IdCabin, e.IdAppointment1 })
                    .HasName("PK_CABINXAPPOINTMET_1");

                entity.ToTable("CABINXAPPOINTMENT_1");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdAppointment1).HasColumnName("id_appointment_1");

                entity.HasOne(d => d.IdAppointment1Navigation)
                    .WithMany(p => p.Cabinxappointment1s)
                    .HasForeignKey(d => d.IdAppointment1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CABINXAPP__id_ap__3C69FB99");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Cabinxappointment1s)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CABINXAPP__id_ca__3B75D760");
            });

            modelBuilder.Entity<Cabinxappointment2>(entity =>
            {
                entity.HasKey(e => new { e.IdCabin, e.IdAppointment2 })
                    .HasName("PK_CABINXAPPOINTMET_2");

                entity.ToTable("CABINXAPPOINTMENT_2");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdAppointment2).HasColumnName("id_appointment_2");

                entity.HasOne(d => d.IdAppointment2Navigation)
                    .WithMany(p => p.Cabinxappointment2s)
                    .HasForeignKey(d => d.IdAppointment2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CABINXAPP__id_ap__403A8C7D");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Cabinxappointment2s)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CABINXAPP__id_ca__3F466844");
            });

            modelBuilder.Entity<ChronicDisease>(entity =>
            {
                entity.ToTable("CHRONIC_DISEASE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DuiCitizen).HasColumnName("dui_citizen");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.ChronicDiseases)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CITIZENXCHRONIC_DISEASE");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CITIZEN__D876F1BE4BEAA863");

                entity.ToTable("CITIZEN");

                entity.Property(e => e.Dui)
                    .ValueGeneratedNever()
                    .HasColumnName("dui");

                entity.Property(e => e.Direction)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("direction");

                entity.Property(e => e.Mail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Dose1>(entity =>
            {
                entity.ToTable("DOSE_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.DuiCitizen).HasColumnName("dui_citizen");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Dose1s)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CITIZENXDOSE_1");
            });

            modelBuilder.Entity<Dose1xsideEffect>(entity =>
            {
                entity.HasKey(e => new { e.IdSideEffect, e.IdDose1 });

                entity.ToTable("DOSE_1XSIDE_EFFECT");

                entity.Property(e => e.IdSideEffect).HasColumnName("id_side_effect");

                entity.Property(e => e.IdDose1).HasColumnName("id_dose_1");

                entity.Property(e => e.Time)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("time");

                entity.HasOne(d => d.IdDose1Navigation)
                    .WithMany(p => p.Dose1xsideEffects)
                    .HasForeignKey(d => d.IdDose1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DOSE_1XSI__id_do__52593CB8");

                entity.HasOne(d => d.IdSideEffectNavigation)
                    .WithMany(p => p.Dose1xsideEffects)
                    .HasForeignKey(d => d.IdSideEffect)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DOSE_1XSI__id_si__5165187F");
            });

            modelBuilder.Entity<Dose2>(entity =>
            {
                entity.ToTable("DOSE_2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.DuiCitizen).HasColumnName("dui_citizen");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Dose2s)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CITIZENXDOSE_2");
            });

            modelBuilder.Entity<Dose2xsideEffect>(entity =>
            {
                entity.HasKey(e => new { e.IdSideEffect, e.IdDose2 });

                entity.ToTable("DOSE_2XSIDE_EFFECT");

                entity.Property(e => e.IdSideEffect).HasColumnName("id_side_effect");

                entity.Property(e => e.IdDose2).HasColumnName("id_dose_2");

                entity.Property(e => e.Time)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("time");

                entity.HasOne(d => d.IdDose2Navigation)
                    .WithMany(p => p.Dose2xsideEffects)
                    .HasForeignKey(d => d.IdDose2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DOSE_2XSI__id_do__5629CD9C");

                entity.HasOne(d => d.IdSideEffectNavigation)
                    .WithMany(p => p.Dose2xsideEffects)
                    .HasForeignKey(d => d.IdSideEffect)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DOSE_2XSI__id_si__5535A963");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.ToTable("INSTITUTION");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DuiCitizen).HasColumnName("dui_citizen");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Institutions)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CITIZENXINSTITUTION");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("MANAGER");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EmployeeType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("employee_type");

                entity.Property(e => e.HomeDirection)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("home_direction");

                entity.Property(e => e.InstitutionalMail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("institutional_mail");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<PriorityGroup>(entity =>
            {
                entity.ToTable("PRIORITY_GROUP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DuiCitizen).HasColumnName("dui_citizen");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.PriorityGroups)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CITIZENXPRIORITY_GROUP");
            });

            modelBuilder.Entity<RegistrationStart>(entity =>
            {
                entity.HasKey(e => new { e.IdManager, e.IdCabin })
                    .HasName("PK_MANAGERXCABIN");

                entity.ToTable("REGISTRATION_START");

                entity.Property(e => e.IdManager).HasColumnName("id_manager");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.RegistrationStarts)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REGISTRAT__id_ca__38996AB5");

                entity.HasOne(d => d.IdManagerNavigation)
                    .WithMany(p => p.RegistrationStarts)
                    .HasForeignKey(d => d.IdManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REGISTRAT__id_ma__37A5467C");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.ToTable("SIDE_EFFECT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<WaitRow1>(entity =>
            {
                entity.ToTable("WAIT_ROW1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.DuiAppointment1).HasColumnName("dui_appointment_1");

                entity.HasOne(d => d.DuiAppointment1Navigation)
                    .WithMany(p => p.WaitRow1s)
                    .HasForeignKey(d => d.DuiAppointment1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPOINTMENT_1XWAIT_ROW1");
            });

            modelBuilder.Entity<WaitRow2>(entity =>
            {
                entity.ToTable("WAIT_ROW2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.DuiAppointment2).HasColumnName("dui_appointment_2");

                entity.HasOne(d => d.DuiAppointment2Navigation)
                    .WithMany(p => p.WaitRow2s)
                    .HasForeignKey(d => d.DuiAppointment2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APPOINTMENT_2XWAIT_ROW2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
