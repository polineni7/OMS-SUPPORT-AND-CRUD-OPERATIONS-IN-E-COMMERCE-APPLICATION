using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAPI.Models
{
    public partial class BitAppsOMSContext : DbContext
    {
        public BitAppsOMSContext()
        {
        }

        public BitAppsOMSContext(DbContextOptions<BitAppsOMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Createorder> Createorders { get; set; }
        public virtual DbSet<Ordersheet> Ordersheets { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Productreview> Productreviews { get; set; }
        public virtual DbSet<Returnservice> Returnservices { get; set; }
        public virtual DbSet<Servicereview> Servicereviews { get; set; }
        public virtual DbSet<Shipingdetail> Shipingdetails { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-1LIGJFR;Database=BitAppsOMS;Trusted_Connection=True;");
#pragma warning restore CS1030 // #warning directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bill");

                entity.Property(e => e.Billid).HasColumnName("billid");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Ostatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ostatus");

            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.HasIndex(e => e.Email, "UQ__client__AB6E61640CA7480F")
                    .IsUnique();

                entity.HasIndex(e => e.Phone, "UQ__client__B43B145FBEB3832A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branch)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("branch");

                entity.Property(e => e.Caddress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("caddress");

                entity.Property(e => e.Cdescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("cdescription");

                entity.Property(e => e.Cname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cname");

                entity.Property(e => e.Cothernotes)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("cothernotes");

                entity.Property(e => e.Email)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<Createorder>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("PK__createor__C2FFCF13967D9C1E");

                entity.ToTable("createorder");

                entity.HasIndex(e => new { e.Ponumber, e.Orderdate, e.Ophone }, "combinationuniq")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Clienname)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("clienname");

                entity.Property(e => e.Deadlinedate)
                    .HasColumnType("date")
                    .HasColumnName("deadlinedate");

                entity.Property(e => e.Oaddress)
                    .HasMaxLength(95)
                    .IsUnicode(false)
                    .HasColumnName("oaddress");

                entity.Property(e => e.Obranch)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obranch");

                entity.Property(e => e.Ophone).HasColumnName("ophone");

                entity.Property(e => e.Orderdate)
                    .HasColumnType("date")
                    .HasColumnName("orderdate");

                entity.Property(e => e.Ponumber).HasColumnName("PONumber");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Ordersheet>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__ordershe__CA1FE4649CB9759E");

                entity.ToTable("ordersheet");

                entity.HasIndex(e => new { e.Oid, e.Pid, e.Qty, e.Rate, e.Pname, e.Pdescription }, "combinationuniq1")
                    .IsUnique();

                entity.Property(e => e.Clientname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("clientname");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Pdescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pdescription");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(13, 4)")
                    .HasColumnName("rate");

                entity.Property(e => e.Venname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("venname");

            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.HasIndex(e => e.Pname, "UQ__products__1FC9734C5E039AB6")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Pdescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pdescription");

                entity.Property(e => e.Pname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Rdate)
                    .HasColumnType("date")
                    .HasColumnName("rdate");
            });

            modelBuilder.Entity<Productreview>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Productr__DDDF6446C2F7FACB");

                entity.ToTable("Productreview");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Pdescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pdescription");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Pqty).HasColumnName("pqty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(13, 4)")
                    .HasColumnName("rate");

            });

            modelBuilder.Entity<Returnservice>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__returnse__C2B7EDE80BD7DCCD");

                entity.ToTable("returnservice");

                entity.HasIndex(e => new { e.Oid, e.Returndate, e.Pid }, "combinationuq3")
                    .IsUnique();

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.PartialNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("partialNo");

                entity.Property(e => e.Pdescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pdescription");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Pqty).HasColumnName("pqty");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(13, 4)")
                    .HasColumnName("rate");

                entity.Property(e => e.Returndate)
                    .HasColumnType("date")
                    .HasColumnName("returndate");

                entity.Property(e => e.Transporttype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transporttype");

            });

            modelBuilder.Entity<Servicereview>(entity =>
            {
                entity.HasKey(e => e.Srid)
                    .HasName("PK__Servicer__36B11BD52F91B666");

                entity.ToTable("Servicereview");

                entity.HasIndex(e => new { e.Oid, e.So, e.Pid }, "combinationuq")
                    .IsUnique();

                entity.Property(e => e.Srid).HasColumnName("srid");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.PartialNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("partialNo");

                entity.Property(e => e.Pdescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pdescription");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Pqty).HasColumnName("pqty");

                entity.Property(e => e.Proceditems).HasColumnName("proceditems");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(13, 4)")
                    .HasColumnName("rate");

                entity.Property(e => e.So).HasColumnName("SO");

                entity.Property(e => e.Transporttype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transporttype");


            });

            modelBuilder.Entity<Shipingdetail>(entity =>
            {
                entity.HasKey(e => e.Billid)
                    .HasName("PK__Shipingd__6D9D238BC232403A");

                entity.HasIndex(e => new { e.Srid, e.Oid, e.Shipingdate }, "combinationuqSB")
                    .IsUnique();

                entity.Property(e => e.Billid).HasColumnName("billid");

                entity.Property(e => e.Clientname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("clientname");

                entity.Property(e => e.Noqty).HasColumnName("noqty");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.PartialNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("partialNo");

                entity.Property(e => e.Pdescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pdescription");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Proceditems).HasColumnName("proceditems");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(13, 4)")
                    .HasColumnName("rate");

                entity.Property(e => e.Shipingdate)
                    .HasColumnType("date")
                    .HasColumnName("shipingdate");

                entity.Property(e => e.Srid).HasColumnName("srid");

                entity.Property(e => e.Transporttype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transporttype");

                entity.Property(e => e.Venname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("venname");

            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Mailid, "UQ__users__F5CE7C81907E6E43")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mailid)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mailid");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Userpassword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("userpassword");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => e.Vid)
                    .HasName("PK__vendor__DDB00C7D4A01597E");

                entity.ToTable("vendor");

                entity.HasIndex(e => e.Vphone, "UQ__vendor__8BF9232DDA924A32")
                    .IsUnique();

                entity.HasIndex(e => e.Vemail, "UQ__vendor__9416E26D01747005")
                    .IsUnique();

                entity.Property(e => e.Vid).HasColumnName("vid");

                entity.Property(e => e.Vaddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vaddress");

                entity.Property(e => e.Vbranch)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vbranch");

                entity.Property(e => e.Vdescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("vdescription");

                entity.Property(e => e.Vemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vemail");

                entity.Property(e => e.Vname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vname");

                entity.Property(e => e.Vothernotes)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("vothernotes");

                entity.Property(e => e.Vphone).HasColumnName("vphone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
