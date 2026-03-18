using API.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data {
   public class ApplicationDbContext(
      DbContextOptions<ApplicationDbContext> options)
      :IdentityDbContext(options) {



      // definir as tabelas da Base de Dados
      public DbSet<Photography> Photos { get; set; }
      public DbSet<MyUser> Clients { get; set; }
      public DbSet<Category> Categories { get; set; }
      public DbSet<Purchase> Purchases { get; set; }


   }
}
