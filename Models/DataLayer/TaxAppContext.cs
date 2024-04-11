using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\TaxApp-v2\\Database\\tax_app_db_v2.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__appointm__A50828FC6B6FC153");

            entity.HasOne(d => d.Client).WithMany(p => p.Appointments).HasConstraintName("FK__appointme__clien__1FB979A9");

            entity.HasOne(d => d.Employee).WithMany(p => p.Appointments).HasConstraintName("FK__appointme__emplo__20AD9DE2");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__clients__BF21A42446423B2D");

            entity.Property(e => e.AccountNumber).IsFixedLength();
            entity.Property(e => e.RoutingNumber).IsFixedLength();
            entity.Property(e => e.Ssn).IsFixedLength();
            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.Zip).IsFixedLength();

            entity.HasOne(d => d.User).WithMany(p => p.Clients).HasConstraintName("FK__clients__user_id__190C7C1A");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__employee__C52E0BA8622D6295");

            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.Zip).IsFixedLength();

            entity.HasOne(d => d.User).WithOne(p => p.Employee).HasConstraintName("FK__employees__user___153BEB36");
        });

        modelBuilder.Entity<Form1040>(entity =>
        {
            entity.HasKey(e => e.Form1040Id).HasName("PK__form1040__402C2DECB52647CA");

            entity.Property(e => e.EndingYearLast2Digits).IsFixedLength();
            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.Zip).IsFixedLength();

            entity.HasOne(d => d.Client).WithMany(p => p.Form1040s).HasConstraintName("FK__form1040__client__3791033A");
        });

        modelBuilder.Entity<Form1040Dependent>(entity =>
        {
            entity.HasKey(e => e.Form1040DependentsId).HasName("PK__form1040__EF89CAAACBAC30BC");

            entity.Property(e => e.Ssn).IsFixedLength();

            entity.HasOne(d => d.Form1040).WithOne(p => p.Form1040Dependent).HasConstraintName("FK__form1040___form1__3C55B857");
        });

        modelBuilder.Entity<Form1040Income>(entity =>
        {
            entity.HasKey(e => e.Form1040IncomeId).HasName("PK__form1040__7E39C04D7FAB3CF3");

            entity.HasOne(d => d.Form1040).WithOne(p => p.Form1040Income).HasConstraintName("FK__form1040___form1__4026493B");
        });

        modelBuilder.Entity<Form1040TaxPayment>(entity =>
        {
            entity.HasKey(e => e.Form1040TaxPaymentsId).HasName("PK__form1040__4C46E57C5F3B83E1");

            entity.Property(e => e.DesigneePin).IsFixedLength();
            entity.Property(e => e.IdentityProtectionPin).IsFixedLength();
            entity.Property(e => e.PreparerFirmEin).IsFixedLength();
            entity.Property(e => e.PreparerPtin).IsFixedLength();
            entity.Property(e => e.PreparerState).IsFixedLength();
            entity.Property(e => e.PreparerZip).IsFixedLength();
            entity.Property(e => e.SpouseIdentityProtectionPin).IsFixedLength();

            entity.HasOne(d => d.Form1040).WithOne(p => p.Form1040TaxPayment).HasConstraintName("FK__form1040___form1__43F6DA1F");
        });

        modelBuilder.Entity<Form1098e>(entity =>
        {
            entity.HasKey(e => e.Form1098eId).HasName("PK__form1098__8CF639B35248B55F");

            entity.Property(e => e.AccountNumber).IsFixedLength();
            entity.Property(e => e.BorrowerTin).IsFixedLength();
            entity.Property(e => e.RecipientState).IsFixedLength();
            entity.Property(e => e.RecipientTin).IsFixedLength();
            entity.Property(e => e.RecipientZip).IsFixedLength();

            entity.HasOne(d => d.Client).WithMany(p => p.Form1098es).HasConstraintName("FK__form1098e__clien__31D829E4");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasName("PK__invoices__F58DFD49C3EF6389");

            entity.HasOne(d => d.Client).WithMany(p => p.Invoices).HasConstraintName("FK__invoices__client__1BE8E8C5");

            entity.HasOne(d => d.Employee).WithMany(p => p.Invoices).HasConstraintName("FK__invoices__employ__1CDD0CFE");
        });

        modelBuilder.Entity<ScheduleDLongTerm>(entity =>
        {
            entity.HasKey(e => e.ScheduleDLongTermId).HasName("PK__schedule__C9C678BB62B1D7B4");

            entity.HasOne(d => d.ScheduleDMetadata).WithMany(p => p.ScheduleDLongTerms).HasConstraintName("FK__schedule___sched__2C1F508E");
        });

        modelBuilder.Entity<ScheduleDMetadatum>(entity =>
        {
            entity.HasKey(e => e.ScheduleDMetadataId).HasName("PK__schedule__E9979935AEFF0B6E");

            entity.HasOne(d => d.Client).WithMany(p => p.ScheduleDMetadata).HasConstraintName("FK__schedule___clien__26667738");
        });

        modelBuilder.Entity<ScheduleDShortTerm>(entity =>
        {
            entity.HasKey(e => e.ScheduleDShortTermId).HasName("PK__schedule__EBBF033823D71A64");

            entity.HasOne(d => d.ScheduleDMetadata).WithMany(p => p.ScheduleDShortTerms).HasConstraintName("FK__schedule___sched__2942E3E3");
        });

        modelBuilder.Entity<ScheduleDSummary>(entity =>
        {
            entity.HasKey(e => e.ScheduleDSummaryId).HasName("PK__schedule__8AEB1B5C332FC988");

            entity.HasOne(d => d.ScheduleDMetadata).WithMany(p => p.ScheduleDSummaries).HasConstraintName("FK__schedule___sched__2EFBBD39");
        });

        modelBuilder.Entity<ScheduleK1>(entity =>
        {
            entity.HasKey(e => e.ScheduleK1Id).HasName("PK__schedule__8C5CF6B99CA9A43A");

            entity.Property(e => e.BeneficiaryId).IsFixedLength();
            entity.Property(e => e.BeneficiaryState).IsFixedLength();
            entity.Property(e => e.BeneficiaryZip).IsFixedLength();
            entity.Property(e => e.EstateOrTrustEin).IsFixedLength();
            entity.Property(e => e.FiduciaryState).IsFixedLength();
            entity.Property(e => e.FiduciaryZip).IsFixedLength();

            entity.HasOne(d => d.Client).WithMany(p => p.ScheduleK1s).HasConstraintName("FK__schedule___clien__34B4968F");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__users__B9BE370FD711EF72");
        });

        modelBuilder.Entity<W2>(entity =>
        {
            entity.HasKey(e => e.W2Id).HasName("PK__w2__7BC5B41A8B904BF0");

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

            entity.HasOne(d => d.Client).WithMany(p => p.W2s).HasConstraintName("FK__w2__client_id__238A0A8D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
