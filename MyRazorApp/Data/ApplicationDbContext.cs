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
[Table("api_keys")]
public class ApiKeys
{
    // Unique ID
    [Key]
    [Column("api_key_id")]
    public int Id { get; set; }

    // API Key
    [Column("api_key")]
    [Required]
    public string Key { get; set; } = default!;
}