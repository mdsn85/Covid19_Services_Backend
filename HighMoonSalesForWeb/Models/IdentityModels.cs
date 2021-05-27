using System.ComponentModel.DataAnnotations;

using System.Security.Claims;
using System.Threading.Tasks;


namespace HighMoonSalesForWeb.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public bool? IsEnabled { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{7})$", ErrorMessage = "Not a valid phone number in formate 0xx xxxxxxx")]
        public string Mobile { get; set; }

        //[RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{7})$", ErrorMessage = "Not a valid phone number in formate 0x xxxxxxx")]
        //public string Telephone { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }




        public DbSet<Unit> Units { get; set; }
        public DbSet<Material> Materials { get; set; }

        public DbSet<Employee> Employees { get; set; }




        public System.Data.Entity.DbSet<CuttingSheet> CuttingSheets { get; set; }
        public System.Data.Entity.DbSet<CuttingSheetDetail> CuttingSheetDetails { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Warehouse> Warehouses { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Lpo> Lpoes { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.LpoDetail> LpoDetails { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.CreditTerm> CreditTerms { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.supplier> suppliers { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.StockIssueType> StockIssueTypes { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.StockIssue> StockIssues { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.StockIssueDetail> StockIssueDetails { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.LpoTerms> LpoTerms { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.LpoSequense> LpoSequense { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.MaterialUnit> MaterialUnits { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.CuttingSheetSequense> CuttingSheetSequenses { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.LpoStatus> LpoStatus { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.SalesMan> SalesMen { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Project> Projects { get; set; }

        //public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Project1> Project1 { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.ProjectPaymentTerm> ProjectPaymentTerms { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Designer> Designers { get; set; }


        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Project2> Project2 { get; set; }


        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.CustomersType> CustomersTypes { get; set; }


        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.SalesType> SalesTypes { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.ProjectStatus> ProjectStatus { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.ProjectFile> projectFiles { get; set; }
        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.EmployeeUser> EmployeeUsers { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Payment> Payments { get; set; }


        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.StockIssueSequense> StockIsssueSequense { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Permission> Permissions { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.PermissionUser> PermissionUsers { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.ApprovalType> ApprovalTypes { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.RequestApproval> RequestApprovals { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Quotation> Quotations { get; set; }
        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.EmailServer> EmailServers { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.SalesTeam> SalesTeam { get; set; }


        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.CreditTermSupplier> CreditTermSuppliers { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.MaterialCategory> MaterialCategorys { get; set; }
        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.MaterialType> MaterialTypes { get; set; }


        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Area> Areas { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Notification1> Notifications { get; set; }
        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.NotificationCategory> NotificationCategorys { get; set; }
        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.NotificationCatUser> NotificationCatUsers { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.CuttingSheetFile> CuttingSheetFiles { get; set; }
        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.LpoLocation> LpoLocations { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.PaymentMoodSupplier> PaymentMoodSuppliers { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.LpoNature> LpoNatures { get; set; }


        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Invoice> Invoices { get; set; }


        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.InvoiceSequense> InvoiceSequenses { get; set; }


        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.ModeOfLead> ModeOfLeads { get; set; }
        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.StatusOFLead> StatusOFLeads { get; set; }
        public System.Data.Entity.DbSet<HighMoonSalesForWeb.Models.Lead> leads { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<InvoiceProduct>()
           .HasKey(x => new { x.InvoiceId, x.ProductId });

            modelBuilder.Entity<InvoiceProduct>()
            .HasRequired(pt => pt.Invoice)
            .WithMany(p => p.InvoiceProducts)
            .HasForeignKey(pt => pt.InvoiceId);

            modelBuilder.Entity<InvoiceProduct>()
                .HasRequired(pt => pt.Product)
                .WithMany(t => t.InvoiceProducts)
                .HasForeignKey(pt => pt.ProductId);
        }

    }
}