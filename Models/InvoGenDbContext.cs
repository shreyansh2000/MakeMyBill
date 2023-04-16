using MakeMyBill.Models;
using Microsoft.EntityFrameworkCore;

namespace MakeMyBill.Models
{
    public class InvoGenDbContext : DbContext
    {

        public InvoGenDbContext(DbContextOptions<InvoGenDbContext>
            options) : base(options)
        { 
        }

        public DbSet<BranchMaster> BranchMasters { get; set; }

        public DbSet<CompanyMaster> CompanyMasters { get; set; }
        public DbSet<ComplainMaster> ComplainMasters { get; set; }
        public DbSet<CustomerMaster> CustomerMasters { get; set; }
        public DbSet<FeedbackMaster> FeedbackMasters { get; set; }

        public DbSet<ProductMainCategoryMaster> ProudctMainCategoryMasters { get; set; }
        public DbSet<ProductSubCategoryMaster> ProductSubCategoryMasters { get; set; }
        public DbSet<QuestionMaster> QuestionMasters { get; set; }

        public DbSet<CartMaster> cartMasters { get; set; }

        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }

        public DbSet<InvoiceMaster> InvoiceMaster { get; set; }


    }
}
