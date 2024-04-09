using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TaxApp_v2.Models.DataLayer;

public partial class TaxAppContext : DbContext
{
    public TaxAppContext()
    {
    }

    public TaxAppContext(DbContextOptions<TaxAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Form1040> Form1040s { get; set; }

    public virtual DbSet<Form1040Dependent> Form1040Dependents { get; set; }

    public virtual DbSet<Form1040Income> Form1040Incomes { get; set; }

    public virtual DbSet<Form1040TaxPayment> Form1040TaxPayments { get; set; }

    public virtual DbSet<Form1098e> Form1098es { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<ScheduleDLongTerm> ScheduleDLongTerms { get; set; }

    public virtual DbSet<ScheduleDMetadatum> ScheduleDMetadata { get; set; }

    public virtual DbSet<ScheduleDShortTerm> ScheduleDShortTerms { get; set; }

    public virtual DbSet<ScheduleDSummary> ScheduleDSummaries { get; set; }

    public virtual DbSet<ScheduleK1> ScheduleK1s { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<W2> W2s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json")
               .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__appointm__A50828FCD1498BF8");

            entity.HasOne(d => d.Client).WithMany(p => p.Appointments).HasConstraintName("FK__appointme__clien__28ED12D1");

            entity.HasOne(d => d.Employee).WithMany(p => p.Appointments).HasConstraintName("FK__appointme__emplo__29E1370A");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__clients__BF21A42410058C01");

            entity.Property(e => e.AccountNumber).IsFixedLength();
            entity.Property(e => e.RoutingNumber).IsFixedLength();
            entity.Property(e => e.Ssn).IsFixedLength();
            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.Zip).IsFixedLength();

            entity.HasOne(d => d.User).WithMany(p => p.Clients).HasConstraintName("FK__clients__user_id__22401542");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__employee__C52E0BA8568713C9");

            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.Zip).IsFixedLength();

            entity.HasOne(d => d.User).WithOne(p => p.Employee).HasConstraintName("FK__employees__user___1E6F845E");
        });

        modelBuilder.Entity<Form1040>(entity =>
        {
            entity.HasKey(e => e.Form1040Id).HasName("PK__form1040__402C2DECB4DD2079");

            entity.Property(e => e.EndingYearLast2Digits).IsFixedLength();
            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.Zip).IsFixedLength();

            entity.HasOne(d => d.Client).WithMany(p => p.Form1040s).HasConstraintName("FK__form1040__client__40C49C62");
        });

        modelBuilder.Entity<Form1040Dependent>(entity =>
        {
            entity.HasKey(e => e.Form1040DependentsId).HasName("PK__form1040__EF89CAAAE8FC867C");

            entity.Property(e => e.Ssn).IsFixedLength();

            entity.HasOne(d => d.Form1040).WithOne(p => p.Form1040Dependent).HasConstraintName("FK__form1040___form1__4589517F");
        });

        modelBuilder.Entity<Form1040Income>(entity =>
        {
            entity.HasKey(e => e.Form1040IncomeId).HasName("PK__form1040__7E39C04D8A50D05F");

            entity.HasOne(d => d.Form1040).WithOne(p => p.Form1040Income).HasConstraintName("FK__form1040___form1__4959E263");
        });

        modelBuilder.Entity<Form1040TaxPayment>(entity =>
        {
            entity.HasKey(e => e.Form1040TaxPaymentsId).HasName("PK__form1040__4C46E57C2858FC13");

            entity.Property(e => e.DesigneePin).IsFixedLength();
            entity.Property(e => e.IdentityProtectionPin).IsFixedLength();
            entity.Property(e => e.PreparerFirmEin).IsFixedLength();
            entity.Property(e => e.PreparerPtin).IsFixedLength();
            entity.Property(e => e.PreparerState).IsFixedLength();
            entity.Property(e => e.PreparerZip).IsFixedLength();
            entity.Property(e => e.SpouseIdentityProtectionPin).IsFixedLength();

            entity.HasOne(d => d.Form1040).WithOne(p => p.Form1040TaxPayment).HasConstraintName("FK__form1040___form1__4D2A7347");
        });

        modelBuilder.Entity<Form1098e>(entity =>
        {
            entity.HasKey(e => e.Form1098eId).HasName("PK__form1098__8CF639B3F0DB4C96");

            entity.Property(e => e.AccountNumber).IsFixedLength();
            entity.Property(e => e.BorrowerTin).IsFixedLength();
            entity.Property(e => e.RecipientState).IsFixedLength();
            entity.Property(e => e.RecipientTin).IsFixedLength();
            entity.Property(e => e.RecipientZip).IsFixedLength();

            entity.HasOne(d => d.Client).WithMany(p => p.Form1098es).HasConstraintName("FK__form1098e__clien__3B0BC30C");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasName("PK__invoices__F58DFD499D78FDC9");

            entity.HasOne(d => d.Client).WithMany(p => p.Invoices).HasConstraintName("FK__invoices__client__251C81ED");

            entity.HasOne(d => d.Employee).WithMany(p => p.Invoices).HasConstraintName("FK__invoices__employ__2610A626");
        });

        modelBuilder.Entity<ScheduleDLongTerm>(entity =>
        {
            entity.HasKey(e => e.ScheduleDLongTermId).HasName("PK__schedule__C9C678BB5F8CBA5D");

            entity.HasOne(d => d.ScheduleDMetadata).WithMany(p => p.ScheduleDLongTerms).HasConstraintName("FK__schedule___sched__3552E9B6");
        });

        modelBuilder.Entity<ScheduleDMetadatum>(entity =>
        {
            entity.HasKey(e => e.ScheduleDMetadataId).HasName("PK__schedule__E9979935BDBE1AB9");

            entity.HasOne(d => d.Client).WithMany(p => p.ScheduleDMetadata).HasConstraintName("FK__schedule___clien__2F9A1060");
        });

        modelBuilder.Entity<ScheduleDShortTerm>(entity =>
        {
            entity.HasKey(e => e.ScheduleDShortTermId).HasName("PK__schedule__EBBF033894C2F017");

            entity.HasOne(d => d.ScheduleDMetadata).WithMany(p => p.ScheduleDShortTerms).HasConstraintName("FK__schedule___sched__32767D0B");
        });

        modelBuilder.Entity<ScheduleDSummary>(entity =>
        {
            entity.HasKey(e => e.ScheduleDSummaryId).HasName("PK__schedule__8AEB1B5CB6B3EE17");

            entity.HasOne(d => d.ScheduleDMetadata).WithMany(p => p.ScheduleDSummaries).HasConstraintName("FK__schedule___sched__382F5661");
        });

        modelBuilder.Entity<ScheduleK1>(entity =>
        {
            entity.HasKey(e => e.ScheduleK1Id).HasName("PK__schedule__8C5CF6B96B889751");

            entity.Property(e => e.BeneficiaryId).IsFixedLength();
            entity.Property(e => e.BeneficiaryState).IsFixedLength();
            entity.Property(e => e.BeneficiaryZip).IsFixedLength();
            entity.Property(e => e.EstateOrTrustEin).IsFixedLength();
            entity.Property(e => e.FiduciaryState).IsFixedLength();
            entity.Property(e => e.FiduciaryZip).IsFixedLength();

            entity.HasOne(d => d.Client).WithMany(p => p.ScheduleK1s).HasConstraintName("FK__schedule___clien__3DE82FB7");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__users__B9BE370F17D44DE6");
        });

        modelBuilder.Entity<W2>(entity =>
        {
            entity.HasKey(e => e.W2Id).HasName("PK__w2__7BC5B41ACC651069");

            entity.Property(e => e.Box12aCode).IsFixedLength();
            entity.Property(e => e.Box12bCode).IsFixedLength();
            entity.Property(e => e.Box12cCode).IsFixedLength();
            entity.Property(e => e.Box12dCode).IsFixedLength();
            entity.Property(e => e.ControlNumber).IsFixedLength();
            entity.Property(e => e.EmployerEin).IsFixedLength();
            entity.Property(e => e.EmployerState).IsFixedLength();
            entity.Property(e => e.EmployerZip).IsFixedLength();
            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.StateEmployerId).IsFixedLength();

            entity.HasOne(d => d.Client).WithMany(p => p.W2s).HasConstraintName("FK__w2__client_id__2CBDA3B5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
