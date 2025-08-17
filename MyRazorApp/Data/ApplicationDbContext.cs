using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyRazorApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // DbSet properties for tables
    public DbSet<ApiKeys> ApiKeys { get; set; }
}

// API Keys Table
public class ApiKeys
{
    // Unique ID
    [Key]
    public int Id { get; set; }

    // API Key
    [Required]
    public string Key { get; set; } = default!;
}