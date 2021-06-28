﻿// <auto-generated />
using System;
using COVID_19.ES.CovidContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COVID_19.ES.Migrations
{
    [DbContext(typeof(Vaccination_ManagementContext))]
    [Migration("20210628015610_migration2")]
    partial class migration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COVID_19.ES.CovidContext.Appointment1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time");

                    b.Property<int>("DuiCitizen")
                        .HasColumnType("int")
                        .HasColumnName("dui_citizen");

                    b.Property<string>("Place")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("place");

                    b.HasKey("Id");

                    b.HasIndex("DuiCitizen");

                    b.ToTable("APPOINTMENT_1");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Appointment2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time");

                    b.Property<int>("DuiCitizen")
                        .HasColumnType("int")
                        .HasColumnName("dui_citizen");

                    b.Property<string>("Place")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("place");

                    b.HasKey("Id");

                    b.HasIndex("DuiCitizen");

                    b.ToTable("APPOINTMENT_2");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Cabin", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Direction")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("direction");

                    b.Property<string>("Mail")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("mail");

                    b.Property<string>("Phone")
                        .HasMaxLength(9)
                        .IsUnicode(false)
                        .HasColumnType("varchar(9)")
                        .HasColumnName("phone");

                    b.Property<string>("Position")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("position");

                    b.HasKey("Id");

                    b.ToTable("CABIN");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Cabinxappointment1", b =>
                {
                    b.Property<int>("IdCabin")
                        .HasColumnType("int")
                        .HasColumnName("id_cabin");

                    b.Property<int>("IdAppointment1")
                        .HasColumnType("int")
                        .HasColumnName("id_appointment_1");

                    b.HasKey("IdCabin", "IdAppointment1")
                        .HasName("PK_CABINXAPPOINTMET_1");

                    b.HasIndex("IdAppointment1");

                    b.ToTable("CABINXAPPOINTMENT_1");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Cabinxappointment2", b =>
                {
                    b.Property<int>("IdCabin")
                        .HasColumnType("int")
                        .HasColumnName("id_cabin");

                    b.Property<int>("IdAppointment2")
                        .HasColumnType("int")
                        .HasColumnName("id_appointment_2");

                    b.HasKey("IdCabin", "IdAppointment2")
                        .HasName("PK_CABINXAPPOINTMET_2");

                    b.HasIndex("IdAppointment2");

                    b.ToTable("CABINXAPPOINTMENT_2");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.ChronicDisease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DuiCitizen")
                        .HasColumnType("int")
                        .HasColumnName("dui_citizen");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("DuiCitizen");

                    b.ToTable("CHRONIC_DISEASE");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Citizen", b =>
                {
                    b.Property<int>("Dui")
                        .HasColumnType("int")
                        .HasColumnName("dui");

                    b.Property<string>("Direction")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("direction");

                    b.Property<string>("Mail")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("mail");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasMaxLength(9)
                        .IsUnicode(false)
                        .HasColumnType("varchar(9)")
                        .HasColumnName("phone");

                    b.HasKey("Dui")
                        .HasName("PK__CITIZEN__D876F1BE4BEAA863");

                    b.ToTable("CITIZEN");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Dose1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time");

                    b.Property<int>("DuiCitizen")
                        .HasColumnType("int")
                        .HasColumnName("dui_citizen");

                    b.HasKey("Id");

                    b.HasIndex("DuiCitizen");

                    b.ToTable("DOSE_1");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Dose1xsideEffect", b =>
                {
                    b.Property<int>("IdSideEffect")
                        .HasColumnType("int")
                        .HasColumnName("id_side_effect");

                    b.Property<int>("IdDose1")
                        .HasColumnType("int")
                        .HasColumnName("id_dose_1");

                    b.Property<string>("Time")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("time");

                    b.HasKey("IdSideEffect", "IdDose1");

                    b.HasIndex("IdDose1");

                    b.ToTable("DOSE_1XSIDE_EFFECT");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Dose2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time");

                    b.Property<int>("DuiCitizen")
                        .HasColumnType("int")
                        .HasColumnName("dui_citizen");

                    b.HasKey("Id");

                    b.HasIndex("DuiCitizen");

                    b.ToTable("DOSE_2");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Dose2xsideEffect", b =>
                {
                    b.Property<int>("IdSideEffect")
                        .HasColumnType("int")
                        .HasColumnName("id_side_effect");

                    b.Property<int>("IdDose2")
                        .HasColumnType("int")
                        .HasColumnName("id_dose_2");

                    b.Property<string>("Time")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("time");

                    b.HasKey("IdSideEffect", "IdDose2");

                    b.HasIndex("IdDose2");

                    b.ToTable("DOSE_2XSIDE_EFFECT");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Institution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DuiCitizen")
                        .HasColumnType("int")
                        .HasColumnName("dui_citizen");

                    b.Property<string>("InstID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("DuiCitizen");

                    b.ToTable("INSTITUTION");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Manager", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("EmployeeType")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("employee_type");

                    b.Property<string>("HomeDirection")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("home_direction");

                    b.Property<string>("InstitutionalMail")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("institutional_mail");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("MANAGER");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.PriorityGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DuiCitizen")
                        .HasColumnType("int")
                        .HasColumnName("dui_citizen");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("DuiCitizen");

                    b.ToTable("PRIORITY_GROUP");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.RegistrationStart", b =>
                {
                    b.Property<int>("IdManager")
                        .HasColumnType("int")
                        .HasColumnName("id_manager");

                    b.Property<int>("IdCabin")
                        .HasColumnType("int")
                        .HasColumnName("id_cabin");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time");

                    b.HasKey("IdManager", "IdCabin")
                        .HasName("PK_MANAGERXCABIN");

                    b.HasIndex("IdCabin");

                    b.ToTable("REGISTRATION_START");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.SideEffect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("SIDE_EFFECT");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.WaitRow1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time");

                    b.Property<int>("DuiAppointment1")
                        .HasColumnType("int")
                        .HasColumnName("dui_appointment_1");

                    b.HasKey("Id");

                    b.HasIndex("DuiAppointment1");

                    b.ToTable("WAIT_ROW1");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.WaitRow2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("date_time");

                    b.Property<int>("DuiAppointment2")
                        .HasColumnType("int")
                        .HasColumnName("dui_appointment_2");

                    b.HasKey("Id");

                    b.HasIndex("DuiAppointment2");

                    b.ToTable("WAIT_ROW2");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Appointment1", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Citizen", "DuiCitizenNavigation")
                        .WithMany("Appointment1s")
                        .HasForeignKey("DuiCitizen")
                        .HasConstraintName("FK_CITIZENXAPPOINTMET_1")
                        .IsRequired();

                    b.Navigation("DuiCitizenNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Appointment2", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Citizen", "DuiCitizenNavigation")
                        .WithMany("Appointment2s")
                        .HasForeignKey("DuiCitizen")
                        .HasConstraintName("FK_CITIZENXAPPOINTMET_2")
                        .IsRequired();

                    b.Navigation("DuiCitizenNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Cabinxappointment1", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Appointment1", "IdAppointment1Navigation")
                        .WithMany("Cabinxappointment1s")
                        .HasForeignKey("IdAppointment1")
                        .HasConstraintName("FK__CABINXAPP__id_ap__3C69FB99")
                        .IsRequired();

                    b.HasOne("COVID_19.ES.CovidContext.Cabin", "IdCabinNavigation")
                        .WithMany("Cabinxappointment1s")
                        .HasForeignKey("IdCabin")
                        .HasConstraintName("FK__CABINXAPP__id_ca__3B75D760")
                        .IsRequired();

                    b.Navigation("IdAppointment1Navigation");

                    b.Navigation("IdCabinNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Cabinxappointment2", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Appointment2", "IdAppointment2Navigation")
                        .WithMany("Cabinxappointment2s")
                        .HasForeignKey("IdAppointment2")
                        .HasConstraintName("FK__CABINXAPP__id_ap__403A8C7D")
                        .IsRequired();

                    b.HasOne("COVID_19.ES.CovidContext.Cabin", "IdCabinNavigation")
                        .WithMany("Cabinxappointment2s")
                        .HasForeignKey("IdCabin")
                        .HasConstraintName("FK__CABINXAPP__id_ca__3F466844")
                        .IsRequired();

                    b.Navigation("IdAppointment2Navigation");

                    b.Navigation("IdCabinNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.ChronicDisease", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Citizen", "DuiCitizenNavigation")
                        .WithMany("ChronicDiseases")
                        .HasForeignKey("DuiCitizen")
                        .HasConstraintName("FK_CITIZENXCHRONIC_DISEASE")
                        .IsRequired();

                    b.Navigation("DuiCitizenNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Dose1", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Citizen", "DuiCitizenNavigation")
                        .WithMany("Dose1s")
                        .HasForeignKey("DuiCitizen")
                        .HasConstraintName("FK_CITIZENXDOSE_1")
                        .IsRequired();

                    b.Navigation("DuiCitizenNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Dose1xsideEffect", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Dose1", "IdDose1Navigation")
                        .WithMany("Dose1xsideEffects")
                        .HasForeignKey("IdDose1")
                        .HasConstraintName("FK__DOSE_1XSI__id_do__52593CB8")
                        .IsRequired();

                    b.HasOne("COVID_19.ES.CovidContext.SideEffect", "IdSideEffectNavigation")
                        .WithMany("Dose1xsideEffects")
                        .HasForeignKey("IdSideEffect")
                        .HasConstraintName("FK__DOSE_1XSI__id_si__5165187F")
                        .IsRequired();

                    b.Navigation("IdDose1Navigation");

                    b.Navigation("IdSideEffectNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Dose2", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Citizen", "DuiCitizenNavigation")
                        .WithMany("Dose2s")
                        .HasForeignKey("DuiCitizen")
                        .HasConstraintName("FK_CITIZENXDOSE_2")
                        .IsRequired();

                    b.Navigation("DuiCitizenNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Dose2xsideEffect", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Dose2", "IdDose2Navigation")
                        .WithMany("Dose2xsideEffects")
                        .HasForeignKey("IdDose2")
                        .HasConstraintName("FK__DOSE_2XSI__id_do__5629CD9C")
                        .IsRequired();

                    b.HasOne("COVID_19.ES.CovidContext.SideEffect", "IdSideEffectNavigation")
                        .WithMany("Dose2xsideEffects")
                        .HasForeignKey("IdSideEffect")
                        .HasConstraintName("FK__DOSE_2XSI__id_si__5535A963")
                        .IsRequired();

                    b.Navigation("IdDose2Navigation");

                    b.Navigation("IdSideEffectNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Institution", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Citizen", "DuiCitizenNavigation")
                        .WithMany("Institutions")
                        .HasForeignKey("DuiCitizen")
                        .HasConstraintName("FK_CITIZENXINSTITUTION")
                        .IsRequired();

                    b.Navigation("DuiCitizenNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.PriorityGroup", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Citizen", "DuiCitizenNavigation")
                        .WithMany("PriorityGroups")
                        .HasForeignKey("DuiCitizen")
                        .HasConstraintName("FK_CITIZENXPRIORITY_GROUP")
                        .IsRequired();

                    b.Navigation("DuiCitizenNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.RegistrationStart", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Cabin", "IdCabinNavigation")
                        .WithMany("RegistrationStarts")
                        .HasForeignKey("IdCabin")
                        .HasConstraintName("FK__REGISTRAT__id_ca__38996AB5")
                        .IsRequired();

                    b.HasOne("COVID_19.ES.CovidContext.Manager", "IdManagerNavigation")
                        .WithMany("RegistrationStarts")
                        .HasForeignKey("IdManager")
                        .HasConstraintName("FK__REGISTRAT__id_ma__37A5467C")
                        .IsRequired();

                    b.Navigation("IdCabinNavigation");

                    b.Navigation("IdManagerNavigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.WaitRow1", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Appointment1", "DuiAppointment1Navigation")
                        .WithMany("WaitRow1s")
                        .HasForeignKey("DuiAppointment1")
                        .HasConstraintName("FK_APPOINTMENT_1XWAIT_ROW1")
                        .IsRequired();

                    b.Navigation("DuiAppointment1Navigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.WaitRow2", b =>
                {
                    b.HasOne("COVID_19.ES.CovidContext.Appointment2", "DuiAppointment2Navigation")
                        .WithMany("WaitRow2s")
                        .HasForeignKey("DuiAppointment2")
                        .HasConstraintName("FK_APPOINTMENT_2XWAIT_ROW2")
                        .IsRequired();

                    b.Navigation("DuiAppointment2Navigation");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Appointment1", b =>
                {
                    b.Navigation("Cabinxappointment1s");

                    b.Navigation("WaitRow1s");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Appointment2", b =>
                {
                    b.Navigation("Cabinxappointment2s");

                    b.Navigation("WaitRow2s");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Cabin", b =>
                {
                    b.Navigation("Cabinxappointment1s");

                    b.Navigation("Cabinxappointment2s");

                    b.Navigation("RegistrationStarts");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Citizen", b =>
                {
                    b.Navigation("Appointment1s");

                    b.Navigation("Appointment2s");

                    b.Navigation("ChronicDiseases");

                    b.Navigation("Dose1s");

                    b.Navigation("Dose2s");

                    b.Navigation("Institutions");

                    b.Navigation("PriorityGroups");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Dose1", b =>
                {
                    b.Navigation("Dose1xsideEffects");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Dose2", b =>
                {
                    b.Navigation("Dose2xsideEffects");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.Manager", b =>
                {
                    b.Navigation("RegistrationStarts");
                });

            modelBuilder.Entity("COVID_19.ES.CovidContext.SideEffect", b =>
                {
                    b.Navigation("Dose1xsideEffects");

                    b.Navigation("Dose2xsideEffects");
                });
#pragma warning restore 612, 618
        }
    }
}
