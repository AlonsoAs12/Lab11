using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Detail> Details { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAB1504-22\\SQLEXPRESS;" + "Initial Catalog=LAB11;Integrated Security=True;trustservercertificate=True");
    }

} 