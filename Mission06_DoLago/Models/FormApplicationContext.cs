using Microsoft.EntityFrameworkCore;

namespace Mission06_DoLago.Models
{
    public class FormApplicationContext : DbContext
    {
        public FormApplicationContext(DbContextOptions<FormApplicationContext> options) : base(options)
        {
        }
        public DbSet<Form> Forms { get; set; } //watch out
    }
}
