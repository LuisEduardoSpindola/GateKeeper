using AuthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthAPI.Data;

public class AuthContext : DbContext
{
    public AuthContext(DbContextOptions<AuthContext> options) : base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; }
}