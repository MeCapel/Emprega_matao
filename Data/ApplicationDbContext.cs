using projeto_integrador.Models;
using Microsoft.EntityFrameworkCore;

namespace projeto_integrador.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Config to link Connection String from "appsettings.json" to the preject
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
