using System.Data.Entity.ModelConfiguration;

namespace Expenses.Model
{
    public class ApplicationUserConfiguration : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserConfiguration()
        {
            HasRequired(v => v.Account)
                .WithRequiredPrincipal()
                .WillCascadeOnDelete(false);
        }
    }
}
